namespace Base.Data
{
	using NHibernate;
	using NHibernate.Mapping;
	using NHibernate.Util;
	using Remotion.Linq.Clauses.ResultOperators;

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Security.Cryptography.X509Certificates;
	using System.Text;
	using System.Threading.Tasks;

	public class TeacherData : StudentData, IDataManager {
		public TeacherData() : base() {}
		public TeacherData(string path) : base(path) {}

		public List<Tables.Tests> GetAllTest() {
			List<Tables.Tests> res = new List<Tables.Tests>();

			using (var dbs = db.OpenSession()) {
				res = dbs.CreateCriteria<Tables.Tests>()
							       .List<Tables.Tests>()
							       .ToList();
			}

			return res;
		}

		public Student GetStudent(int sid) {
			Student res = new Student();

			using (var dbs = db.OpenSession()) {
				var user     = dbs.Get<Tables.Students>(sid);
				var userInfo = dbs.Get<Tables.StudentInfo>(sid);

				res.Update(user, userInfo);
			}

			return res;
		}
		
		public List<Tables.Students> GetAllStudents() {
			List<Tables.Students> res = new List<Tables.Students>();

			using (var dbs = db.OpenSession()) {
				res = dbs.CreateCriteria<Tables.Students>()
								   .List<Tables.Students>()
								   .ToList();
			}

			return res;
		}

		public List<Tables.Rules> GetAllRules() {
			List<Tables.Rules> res = new List<Tables.Rules>();

			using (var dbs = db.OpenSession()) {
				res = dbs.CreateCriteria<Tables.Rules>()
								   .List<Tables.Rules>()
								   .ToList();
			}

			return res;
		}

		public List<Tables.MediaPath> GetAllMediaPath() {
			List<Tables.MediaPath> res = new List<Tables.MediaPath>();

			using (var dbs = db.OpenSession()) {
				res = dbs.CreateCriteria<Tables.MediaPath>()
							       .List<Tables.MediaPath>()
							       .ToList();
			}

			return res;
		}

		public List<Tables.Questions> GetQuestions(int tid) {
			List<Tables.Questions> res = new List<Tables.Questions>();

			using (var dbs = db.OpenSession()) {
				res = dbs.CreateCriteria<Tables.Questions>()
								   .List<Tables.Questions>()
								   .Where( 
										x => x.TID == tid
								  ).ToList();
			}

			return res;
		}

		public List<Tables.BadAnswers> GetBadAnswers(int qid) {
			List<Tables.BadAnswers> res = new List<Tables.BadAnswers>();

			using ( var dbs = db.OpenSession() ) {
				res = dbs.CreateCriteria<Tables.BadAnswers>()
							       .List<Tables.BadAnswers>()
							       .Where(
										x => x.QID == qid
								  ).ToList();
			}

			return res;
		}

		public Test GetOneTest(int tid) {
			Test res = new Test();

			using ( var dbs = db.OpenSession() ) {
				var test = dbs.Get<Tables.Tests>(tid);
				var quest = dbs.CreateCriteria<Tables.Questions>()
									.List<Tables.Questions>()
									.Where( x => x.TID == tid);
				var badAnsw = dbs.CreateCriteria<Tables.BadAnswers>()
									.List<Tables.BadAnswers>()
									.Where(
										x => quest.Where( y => y.ID == x.QID ).Count() != 0
									);

				res.Update(test, quest.ToList(), badAnsw.ToList());
			}

			return res;
		}

		public List<Tables.Tests> GetCompleteTests(int sid) {
			List<Tables.Tests> res = new List<Tables.Tests>();

			using (var dbs = db.OpenSession()) {
				var cTests = dbs.CreateCriteria<Tables.TestComplete>()
								.List<Tables.TestComplete>()
								.Where(x => x.SID == sid);

				if(cTests != default)
				{
					foreach( var ct in cTests ) {
						var tmp = dbs.CreateCriteria<Tables.Tests>().List<Tables.Tests>().Where( x => x.ID == ct.TID ).FirstOrDefault();

						if( tmp != default ) {
							tmp.Access = ct.Access;
							res.Add(tmp);
						}
					}

				}
			}

			return res;
		}

