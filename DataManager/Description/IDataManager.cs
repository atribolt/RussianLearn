using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Data
{
	public interface IDataManager : IDataBase {
		Test                    GetOneTest      (int tid);          // *
		Student                 GetStudent      (int sid);		    // *
		//Tables.TestComplete     GetCompleteTest (int sid, int tid); // 

		List<Tables.Tests>      GetAllTest      (); 		  // *
		List<Tables.Rules>      GetAllRules     ();           // *
		List<Tables.Students>   GetAllStudents  ();           // *
		List<Tables.MediaPath>  GetAllMediaPath ();           // *
		List<Tables.Questions>  GetQuestions    (int tid);	  // *
		List<Tables.BadAnswers> GetBadAnswers   (int qid); 	  // *
		List<Tables.Tests>      GetCompleteTests(int sid); 	  // *
		 
		void DeleteMedia       (int id );             // *
		void DeleteTest        (int tid);			  // *
		void DeleteRule        (int id );			  // *
		void DeleteStudent     (int sid);			  // *
		void DeleteCompleteTest(int sid, int tid);	  // *

		void AddOrUpdateStudent (Student st);					  // *
		void AddOrUpdateTest    (Test test);					  // *
		void AddOrUpdateRules   (Tables.Rules r);                 // *
		void AddOrUpdateMedia(string path);						  // *
		void SetAccessFlag<T>(T obj, bool flag);                  // *
		//void SetAccessFlag<T>(T obj, string name, bool flag);	  //
		void SetAccessCompleteTest(int sid, int tid, bool flag);  // *
	}
}

namespace Base.Data
{
	using System.Collections.Generic;


	public class Question { 
		public virtual int           QID        { get; set; } = default; 
		public virtual string        Text       { get; set; } = default; // текст вопроса
		public virtual string        Answer     { get; set; } = default; // ответ
		public virtual string        UserAnswer { get; set; } = default;
		public virtual List<string>  BadAnswers { get; set; } = default; 

		public Question() { }

		public Question (Tables.Questions q, List<Tables.BadAnswers> b) {
			Update(q, b);
		}

		public Question Update(Tables.Questions q, List<Tables.BadAnswers> b) {
			QID        = q.ID;
			Text       = q.Question;
			Answer     = q.Answer;
			BadAnswers = b.Select( x => x.Answer ).ToList();

			return this;
		}

		public List<Tables.BadAnswers> BadAnswewrsDB {
			get { return BadAnswers.Select( x => new Tables.BadAnswers() { Answer = x, QID = QID } ).ToList(); }
		}
		public Tables.Questions QuestionsDB {
			get {  return new Tables.Questions() { ID = 0, Answer = Answer, Question = Text, TID = 0 }; }
		}
	}
	
	public class Test {
		public int            TID       { get; set; } = default;
		public int			  Time      { get; set; } = default;
		public int            Access    { get; set; } = default;
		public string         Name      { get; set; } = default;
		public List<Question> Questions { get; set; } = default;

		public Test() { }

		public Test(Tables.Tests t, List<Tables.Questions> q, List<Tables.BadAnswers> b) {
			Update(t, q, b);
		}

		public Test Update(Tables.Tests t, List<Tables.Questions> q, List<Tables.BadAnswers> b) {
			TID = t.ID;
			Time = t.Time;
			Access = t.Access;
			Name = t.Name;

			Questions = q.Select( x => new Question(x, b.Where( z => z.QID == x.ID).ToList()) ).ToList();

			return this;
		}

		public List<Tables.Questions> QuestionsDB {
			get { return Questions.Select( x => new Tables.Questions(){ ID = x.QID, TID = TID, Answer = x.Answer, Question = x.Text } ).ToList(); }
		}

		public Tables.Tests TestsDB {
			get { return new Tables.Tests() { ID = TID, Access = Access, Name = Name, Time = Time }; }
		}
	}

	public class Student {
		public int    SID        { get; set; } = default;
		public string Name       { get; set; } = default;
		public string Login      { get; set; } = default;
		public string Surname    { get; set; } = default;
		public string Password   { get; set; } = default;
		public string Patronymic { get; set; } = default;

		public Student () {}

		public Student (Tables.Students s, Tables.StudentInfo si) { 
			Update(s, si);
		}

		public Student Update(Tables.Students s, Tables.StudentInfo si) {
			SID        = s.ID;
			Name       = si.Name;
			Login      = s.Login;
			Surname    = si.Surname;
			Password   = s.Password;
			Patronymic = si.Patronymic;

			return this;
		}

		public Tables.StudentInfo StudentInfoDB {
			get { return new Tables.StudentInfo() { SID = SID, Name = Name, Surname = Surname, Patronymic = Patronymic }; }
		}

		public Tables.Students StudentsDB {
			get { return new Tables.Students() { ID = SID, Login = Login, Password = Password }; }
		}
	}

	public class CompleteTest : Test {  
		public Student Student      { get; set; } = default;

		public CompleteTest() {}
		

		public List<Tables.AnswersStudent> AnswersStudentDB {
			get { return Questions.Select( x => new Tables.AnswersStudent() { TID = TID, QID = x.QID, SID = Student.SID, Answer = x.UserAnswer } ).ToList(); }
			set {
				Questions.ForEach( 
					(x) => {
						x.UserAnswer = value.Where( y => y.QID == x.QID).FirstOrDefault().Answer;
					}
				);
			}
		}
	}
}
