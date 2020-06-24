namespace Base.Data
{
	using Tables;
	using System.Collections.Generic; 

	public class AnswersUser : Tables.AnswersStudent { 
		public string Question     { get; set; }
		public string GoodAnswer   { get; set; }
	}

	public class TestQuestion : Tables.Questions {
		public List<BadAnswers> AnswersBad { get; set; }
		public string           UAnswer    { get; set; }
	}
}

namespace Base.Data.Tables
{ 
	public interface IBlockData {
		int Access { get; set; }
	}
	public interface IMapped {
		int ID { get; set; }
	}
	public interface INamed
	{
		string Name {  get; set; }
	}

	public interface IBlockData_ID : IBlockData, IMapped {}
	public interface IBlockData_Name : IBlockData, INamed {}
}

namespace Base.Data.Tables
{
	using NHibernate.Id.Insert;
	using NHibernate.Mapping;
	using NHibernate.Mapping.ByCode;
	using NHibernate.Mapping.ByCode.Conformist;
	using System.Collections.Generic;
	
	public class Students : IMapped
	{ 
		public virtual int    ID       { get; set; }
		public virtual string Login    { get; set; }
		public virtual string Password { get; set; }

		public override string ToString() { return Login; }
	}

	public class StudentsMap : ClassMapping<Students> {
		public StudentsMap() { 
			Id ( x => x.ID, map => map.Generator(Generators.Native));
			Property( x => x.Login    );
			Property( x => x.Password );
		}
	}
	 
	public class StudentInfo { 
		public virtual int    SID        { get; set; } 
		public virtual string Name       { get; set; } 
		public virtual string Surname    { get; set; } 
		public virtual string Patronymic { get; set; }
	}
	
	public class StudentInfoMap : ClassMapping<StudentInfo> {
		public StudentInfoMap() {
			Id(x => x.SID);
			Property(x => x.Name);
			Property(x => x.Surname);
			Property(x => x.Patronymic);
		}
	}
	 
	public class Tests : IBlockData_Name, IBlockData_ID
	{ 
		public virtual int    ID     { get; set; } 
		public virtual int    Time   { get; set; }
		public virtual int    Access { get; set; } 
		public virtual string Name   { get; set; }

		public override string ToString() { return Name; }
	}

	public class TestsMap : ClassMapping<Tests> {
		public TestsMap() {
			Id(x => x.ID, map => map.Generator(Generators.Native));
			Property(x => x.Name);
			Property(x => x.Time);
			Property(x => x.Access);
		}
	}
	 
	public class Rules : IBlockData_Name, IBlockData_ID
	{ 
		public virtual int    ID          { get; set; } 
		public virtual int    Access      { get; set; } 
		public virtual string Name        { get; set; } 
		public virtual string Description { get; set; }

		public override string ToString() { return Name; }
	}

	public class RulesMap : ClassMapping<Rules> {
		public RulesMap() {
			Id      (x => x.ID, map => map.Generator(Generators.Native));
			Property(x => x.Name);
			Property(x => x.Access);
			Property(x => x.Description);
		}
	}

	public class MediaPath : IBlockData, IMapped
	{
		public virtual int    ID     { get; set; }
		public virtual int    Access { get; set; }
		public virtual string Path   { get; set; }

		public override string ToString() { return Path; }
	}

	public class MediaPathMap : ClassMapping<MediaPath>
	{
		public MediaPathMap() {
			Id      (x => x.ID, map => map.Generator(Generators.Native));
			Property(x => x.Access);
			Property(x => x.Path);
		}
	}
	 
	public class Questions : IMapped { 
		public virtual int    ID       { get; set; } 
		public virtual int    TID      { get; set; }  
		public virtual string Question { get; set; } 
		public virtual string Answer   { get; set; }

		public override string ToString() { return Question; }
	}

	public class QuestionsMap : ClassMapping<Questions> {
		public QuestionsMap() {
			Id      (x => x.ID, map => map.Generator(Generators.Native));
			Property(x => x.TID);
			Property(x => x.Question);
			Property(x => x.Answer);
		}
	}
	 
	public class BadAnswers : IMapped { 
		public virtual int    ID	 { get; set; }
		public virtual int    QID    { get; set; }  
		public virtual string Answer { get; set; }

		public override string ToString() { return Answer; }
	}

	public class BadAnswersMap : ClassMapping<BadAnswers> {
		public BadAnswersMap() {
			Id(x => x.ID, map => map.Generator(Generators.Native));
			Property(x => x.QID);
			Property(x => x.Answer);
		}
	}
	 
	public class TestComplete : IBlockData, IMapped
	{ 
		public virtual int ID     { get; set; }
		public virtual int Access { get; set; } 
		public virtual int SID    { get; set; }  
		public virtual int TID    { get; set; } 
	}

	public class TestCompleteMap : ClassMapping<TestComplete> {
		public TestCompleteMap() {
			Id( x => x.ID, map => map.Generator(Generators.Native) );
			Property(x => x.SID);
			Property(x => x.TID);
			Property(x => x.Access);
		}
	}
	 
	public class AnswersStudent : IMapped { 
		public virtual int    ID     { get; set; }
		public virtual int    TID    { get; set; }
		public virtual int    SID    { get; set; } 
		public virtual int    QID    { get; set; } 
		public virtual string Answer { get; set; } 
	}

	public class AnswersStudentMap : ClassMapping<AnswersStudent> {
		public AnswersStudentMap() {
			Id(x => x.ID, map => map.Generator(Generators.Native));
			Property(x => x.TID);
			Property(x => x.SID);
			Property(x => x.QID);
			Property(x => x.Answer);
		}
	}
}