		public void DeleteStudent(int sid) {
			/*
			 * удаляем юзера
			 * удаляем информацию о нем
			 * удаляем результаты тестов
			 * удаляем записи его ответов
			 */

			using ( var dbs = db.OpenSession() ) {
				var user = dbs.Get<Tables.Students>(sid);
				var usrinfo = dbs.Get<Tables.StudentInfo>(sid);

				var ctest = dbs.CreateCriteria<Tables.TestComplete>()
								.List<Tables.TestComplete>()
								.Where(x => x.SID == sid);
				var answers = dbs.CreateCriteria<Tables.AnswersStudent>()
								.List<Tables.AnswersStudent>()
								.Where( x => x.SID == sid );

				using (var tr = dbs.BeginTransaction()) {
					
					dbs.Delete(user);
					dbs.Delete(usrinfo);

					ctest  .ForEach( x => dbs.Delete(x) );
					answers.ForEach( x => dbs.Delete(x) );

					tr.Commit();
				}
			}
		}

		public void AddOrUpdateStudent(Student st) {
			using ( var dbs = db.OpenSession() ) {
				using (var tr = dbs.BeginTransaction()) {
					var Stud = st.StudentsDB;

					dbs.SaveOrUpdate(Stud);
 
					var stInfo = st.StudentInfoDB;
					stInfo.SID = Stud.ID;
					 
					dbs.SaveOrUpdate(stInfo);

					tr.Commit();
				}
			}
		}

		public void SetAccessCompleteTest(int sid, int tid, bool flag) {
			using ( var dbs = db.OpenSession() ) {
				var test = dbs.CreateCriteria<Tables.TestComplete>()
									.List<Tables.TestComplete>()
									.Where( x => x.SID == sid && x.TID == tid );

				using ( var tr = dbs.BeginTransaction() ) {
					test.ForEach(
							(x) =>
							{
								x.Access = (flag) ? 1 : 0;
								dbs.SaveOrUpdate(x);
							}
						);
					
					tr.Commit();
				}
			}
		}

		public void DeleteCompleteTest(int sid, int tid) {
			/*
			 * удаляем тест и связзанные с ним ответы
			 */

			using (var dbs = db.OpenSession()) {
				var answers = dbs.CreateCriteria<Tables.AnswersStudent>()
									       .List<Tables.AnswersStudent>()
									       .Where( 
												x => x.SID == sid && x.TID == tid
									       );

				var ctest = dbs.CreateCriteria<Tables.TestComplete>()
										 .List<Tables.TestComplete>()
										 .Where(x=> x.TID == tid && x.SID == sid);

				using ( var tr = dbs.BeginTransaction() ) {
					answers.ForEach(
							x => dbs.Delete(x)
						);
					ctest.ForEach(
							x => dbs.Delete(x)
						);

					tr.Commit();
				}
			}
		}

		public void DeleteRule(int id) {
			using (var dbs = db.OpenSession()) {
				using (var tr = dbs.BeginTransaction()) {
					dbs.Delete(
							dbs.Get<Tables.Rules>(id)
						);

					tr.Commit();
				}
			}
		}

		public void AddOrUpdateRules(Tables.Rules r) {
			using (var dbs = db.OpenSession()) {
				using (var tr = dbs.BeginTransaction()) {
					dbs.SaveOrUpdate(r);

					tr.Commit();
				}
			}
		}

		public void AddOrUpdateMedia(string path) {
			using (var dbs = db.OpenSession()) {
				using (var tr = dbs.BeginTransaction()) {
					Tables.MediaPath tmp = new Tables.MediaPath();
					tmp.Access = 1;
					tmp.Path   = path;

					dbs.Save(tmp);
					
					tr.Commit();
				}
			}
		}

		public void DeleteMedia(int id) {
			using (var dbs = db.OpenSession()) {
				using (var tr = dbs.BeginTransaction()) {
					dbs.Delete(
							dbs.Get<Tables.MediaPath>(id)
						);
					
					tr.Commit();
				}
			}
		}

		public new List<string> GetCompleteTest(int SID)
		{
			List<string> res = new List<string>();

			using (var dbs = db.OpenSession())
			{
				var compl = dbs.CreateCriteria<Tables.TestComplete>().List<Tables.TestComplete>().Where(x => x.SID == SID);
				var tests = dbs.CreateCriteria<Tables.Tests>().List<Tables.Tests>();

				foreach (var ct in compl) {
					res.AddRange(tests.Where(x => x.ID == ct.TID).Select(x => x.Name).ToList());
				}
			}

			return res;
		}


		public void DeleteTest(int tid) {
			using ( var dbs = db.OpenSession() ) {
				/*
				* удалям тест
				* удаляем вопросы к тесту
				* удаляем выполненные тесты связанные с этим 
				* удаляем ответы учеников связанные с этим тестом
				*/

				var test = dbs.Get<Tables.Tests>(tid);
				var questions = dbs.CreateCriteria<Tables.Questions>()
					                         .List<Tables.Questions>()
											 .Where( x => x.TID == tid );
				var answers  = dbs.CreateCriteria<Tables.AnswersStudent>()
									        .List<Tables.AnswersStudent>()
											.Where( x => x.TID == tid );
				var complete = dbs.CreateCriteria<Tables.TestComplete>()
											.List<Tables.TestComplete>()
											.Where( x => x.TID == tid);

				using (var tr = dbs.BeginTransaction()) {

					dbs.Delete( dbs.Get<Tables.Tests>(tid) );

					questions.ForEach( x => dbs.Delete(x) );
					answers  .ForEach( x => dbs.Delete(x) );
					complete .ForEach( x => dbs.Delete(x) );

					tr.Commit();
				}
			}
		}

