namespace Base.Data {
	using System.Linq;
	using System.Data;
	using System.Reflection;
	using Tables; 
	using System.Collections.Generic; 
	
	using global::NHibernate; 
	using global::NHibernate.Cfg; 
	using global::NHibernate.Util; 
	using global::NHibernate.Driver;
	using global::NHibernate.Dialect;
	using global::NHibernate.Mapping.ByCode; 
	using global::NHibernate.Cfg.MappingSchema;

	public class StudentData : IDataBase
	{
		#region >>> Fields and Props
		string path = "./db.sqlite3";


		public string PathDB { 
			get
			{
				return path;
			}
			set
			{
				path = value;
				Reload(path);
			}
		}
		protected ISessionFactory db;
		#endregion

		#region >>> Constructors
		public StudentData() {
			Reload(PathDB);
		}
		public StudentData(string path) {
			Reload(path);
		}
		#endregion

		#region Methods
		public void Reload(string path) {
			this.path = path;

			var cfg = new Configuration();

			cfg.DataBaseIntegration(
				x => {
					x.ConnectionString =
					 string.Format(@"Data Source             = {0}; 
									 Initial Catalog         = NHibernateDemoDB; 
									 Integrated Security     = True; 
									 Connect Timeout         = 15; 
									 Encrypt                 = False; 
									 TrustServerCertificate  = False; 
									 ApplicationIntent       = ReadWrite; 
									 MultiSubnetFailover     = False;"
									, System.IO.Path.GetFullPath(PathDB)
					);

					x.Driver<SQLite20Driver>();
					x.Dialect<SQLiteDialect>();
				}
			);

			var mapper = new ModelMapper();
			mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());
			HbmMapping mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

			cfg.AddMapping(mapping);

			db = cfg.BuildSessionFactory();
		}
		#endregion
			
	#region >>> Interface realize
		#region >>> Geting data
		public int GetUID(string login, string pass) {
			int SID = -1;
			
			using ( var dbs = db.OpenSession() ) {
				var listStudent = dbs.CreateCriteria<Students>();

				foreach(var s in listStudent.List<Students>()) { 
					if(s.Login == login && s.Password == pass) SID = s.ID;
				}
			}

			return SID;
		}

		public List<string> GetAllowTest(int SID) {
			List<string> res = new List<string>();

			/* получить все доступные тесты и выполненные для юзера. Выбрать из доступных только не выполненные */

			using (var dbs = db.OpenSession()) {
				var compl = dbs.CreateCriteria<TestComplete>()?.List<TestComplete>().Where( x => x.SID == SID );
				var tests = dbs.CreateCriteria<Tests>()       ?.List<Tests>().Where( x => x.Access == 1 );
	
				tests = tests ?? new List<Tests>();
				compl = compl ?? new List<TestComplete>();
			
				res = tests.Where(x => compl.AsEnumerable().All(c => c.TID != x.ID)).Select( x => x.Name ).ToList();
			}
			return res;
		}

		public StudentInfo GetUserInfo(int SID) {
			StudentInfo res = new StudentInfo();

			using ( var dbs = db.OpenSession() ) {
				res = dbs.Get<StudentInfo>(SID);
			}

			return res;
		}

		public List<TestQuestion> GetQuestions(string testName) {
			List<TestQuestion> result = new List<TestQuestion>();

			using (var dbs = db.OpenSession() ) {
				int tid = dbs.CreateCriteria<Tests>().List<Tests>().Where( x => x.Name == testName ).First().ID; // ид теста

				var qstns = dbs.CreateCriteria<Questions>().List<Questions>().Where( x => x.TID == tid ); // вопросы к этому тесту
				var bAnsw = dbs.CreateCriteria<BadAnswers>().List<BadAnswers>();                          // неверные ответы

				foreach(var q in qstns) {
					TestQuestion tq = new TestQuestion();

					tq.ID         = q.ID;
					tq.TID        = tid;
					tq.Question   = q.Question;
					tq.Answer     = q.Answer;
					tq.AnswersBad = bAnsw.Where(x => x.QID == q.ID).ToList();
					tq.UAnswer    = "";

					result.Add(tq);
				}
			}

			return result;
		}

		public TestInfo GetTestInfo(string testName) {
			TestInfo res = new TestInfo();

			using ( var dbs = db.OpenSession() ) {
				var test = dbs.CreateCriteria<Tests>().List<Tests>().Where(x => x.Name == testName ).First();

				res.CountQuestion = dbs.CreateCriteria<Questions>().List<Questions>().Where( x => x.TID == test.ID ).Count();
				res.Name          = testName;
				res.LenghtMinutes = test.Time;
			}

			return res;
		}

