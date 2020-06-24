namespace Base.Data
{	 
	using System.Collections.Generic; 
	using Tables;
	/// <summary>
	/// Информация о тесте
	/// </summary>
	public class TestInfo {
		public string Name          ; // Имя теста				
		public int    CountQuestion ; // кол-во вопросов
		public int    LenghtMinutes ; // длительность теста в минутах
	}
	 
	public interface IDataBase {
		string PathDB { get; set; }

		#region >>> Получение данных
		/// <summary>
		/// Получение ID юзера по логину и паролю
		/// </summary>
		/// <param name="login">логин</param>
		/// <param name="pass">пароль</param>
		/// <returns>ID юзера с такими логином и паролем или -1 если не найден такой</returns>
		int GetUID(string login, string pass);

		/// <summary>
		/// Получить названия тестов, доступных юзеру с UID
		/// </summary>
		/// <param name="UID">ид юзера</param>
		/// <returns>имена тестов</returns>
		List<string> GetAllowTest(int UID);

		/// <summary>
		/// Получить информацию по юзеру
		/// </summary>
		/// <param name="UID">ид юзера</param>
		/// <returns>Информация о юзере: имя, фамилия, отчество</returns>
		StudentInfo GetUserInfo(int UID);

		/// <summary>
		/// Получение вопросов теста с правильными вариантами
		/// </summary>
		/// <param name="testName">Имя теста</param>
		/// <returns>Список вопросов</returns>
		List<TestQuestion> GetQuestions(string testName);

		///// <summary>
		///// Получить несколько вариантов ответов неправильных
		///// </summary>
		///// <param name="testName">Имя теста</param>
		///// <param name="count">Кол-во неправильных ответов</param>
		///// <returns>Список неправильных ответов</returns>
		//List<string> GetAnswers(string testName, int count = 3);

		/// <summary>
		/// Получить информацию о тесте
		/// </summary>
		/// <param name="testName">имя теста</param>
		/// <returns>Информация о тесте: имя, кол-во вопросов, продолжительность</returns>
		TestInfo GetTestInfo(string testName);

		/// <summary>
		/// Получить список правил доступных юзеру
		/// </summary>
		/// <param name="UID">UID юзера</param>
		/// <returns>Список правил</returns>
		List<Rules> GetRules(int UID);

		/// <summary>
		/// Получить доступные пути к медийным материалам (диктанты)
		/// </summary>
		/// <param name="UID">UID юзера</param>
		/// <returns>Список путей (желательно относительных)</returns>
		List<string> GetMediaPath(int UID);

		/// <summary>
		/// Получить названия всех, пройденных юзером, тестов
		/// </summary>
		/// <param name="UID">UID юзера</param>
		/// <returns>список названий тестов</returns>
		List<string> GetCompleteTest(int UID);

		/// <summary>
		/// Получить результат по выполненному тесту
		/// </summary>
		/// <param name="UID">UID юзера</param>
		/// <param name="testName">имя теста</param>
		/// <returns>Результаты теста</returns>
		List<AnswersUser> GetTestResult(int UID, string testName);
		#endregion

		#region >>> Запись данных
		/// <summary>
		/// Соханение результатов выполнения теста для юзера
		/// </summary> 
		/// <param name="tRes">результаты</param>
		void WriteTestResult(List<AnswersUser> tRes);
		#endregion
	}
}