		public void AddOrUpdateTest(Test test) {
			bool is_del = false;

			if ( test.TestsDB.ID != 0 ) {
				DeleteTest(test.TID);
				test.TID = 0;
				is_del = true;
			}

			using ( var dbs = db.OpenSession() ) {
				using ( var tr = dbs.BeginTransaction() ) {
					
					var testDB = test.TestsDB;
					var qstns = test.Questions;
					
					dbs.SaveOrUpdate(testDB);
					
					qstns.ForEach(
							x =>  {
								if (is_del) 
									x.QID = 0;

								var q = x.QuestionsDB;

								q.TID = testDB.ID;
								dbs.SaveOrUpdate(q);

								x.QID = q.ID;
								x.BadAnswewrsDB.ForEach( y => dbs.SaveOrUpdate(y) );
							}
						);


					tr.Commit();
				}
			}
		}

		public void SetAccessFlag<T>(T obj, bool flag) {
			using ( var dbs = db.OpenSession() ) {
				using (var tr = dbs.BeginTransaction() ) {
					int id = ((Tables.IMapped)obj).ID;

					var o = dbs.Get<T>(id);
					((Tables.IBlockData)o).Access = (flag) ? 1 : 0;

					dbs.SaveOrUpdate(o);

					tr.Commit();
				}
			}
		}

		//#region >>> Get data
		//public Test GetOneTest(int tid) {
		//	Test res = new Test();

		//	Tables.Tests test = null;

		//	using (var dbs = db.OpenSession()) {
		//		test = dbs.Get<Tables.Tests>(tid);

		//		if ( test != null ) {
		//			var q = dbs.CreateCriteria<Tables.Questions>()
		//							.List<Tables.Questions>()
		//							.Where( x => x.TID == test.ID ).ToList();

		//			var ba = dbs.CreateCriteria<Tables.BadAnswers>()
		//							.List<Tables.BadAnswers>()
		//							.Where( x => q.AsEnumerable().All( c => x.QID == c.ID )).ToList();

		//			res = new Test(test, q, ba);
		//		}
		//	}

		//	return res;
		//}
		//public Test GetOneTest(string name)
		//{
		//	Test res = new Test();
		//	Tables.Tests test = default;

		//	using (var dbs = db.OpenSession()) { 
		//		test = dbs.CreateCriteria<Tables.Tests>()
		//						.List<Tables.Tests>()
		//						.Where( x => x.Name == name).FirstOrDefault();
		//	}

		//	if (test != default) 
		//		res = GetOneTest(test.ID);

		//	return res;
		//}

		//public List<Test> GetAllTests() {
		//	List<Test> res = new List<Test>();

		//	using (var dbs = db.OpenSession())
		//	{
		//		var tests = dbs.CreateCriteria<Tables.Tests>     ().List<Tables.Tests>();
		//		var quest = dbs.CreateCriteria<Tables.Questions> ().List<Tables.Questions>();
		//		var bansw = dbs.CreateCriteria<Tables.BadAnswers>().List<Tables.BadAnswers>();

		//		foreach (var test in tests) {
		//			res.Add( new Test( 
		//					test, 
		//					quest.Where( x => x.TID == test.ID).ToList(),
		//					bansw.ToList()
		//			));
		//		}
		//	}

		//	return res;
		//}

		//public List<Student> GetAllStudent() {
		//	List<Student> res = new List<Student>();

		//	using ( var dbs = db.OpenSession() ) {
		//		var student = dbs.CreateCriteria<Tables.Students>()
		//							.List<Tables.Students>();
		//		var stuinfo = dbs.CreateCriteria<Tables.StudentInfo>()
		//							.List<Tables.StudentInfo>();

		//		foreach (var s in student) {
		//			res.Add( new Student( s, stuinfo.Where( x => x.SID == s.ID).First()) );
		//		}
		//	}

		//	return res;
		//}

		//public Student GetInformationStudent(int sid) {
		//	Student res = new Student();

