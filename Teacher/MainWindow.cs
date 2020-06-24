using Base.Data;
using Base.Data.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher
{
	public partial class MainWindow : Form
	{
		public string PathSettingsFile { get; set; } = "settings.dat";

		public IDataManager DB { get; set; }

		public MainWindow(IDataManager db) 
			: this() {
			DB = db;
		}

		WebView diary;
		public MainWindow() {
			InitializeComponent();

			InitMaserTabEvents();
			InitTestTabEvents();
			InitStudentTabEvent();
			InitRulesTabEvents();
			InitMediaTabEvents();

			menu_OpenDiary.Click += (o, e) => { 
				diary = new WebView();
				diary.Show();
			};

			menu_ChangePathDB.Click += (o, e) => {
				OpenFileDialog op = new OpenFileDialog();

				if ( op.ShowDialog() == DialogResult.OK ) {
					File.WriteAllLines(PathSettingsFile, new string[]{ op.FileName });
					DB.PathDB = op.FileName;
				}
			};

			Shown += (o, e) => { ReloadTestTab(); };
		}
 
		#region >>> Set master tab

		void InitMaserTabEvents() {
			tab_Master.Selecting += (o, te) => {
				// очищаем список
				// получаем список тестов и заполняем list_Tests
				if ( te.TabPage.Name == tab_Tests.Name ) {
				//if (tab_Master.SelectedTab == tab_Tests) { 
					ReloadTestTab();
				}
			};

			tab_Master.Selecting += (o, te) => {
				// ученики
				if ( te.TabPage.Name == tab_Students.Name ) {
					ReloadStudentsTab();
				}
			};

			tab_Master.Selecting += (o, te) => {
				// вкладка с правилами
				if ( te.TabPage.Name == tab_Rules.Name ) {
					ReloadRulesTab();
				}
			};
			
			tab_Master.Selected += (o, te) => {
				// вкладка с медиа ресурсами
				if ( te.TabPage == tab_Media ) {
					ReloadMediaTab();
				}
			};
		}

		void ClearTestTab() {
			list_Tests    .Items.Clear();
			list_Questions.Items.Clear();
			tb_InformationTest    .Text = "";
			tb_InformationQuestion.Text = "";
		}
		void LoadTestTab() {
			var tests = DB.GetAllTest(); // получаем тесты

			tests.ForEach(
					x => list_Tests.Items.Add(x)
				);
		}
		void ReloadTestTab()
		{
			ClearTestTab();
			LoadTestTab();
		}

		void ClearStudentsTab() {
			list_Students    .Items.Clear();
			list_CompleteTest.Items.Clear();

			tb_TestResult .Text = "";
			tb_StudentInfo.Text = "";
		}
		void LoadStudentTab()
		{
			var stds = DB.GetAllStudents();

			stds.ForEach(
					x => list_Students.Items.Add(x)
				);
		}
		void ReloadStudentsTab()
		{
			ClearStudentsTab();
			LoadStudentTab();
		}

		void ClearRulesTab() {
			list_Rules.Items.Clear();
			tb_RuleDescription.Text = "";
		}
		void LoadRulesTab()
		{
			var rules = DB.GetAllRules();

			rules.ForEach(
					x => list_Rules.Items.Add(x)
				);
		}
		void ReloadRulesTab()
		{
			ClearRulesTab();
			LoadRulesTab();
		}

		void ClearMediaTab() {
			list_MediaPath.Items.Clear();
			tb_InformationMedia.Text = "";
		}
		void LoadMediaTab()
		{
			var media = DB.GetAllMediaPath();

			media.ForEach(
					x => list_MediaPath.Items.Add(x)
				);
		}
		void ReloadMediaTab()
		{
			ClearMediaTab();
			LoadMediaTab();
		}

		void InitTestTabEvents() {
			list_Tests.SelectedIndexChanged += (o, e) => { // обработка выбора теста
				if ( list_Tests.SelectedIndex != -1 ) {
					var test = (Tests)list_Tests.SelectedItem;

					chb_AccessTest.Checked = (test.Access != 0);

					list_Questions.Items.Clear();
					DB.GetQuestions(test.ID).ForEach(
							x => list_Questions.Items.Add(x)
						);
					 
					tb_InformationTest.Text =
									String.Format(
										"Название теста  : {0}\r\n" +
										"Кол-во вопросов : {1}\r\n" +
										"Длительность    : {2}\r\n",
											test.Name,
											list_Questions.Items.Count,
											test.Time
										);
				}
			};

			list_Questions.SelectedIndexChanged += (o, e) => { // обработка выбора вопроса
				if ( list_Questions.SelectedIndex != -1)
				{
					var question  = (Questions)list_Questions.SelectedItem;
					var badAnswer = DB.GetBadAnswers(question.ID);

					tb_InformationQuestion.Text = 
							String.Format(
									"Вопрос: {0}\r\n\t" +
									"Правильный ответ: {1}\r\n\r\n\t" +
									"Все варианты: \r\n\t{1}"
								, question.Question
								, question.Answer
							);

					badAnswer.ForEach(
							x => tb_InformationQuestion.Text += "\r\n\t" + x.Answer
						);
				}
			};

			chb_AccessTest.Click += (o, e) => {
				if ( list_Tests.SelectedIndex != -1 ) {
					DB.SetAccessFlag( (Tests)list_Tests.SelectedItem, chb_AccessTest.Checked );
				}
			};

			btn_DeleteTest.Click += (o, e) => {
				if ( list_Tests.SelectedIndex != -1 ) {
					int tid = ((Tests)list_Tests.SelectedItem).ID;

					list_Tests.Items.Remove(list_Tests.SelectedItem);
					DB.DeleteTest(tid);

					{ // очиска полей
						list_Questions.Items.Clear();
						tb_InformationTest    .Text = "";
						tb_InformationQuestion.Text = "";
					}
				}
			};

			btn_AddTest.Click += (o, e) => {
				ModifyTest mt = new ModifyTest();

				mt.Done += () => { 
					DB.AddOrUpdateTest(mt.Test); 
					mt.Close();
				};

				mt.ShowDialog();
				//tab_Master.SelectTab(tab_Tests);
				ReloadTestTab();
			};

			btn_ModifyTest.Click += (o, r) => {
				if ( list_Tests.SelectedIndex != -1 )
				{
					ModifyTest mt = new ModifyTest();
					int tid = ((Tests)list_Tests.SelectedItem).ID;

					mt.Test = DB.GetOneTest(tid);
					
					mt.Done += () => {
						DB.AddOrUpdateTest(mt.Test);
						mt.Close();
					};

					mt.ShowDialog(); 
					ReloadTestTab();
				}
			};
		}

		void InitStudentTabEvent() {
			list_Students.SelectedIndexChanged += (o, e) => {
				if ( list_Students.SelectedIndex != -1 ) {
					var user = (Students)list_Students.SelectedItem;

					var ctests = DB.GetCompleteTests(user.ID);
					var usinfo = DB.GetUserInfo(user.ID);

					tb_StudentInfo.Text = 
								String.Format(
										"Логин    : {0}\r\n" +
										"Пароль   : {1}\r\n\r\n" +
										"Имя      : {2}\r\n" +
										"Фамилия  : {3}\r\n" +
										"Отчество : {4}\r\n"
										, user.Login
										, user.Password
										, usinfo.Name
										, usinfo.Surname
										, usinfo.Patronymic
									);
					
					list_CompleteTest.Items.Clear();
					ctests.ForEach(
							x => list_CompleteTest.Items.Add(x)
						);

					tb_TestResult.Text = "";
				}
			};

			list_CompleteTest.SelectedIndexChanged += (o, e) => {
				if ( list_CompleteTest.SelectedIndex != -1 ) {
					var user  = (Students)list_Students .SelectedItem;
					var ctest = (Tests)list_CompleteTest.SelectedItem;

					chb_AccessCompleteTest.Checked = (ctest.Access != 0);

					var answers  = DB.GetTestResult(user.ID, ctest.Name);
					var question = DB.GetQuestions(ctest.ID);

					tb_TestResult.Text = "";
					
					question.ForEach(
							x => {
							tb_TestResult.Text += 
									String.Format(
										"Вопрос           : {0}\r\n" +
										"Правильный ответ : {1}\r\n" +
										"Ответ ученика    : {2}\r\n\r\n"
											, x.Question
											, x.Answer
											, answers.Where(y => y.QID == x.ID).FirstOrDefault().Answer
							); }
						);
				} 
				else {
					tb_TestResult.Text = "";
				}

			};

			btn_DeleteStudent.Click += (o, e) => {
				if ( list_Students.SelectedIndex != -1 ) {
					var student = ((Students)list_Students.SelectedItem);
					
					DB.DeleteStudent(student.ID);
					list_Students.Items.Remove(student);

					//tab_Master.SelectTab(tab_Students);
					ReloadStudentsTab();
				}
			};

			btn_AddStudent.Click += (o, e) => {
				ModifyStudent ms = new ModifyStudent();

				ms.Done += () => {
					DB.AddOrUpdateStudent(ms.Student);
					ms.Close();
				};

				ms.ShowDialog();
				//tab_Master.SelectTab(tab_Students);
				ReloadStudentsTab();
			};

			btn_ModifyStudent.Click += (o, e) => {
				if ( list_Students.SelectedIndex != -1 ) {
					var student = ((Students)list_Students.SelectedItem);

					ModifyStudent ms = new ModifyStudent();

					ms.Student = DB.GetStudent(student.ID);

					ms.Done += () => {
						DB.AddOrUpdateStudent(ms.Student);
						ms.Close();
					};

					ms.ShowDialog();
					//tab_Master.SelectTab(tab_Students);
					ReloadStudentsTab();
				}
			};

			chb_AccessCompleteTest.Click += (o, e) => {
				if ( list_CompleteTest.SelectedIndex != -1 ) {
					int sid = ((Students)list_Students.SelectedItem).ID;
					int tid = ((Tests)list_CompleteTest.SelectedItem).ID;

					DB.SetAccessCompleteTest(sid, tid, chb_AccessCompleteTest.Checked );

					//tab_Master.SelectTab(tab_Students);
					//ReloadStudentsTab();
				}
			};

			btn_DeleteCompleteTest.Click += (o, e) => {
				if ( list_CompleteTest.SelectedIndex != -1 ) {
					int sid = ((Students)list_Students.SelectedItem).ID;
					int tid = ((Tests)list_CompleteTest.SelectedItem).ID;

					DB.DeleteCompleteTest(sid, tid);

					//tab_Master.SelectTab(tab_Students);
					ReloadStudentsTab();
				}
			};
		}

		void InitRulesTabEvents() {
			list_Rules.SelectedIndexChanged += (o, e) => {
				if ( list_Rules.SelectedIndex != -1 ) {
					var rule = ((Rules)list_Rules.SelectedItem);

					tb_RuleDescription.Text = rule.Description;

					chb_AccessRule.Checked = ( rule.Access != 0 );
				}
			};

			chb_AccessRule.Click += (o, e) => {
				if ( list_Rules.SelectedIndex != -1 ) {
					var rule = ((Rules)list_Rules.SelectedItem);

					DB.SetAccessFlag(rule, chb_AccessRule.Checked );
				}
			};

			btn_DeleteRule.Click += (o, e) => {
				if ( list_Rules.SelectedIndex != -1 ) {
					var rule = ((Rules)list_Rules.SelectedItem);

					DB.DeleteRule(rule.ID);

					//tab_Master.SelectTab(tab_Rules);
					ReloadRulesTab();
				}
			};

			btn_AddRule.Click += (o, e) => {
				ModifyRule mr = new ModifyRule();

				mr.Done += () => {
					DB.AddOrUpdateRules(mr.Rule);
					mr.Close();
				};

				mr.ShowDialog();
				//tab_Master.SelectTab(tab_Rules);
				ReloadRulesTab();
			};

			btn_ModifyRule.Click += (o, e) => {
				if ( list_Rules.SelectedIndex != -1 ) {
					var rule = ((Rules)list_Rules.SelectedItem);

					ModifyRule mr = new ModifyRule();
					mr.Rule = rule;

					mr.Done += () => {
						DB.AddOrUpdateRules(mr.Rule);
						mr.Close();
					};

					mr.ShowDialog();
					//tab_Master.SelectTab(tab_Rules);
					ReloadRulesTab();
				}
			};
		}

		void InitMediaTabEvents()
		{
			list_MediaPath.SelectedIndexChanged += (o, e) => {
				if (list_MediaPath.SelectedIndex != -1)
				{
					var obj = ((MediaPath)list_MediaPath.SelectedItem);

					tb_InformationMedia.Text = Path.GetFullPath(obj.Path);

					chb_AccessMedia.Checked = (obj.Access != 0);
				}
			};

			chb_AccessMedia.Click += (o, e) => {
				if (list_MediaPath.SelectedIndex != -1)
				{
					var rule = ((MediaPath)list_MediaPath.SelectedItem);

					DB.SetAccessFlag(rule, chb_AccessMedia.Checked);
				}
			};

			btn_DeleteMedia.Click += (o, e) => {
				if (list_MediaPath.SelectedIndex != -1)
				{
					var rule = ((MediaPath)list_MediaPath.SelectedItem);

					DB.DeleteMedia(rule.ID);

					//tab_Master.SelectTab(tab_Media);
					ReloadMediaTab();
				}
			};

			btn_AddMedia.Click += (o, e) => {
				OpenFileDialog op = new OpenFileDialog();
				op.Filter = "All files (*.*)|*.*";
				if ( op.ShowDialog() == DialogResult.OK ) {
					DB.AddOrUpdateMedia(op.FileName);
					//tab_Master.SelectTab(tab_Media);
					ReloadMediaTab();
				}
			};

			btn_OpenMediaFile.Click += (o, e) => {
				if ( list_MediaPath.SelectedIndex != -1 ) {
					var med = ((MediaPath)list_MediaPath.SelectedItem);
					 
					try
					{
						var process = new System.Diagnostics.Process();
						process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = Path.GetFullPath(Path.GetFullPath(med.Path)) };

						process.Start();
						process.WaitForExit();
					}
					catch (Win32Exception ex)
					{
						MessageBox.Show(ex.Message, "Ошибка открытия файла", MessageBoxButtons.OK);
					} 
				}
			};
		}
		#endregion
	}
}
