namespace Student
{
	using System;
	using System.IO;
	using System.Windows.Forms;
	using System.ComponentModel;
	using System.Collections.Generic;

	using Base.Data;
	using Base.Data.Tables;

	public partial class MainWindow : Form
	{
		#region >>> Fields and Props
		public int       UID { get; set; } = -1;     // user identificator
		public IDataBase DB  { get; set; }           // объект работы с данными
		#endregion

		#region >>> Constructors
		public MainWindow()
		{
			InitializeComponent();
			
			tab_MainLayout.Selected += LoadAllowTest;
			tab_MainLayout.Selected += LoadEducationMaterials;
			tab_MainLayout.Selected += LoadStatistics;
			tab_Education .Selected += LoadRules;
			tab_Education .Selected += LoadMediaMaterials;

			list_AllowTest .SelectedIndexChanged += ShowInformationAboutTest; 
			list_Rules     .SelectedIndexChanged += ShowDescriptionRule;
			list_Media     .SelectedIndexChanged += LoadMediaFile;
			list_TestResult.SelectedIndexChanged += ShowResultTestExec;

			btn_StartTest.Click += TestRun;

			this.Shown          += SetForm;
			this.VisibleChanged += SetForm;
			this.VisibleChanged += LoadData;
		}
		#endregion


		#region >>> Methods
		void LoadData(object o, EventArgs e) {
			if (this.Visible && UID != -1) { 

				var curTab = tab_MainLayout.SelectedTab;

				if ( curTab == tab_AllowTests ) LoadAllowTest          (null, new TabControlEventArgs(curTab, 0, TabControlAction.Selected)); else
				if ( curTab == tab_Materials  ) LoadEducationMaterials (null, new TabControlEventArgs(curTab, 0, TabControlAction.Selected)); else
				if ( curTab == tab_Progress   ) LoadStatistics         (null, new TabControlEventArgs(curTab, 0, TabControlAction.Selected));
			} 
			else Reset(); 
		}

		public void Reset() {
			UID = -1;
			list_AllowTest .Items.Clear();
			list_Media     .Items.Clear();
			list_Rules     .Items.Clear();
			list_TestResult.Items.Clear();
			
			tb_DescriptionTest .Text = "";
			tb_RulesDescription.Text = "";
			tb_ShowResult      .Text = "";
		}
		#endregion

		#region >>> Event Handler
		void SetForm(object sender, EventArgs e) {
			var ui = DB.GetUserInfo(UID);

			this.Text = string.Format("Сессия ученика: {0} {1} {2}", ui.Surname, ui.Name, ui.Patronymic);
			LoadAllowTest(null, new TabControlEventArgs(tab_AllowTests, 0, TabControlAction.Selected));
		}

		void LoadAllowTest(object sender, TabControlEventArgs e) { 
			if (e.TabPage == tab_AllowTests) {
				list_AllowTest.Items.Clear();
				tb_DescriptionTest.Text = "";

				foreach(string tName in DB.GetAllowTest(UID)) {
					list_AllowTest.Items.Add(tName);
				}

				if (list_AllowTest.Items.Count > 0) {
					list_AllowTest.SelectedIndex = 0;
					btn_StartTest.Enabled        = true;
				} else {
					list_AllowTest.SelectedIndex = -1;
					btn_StartTest.Enabled        = false;
				}
			}
		}

		void LoadEducationMaterials(object sender, TabControlEventArgs e) {
			if ( e.TabPage == tab_Materials ) {
				LoadRules(null, new TabControlEventArgs(tab_Rules, 0, TabControlAction.Selected));
			}
		}

		void LoadStatistics(object sender, TabControlEventArgs e) {
			if (e.TabPage == tab_Progress)
			{
				list_TestResult.Items.Clear();
				tb_ShowResult.Text = "";

				foreach (string s in DB.GetCompleteTest(UID))
				{
					list_TestResult.Items.Add(s);
				}

				list_TestResult.SelectedIndex = (list_TestResult.Items.Count > 0) ? 0 : -1;
			}
		}

		void LoadRules(object sender, TabControlEventArgs e) {
			list_Rules.Items.Clear();
			tb_RulesDescription.Text = "";

			var l = DB.GetRules(UID).ToArray();

			list_Rules.Items.AddRange(l);
			list_Rules.SelectedIndex = (list_Rules.Items.Count > 0) ? 0 : -1;
		}

		void LoadMediaMaterials(object sender, TabControlEventArgs e) {
			list_Media.Items.Clear();
			list_Media.Items.AddRange(DB.GetMediaPath(UID).ToArray() );
		}

		void ShowInformationAboutTest(object sender, EventArgs e) {
			tb_DescriptionTest.Text = "";

			var testInfo = DB.GetTestInfo(list_AllowTest.SelectedItem.ToString());
			tb_DescriptionTest.Text = 
				string.Format("Информация о тесте:\r\nНаименование: {0}\r\nКол-во вопросов: {1}\r\nВремя выполнения: {2} мин"
				                , testInfo.Name
								, testInfo.CountQuestion
								, testInfo.LenghtMinutes
							 );
		}

		void ShowDescriptionRule(object sender, EventArgs e) {
			tb_RulesDescription.Text = ((Rules)list_Rules.SelectedItem).Description;
		}

		void LoadMediaFile(object sender, EventArgs e) {
			string fileName = list_Media.SelectedItem.ToString();
			
			try {
				var process       = new System.Diagnostics.Process();
				process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = Path.GetFullPath(fileName) };

				process.Start();
				process.WaitForExit();
			}
			catch ( Win32Exception ex ) {
				MessageBox.Show(ex.Message, "Ошибка открытия файла", MessageBoxButtons.OK);
			}
		}

		void ShowResultTestExec(object sender, EventArgs e) {
			tb_ShowResult.Text = "";

			DB.GetTestResult(UID, list_TestResult.SelectedItem.ToString()).ForEach(
					(AnswersUser ua) => { 
						tb_ShowResult.Text += string.Format("Вопрос: {0}\r\nПравильный ответ: {1}\r\nВаш ответ: {2}\r\n\r\n", ua.Question, ua.GoodAnswer, ua.Answer);
					}
				);
		}

		void TestRun(object sender, EventArgs e) {
			List<TestQuestion> req = DB.GetQuestions(list_AllowTest.SelectedItem.ToString());
			List<AnswersUser>  lau = new List<AnswersUser>();

			Test test = new Test(req, DB.GetTestInfo(list_AllowTest.SelectedItem.ToString()).LenghtMinutes);

			test.EndTest += (testQ) => { 		
				testQ.ForEach( (quest) => { 
									lau.Add(new AnswersUser() { 
												SID        = UID, 
												QID        = quest.ID, 
												TID        = quest.TID,    
												GoodAnswer = quest.Answer, 
												Answer     = quest.UAnswer, 
												Question   = quest.Question
									});});};

			test.ShowDialog();
			DB.WriteTestResult( lau );

			LoadAllowTest(null, new TabControlEventArgs(tab_AllowTests, 0, TabControlAction.Selected));
		}
		#endregion
	}

}