		//	using ( var dbs = db.OpenSession() ) {
		//		var studt = dbs.Get<Tables.Students>(sid);
		//		var sinfo = dbs.CreateCriteria<Tables.StudentInfo>()
		//						.List<Tables.StudentInfo>()
		//						.Where( x => x.SID == studt.ID).First();

		//		res.Update(studt, sinfo);
		//	}

		//	return res;
		//}

		//public CompleteTest GetCompleteTest(int sid, int tid) {
		//	CompleteTest res = new CompleteTest();

		//	res         = (CompleteTest)GetOneTest(tid);
		//	res.Student = GetInformationStudent(sid);

		//	using (var dbs = db.OpenSession()) {
		//		var ans = dbs.CreateCriteria<Tables.AnswersStudent>()
		//						.List<Tables.AnswersStudent>()
		//						.Where( x => x.TID == tid && x.SID == sid ).ToList();

		//		res.AnswersStudentDB = ans;
		//	}

		//	return res;
		//}

		//public CompleteTest GetCompleteTest(int sid, string name) {
		//	CompleteTest res = new CompleteTest();

		//	Tables.Tests test = null;

		//	using (var dbs = db.OpenSession())
		//	{
		//		test = dbs.CreateCriteria<Tables.Tests>()
		//						.List<Tables.Tests>()
		//						.Where(x => x.Name == name).FirstOrDefault();
		//	}

		//	if (test != null)
		//		res = GetCompleteTest(sid, test.ID);

		//	return res;
		//}

		//public List<CompleteTest> GetAllCompleteTest(int sid) {
		//	List<CompleteTest> res = new List<CompleteTest>();
		//	List<Tables.TestComplete> ctest = null;

		//	using ( var dbs = db.OpenSession() ) {
		//		ctest = dbs.CreateCriteria<Tables.TestComplete>()
		//							.List<Tables.TestComplete>()
		//							.Where( x => x.SID == sid ).ToList();
		//	}

		//	ctest.ForEach(
		//		(x) => {
		//			res.Add( GetCompleteTest(sid, x.TID) );
		//		}
		//	);

		//	return res;
		//}
		//#endregion

		//#region >>> Modify Data Base

		//public void AddOrUpdateTest(Test test) {
		//	using (var dbs = db.OpenSession()) {
		//		using ( var tr = dbs.BeginTransaction() ) {
		//			dbs.SaveOrUpdate(test.TestsDB);

		//			test.QuestionsDB.ForEach(
		//				 (x) => {
		//					dbs.SaveOrUpdate(x);
		//				 }
		//			);

		//			test.Questions.ForEach(
		//				(x) => {
		//					x.BadAnswewrsDB.ForEach(
		//						(y) => dbs.SaveOrUpdate(y)
		//					);
		//				}
		//			);

		//			tr.Commit();
		//		}
		//	}
		//}
		//public void AddOrUpdateRules(Tables.Rules r) {
		//	using (var dbs = db.OpenSession()) {
		//		using (var tr = dbs.BeginTransaction()){
		//			dbs.SaveOrUpdate(r);
		//			tr.Commit();
		//		}
		//	}
		//}
		//public void AddOrUpdateStudent(Student st) {
		//	using (var dbs = db.OpenSession()) {
		//		using (var tr = dbs.BeginTransaction()) {
		//			dbs.SaveOrUpdate(st.StudentsDB);
		//			dbs.SaveOrUpdate(st.StudentInfoDB);

		//			tr.Commit();
		//		}
		//	}
		//}

		//public void RemoveTest(int tid) {
		//	/*
		//	 * удалить тест
		//	 * удалить вопросы от теста
		//	 *		удалить неверные ответы
		//	 *	удалить ответы юзера
		//	 *	удалить выполненные тесты с tid
		//	 */

		//}

		//public void RemoveTest(string Name) {
		//	/*
		//	 * получить tid
		//	 * отправить удалять
		//	 */
		//}

		//public void RemoveCompleteTest(int sid, int tid) {

		//}
		//public void RemoveCompleteTest(int sid, string name) {

		//}

		//public void RemoveStudent(int sid) {

		//}

		//public void SetAccessFlag<T>(T obj, bool flag) {
		//	using (var dbs = db.OpenSession()) {
		//		var o = dbs.Get<T>( ((Tables.IMapped)obj).ID );

		//		using ( var tr = dbs.BeginTransaction() ) {
		//			((Tables.IBlockData)o).Access = Convert.ToInt32(flag);
		//			dbs.Update(o);

		//			tr.Commit();
		//		}
		//	}
		//}
		//#endregion


		//#region >>> Core func
		//ITransaction _remove<T>(ISession s, ITransaction tr, int ID) {
		//	s.Delete( s.Get<T>(ID) );

		//	return tr;
		//}




		//#endregion
	}
}