		public List<Rules> GetRules(int SID) {
			List<Rules> res = new List<Rules>();

			using (var dbs = db.OpenSession() ) {
				res = dbs.CreateCriteria<Rules>().List<Rules>().Where( x => x.Access == 1 ).ToList();
			}

			return res;
		}

		public List<string> GetMediaPath(int UID) {
			List<string> res = new List<string>();

			using (var dbs = db.OpenSession()) {
				res.AddRange(dbs.CreateCriteria<MediaPath>().List<MediaPath>().Where( x => x.Access == 1 ).Select( x => x.Path ).ToList());
			}

			return res;
		}

		public List<string> GetCompleteTest(int SID) {
			List<string> res = new List<string>();

			using (var dbs = db.OpenSession()) {
				var compl = dbs.CreateCriteria<TestComplete>().List<TestComplete>().Where( x => x.Access == 1 && x.SID == SID );
				var tests = dbs.CreateCriteria<Tests>().List<Tests>();

				foreach( var ct in compl ) {
					res.AddRange(tests.Where( x => x.ID == ct.TID ).Select( x => x.Name ).ToList());
				}
			}

			return res;
		}

		public List<AnswersUser> GetTestResult(int SID, string testName) {
			List<AnswersUser> res = new List<AnswersUser>();

			using (var dbs = db.OpenSession()) {
				int tid       = dbs.CreateCriteria<Tests>         ().List<Tests>         ().Where( x => x.Name == testName).First().ID; // ид теста
				var questions = dbs.CreateCriteria<Questions>     ().List<Questions>     ().Where( x => x.TID == tid );                 // список вопросов для теста
				var answers   = dbs.CreateCriteria<AnswersStudent>().List<AnswersStudent>().Where( x => x.TID == tid );                 // ответы юзера для этого теста

				foreach( var q in questions ) {
					AnswersUser tmp = new AnswersUser();

					tmp.QID        = q.ID;
					tmp.SID        = SID;
					tmp.TID        = tid;
					tmp.Question   = q.Question;

					var t = answers.Where( x=> x.QID == q.ID).FirstOrDefault();
					tmp.Answer = (t != default) ? t.Answer : "Нет ответа";
							
					tmp.GoodAnswer = q.Answer;
					
					res.Add(tmp);
				}
			}

			return res;
		}
		#endregion

		#region >>> Запись данных 
		public void WriteTestResult( List<AnswersUser> tRes ) {
			List<AnswersStudent> answers = new List<AnswersStudent>();
			List<TestComplete>   tCompl  = new List<TestComplete>();

			foreach ( var i in tRes ) {
				AnswersStudent atmp = new AnswersStudent() {
					QID    = i.QID,
					SID    = i.SID,
					TID    = i.TID,
					Answer = i.Answer ?? "",
					ID     = 0
				};
				TestComplete ttmp = new TestComplete()  { 
					ID     = 0,
					SID    = i.SID,
					TID    = i.TID,
					Access = 0       // чтобы ученик не смог увидеть результат сразу
				};

				answers.Add(atmp);

				if ( tCompl.Where( x=> ttmp.SID == x.SID && ttmp.TID == x.TID ).Count() == 0 )  tCompl.Add(ttmp);
			}

			using (var dbs = db.OpenSession()) {
				var answers_exist = dbs.CreateCriteria<AnswersStudent>().List<AnswersStudent>();
				var complit_exist = dbs.CreateCriteria<TestComplete>  ().List<TestComplete>();

				foreach( var i in answers ) {
					var tmp = answers_exist.Where( x => x.QID == i.QID && x.SID == i.SID && x.TID == i.TID ).FirstOrDefault();

					if ( tmp != default ) i.ID = tmp.ID;
				}
				foreach( var i in tCompl ) {
					var tmp = complit_exist.Where( x => x.SID == i.SID && x.TID == i.TID ).FirstOrDefault();

					if ( tmp != default ) i.ID = tmp.ID;
				}
			
				// запись в бд
				using ( var tr = dbs.BeginTransaction() ) {
					answers.ForEach( (x) => { 
						if ( x.ID != 0) dbs.Update(x);
						else            dbs.Save(x);  
					});

					tCompl.ForEach( (x) => { 
						if ( x.ID != 0 ) dbs.Update(x);
						else             dbs.Save(x);	
					});

					tr.Commit();
				}				
			}
		}
		#endregion
	#endregion

	}
}
