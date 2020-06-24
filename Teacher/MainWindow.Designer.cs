namespace Teacher
{
	partial class MainWindow
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menu_Master = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_OpenDiary = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_ChangePathDB = new System.Windows.Forms.ToolStripMenuItem();
			this.tab_Master = new System.Windows.Forms.TabControl();
			this.tab_Tests = new System.Windows.Forms.TabPage();
			this.gb_InformationTest = new System.Windows.Forms.GroupBox();
			this.lbl_InformationQuestion = new System.Windows.Forms.Label();
			this.tb_InformationQuestion = new System.Windows.Forms.TextBox();
			this.lbl_QuestionInfo = new System.Windows.Forms.Label();
			this.lbl_Question = new System.Windows.Forms.Label();
			this.list_Questions = new System.Windows.Forms.ListBox();
			this.tb_InformationTest = new System.Windows.Forms.TextBox();
			this.gb_ControlTests = new System.Windows.Forms.GroupBox();
			this.list_Tests = new System.Windows.Forms.ListBox();
			this.chb_AccessTest = new System.Windows.Forms.CheckBox();
			this.btn_DeleteTest = new System.Windows.Forms.Button();
			this.btn_AddTest = new System.Windows.Forms.Button();
			this.btn_ModifyTest = new System.Windows.Forms.Button();
			this.tab_Students = new System.Windows.Forms.TabPage();
			this.gb_InformationStudent = new System.Windows.Forms.GroupBox();
			this.gb_TestResult = new System.Windows.Forms.GroupBox();
			this.tb_TestResult = new System.Windows.Forms.TextBox();
			this.gb_CompleteTests = new System.Windows.Forms.GroupBox();
			this.list_CompleteTest = new System.Windows.Forms.ListBox();
			this.chb_AccessCompleteTest = new System.Windows.Forms.CheckBox();
			this.btn_DeleteCompleteTest = new System.Windows.Forms.Button();
			this.gb_Students = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_StudentInfo = new System.Windows.Forms.TextBox();
			this.btn_ModifyStudent = new System.Windows.Forms.Button();
			this.btn_AddStudent = new System.Windows.Forms.Button();
			this.btn_DeleteStudent = new System.Windows.Forms.Button();
			this.list_Students = new System.Windows.Forms.ListBox();
			this.tab_Rules = new System.Windows.Forms.TabPage();
			this.chb_AccessRule = new System.Windows.Forms.CheckBox();
			this.tb_RuleDescription = new System.Windows.Forms.TextBox();
			this.btn_ModifyRule = new System.Windows.Forms.Button();
			this.btn_AddRule = new System.Windows.Forms.Button();
			this.btn_DeleteRule = new System.Windows.Forms.Button();
			this.list_Rules = new System.Windows.Forms.ListBox();
			this.tab_Media = new System.Windows.Forms.TabPage();
			this.chb_AccessMedia = new System.Windows.Forms.CheckBox();
			this.btn_AddMedia = new System.Windows.Forms.Button();
			this.btn_DeleteMedia = new System.Windows.Forms.Button();
			this.tb_InformationMedia = new System.Windows.Forms.TextBox();
			this.list_MediaPath = new System.Windows.Forms.ListBox();
			this.btn_OpenMediaFile = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.tab_Master.SuspendLayout();
			this.tab_Tests.SuspendLayout();
			this.gb_InformationTest.SuspendLayout();
			this.gb_ControlTests.SuspendLayout();
			this.tab_Students.SuspendLayout();
			this.gb_InformationStudent.SuspendLayout();
			this.gb_TestResult.SuspendLayout();
			this.gb_CompleteTests.SuspendLayout();
			this.gb_Students.SuspendLayout();
			this.tab_Rules.SuspendLayout();
			this.tab_Media.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Master,
            this.menu_Settings});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(767, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menu_Master
			// 
			this.menu_Master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_OpenDiary});
			this.menu_Master.Name = "menu_Master";
			this.menu_Master.Size = new System.Drawing.Size(64, 20);
			this.menu_Master.Text = "Главное";
			// 
			// menu_OpenDiary
			// 
			this.menu_OpenDiary.Name = "menu_OpenDiary";
			this.menu_OpenDiary.Size = new System.Drawing.Size(169, 22);
			this.menu_OpenDiary.Text = "Открыть дневник";
			// 
			// menu_Settings
			// 
			this.menu_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ChangePathDB});
			this.menu_Settings.Name = "menu_Settings";
			this.menu_Settings.Size = new System.Drawing.Size(79, 20);
			this.menu_Settings.Text = "Настройки";
			// 
			// menu_ChangePathDB
			// 
			this.menu_ChangePathDB.Name = "menu_ChangePathDB";
			this.menu_ChangePathDB.Size = new System.Drawing.Size(227, 22);
			this.menu_ChangePathDB.Text = "Выбрать путь к базе данных";
			// 
			// tab_Master
			// 
			this.tab_Master.Controls.Add(this.tab_Tests);
			this.tab_Master.Controls.Add(this.tab_Students);
			this.tab_Master.Controls.Add(this.tab_Rules);
			this.tab_Master.Controls.Add(this.tab_Media);
			this.tab_Master.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_Master.Location = new System.Drawing.Point(0, 24);
			this.tab_Master.Name = "tab_Master";
			this.tab_Master.SelectedIndex = 0;
			this.tab_Master.Size = new System.Drawing.Size(767, 532);
			this.tab_Master.TabIndex = 1;
			// 
			// tab_Tests
			// 
			this.tab_Tests.Controls.Add(this.gb_InformationTest);
			this.tab_Tests.Controls.Add(this.gb_ControlTests);
			this.tab_Tests.Location = new System.Drawing.Point(4, 22);
			this.tab_Tests.Name = "tab_Tests";
			this.tab_Tests.Padding = new System.Windows.Forms.Padding(3);
			this.tab_Tests.Size = new System.Drawing.Size(759, 506);
			this.tab_Tests.TabIndex = 0;
			this.tab_Tests.Text = "Тесты";
			this.tab_Tests.UseVisualStyleBackColor = true;
			// 
			// gb_InformationTest
			// 
			this.gb_InformationTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_InformationTest.Controls.Add(this.lbl_InformationQuestion);
			this.gb_InformationTest.Controls.Add(this.tb_InformationQuestion);
			this.gb_InformationTest.Controls.Add(this.lbl_QuestionInfo);
			this.gb_InformationTest.Controls.Add(this.lbl_Question);
			this.gb_InformationTest.Controls.Add(this.list_Questions);
			this.gb_InformationTest.Controls.Add(this.tb_InformationTest);
			this.gb_InformationTest.Location = new System.Drawing.Point(290, 3);
			this.gb_InformationTest.Name = "gb_InformationTest";
			this.gb_InformationTest.Size = new System.Drawing.Size(463, 497);
			this.gb_InformationTest.TabIndex = 2;
			this.gb_InformationTest.TabStop = false;
			this.gb_InformationTest.Text = "Информация";
			// 
			// lbl_InformationQuestion
			// 
			this.lbl_InformationQuestion.AutoSize = true;
			this.lbl_InformationQuestion.Location = new System.Drawing.Point(193, 233);
			this.lbl_InformationQuestion.Name = "lbl_InformationQuestion";
			this.lbl_InformationQuestion.Size = new System.Drawing.Size(102, 13);
			this.lbl_InformationQuestion.TabIndex = 5;
			this.lbl_InformationQuestion.Text = "Описание вопроса";
			// 
			// tb_InformationQuestion
			// 
			this.tb_InformationQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_InformationQuestion.BackColor = System.Drawing.SystemColors.Window;
			this.tb_InformationQuestion.Location = new System.Drawing.Point(193, 249);
			this.tb_InformationQuestion.Multiline = true;
			this.tb_InformationQuestion.Name = "tb_InformationQuestion";
			this.tb_InformationQuestion.ReadOnly = true;
			this.tb_InformationQuestion.Size = new System.Drawing.Size(267, 242);
			this.tb_InformationQuestion.TabIndex = 4;
			// 
			// lbl_QuestionInfo
			// 
			this.lbl_QuestionInfo.AutoSize = true;
			this.lbl_QuestionInfo.Location = new System.Drawing.Point(193, 15);
			this.lbl_QuestionInfo.Name = "lbl_QuestionInfo";
			this.lbl_QuestionInfo.Size = new System.Drawing.Size(88, 13);
			this.lbl_QuestionInfo.TabIndex = 3;
			this.lbl_QuestionInfo.Text = "Описание теста";
			// 
			// lbl_Question
			// 
			this.lbl_Question.AutoSize = true;
			this.lbl_Question.Location = new System.Drawing.Point(6, 17);
			this.lbl_Question.Name = "lbl_Question";
			this.lbl_Question.Size = new System.Drawing.Size(52, 13);
			this.lbl_Question.TabIndex = 2;
			this.lbl_Question.Text = "Вопросы";
			// 
			// list_Questions
			// 
			this.list_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.list_Questions.FormattingEnabled = true;
			this.list_Questions.Location = new System.Drawing.Point(7, 33);
			this.list_Questions.Name = "list_Questions";
			this.list_Questions.Size = new System.Drawing.Size(180, 446);
			this.list_Questions.TabIndex = 1;
			// 
			// tb_InformationTest
			// 
			this.tb_InformationTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_InformationTest.BackColor = System.Drawing.SystemColors.Window;
			this.tb_InformationTest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb_InformationTest.Location = new System.Drawing.Point(193, 33);
			this.tb_InformationTest.Multiline = true;
			this.tb_InformationTest.Name = "tb_InformationTest";
			this.tb_InformationTest.ReadOnly = true;
			this.tb_InformationTest.Size = new System.Drawing.Size(267, 184);
			this.tb_InformationTest.TabIndex = 0;
			// 
			// gb_ControlTests
			// 
			this.gb_ControlTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gb_ControlTests.Controls.Add(this.list_Tests);
			this.gb_ControlTests.Controls.Add(this.chb_AccessTest);
			this.gb_ControlTests.Controls.Add(this.btn_DeleteTest);
			this.gb_ControlTests.Controls.Add(this.btn_AddTest);
			this.gb_ControlTests.Controls.Add(this.btn_ModifyTest);
			this.gb_ControlTests.Location = new System.Drawing.Point(3, 3);
			this.gb_ControlTests.Name = "gb_ControlTests";
			this.gb_ControlTests.Size = new System.Drawing.Size(281, 497);
			this.gb_ControlTests.TabIndex = 1;
			this.gb_ControlTests.TabStop = false;
			this.gb_ControlTests.Text = "Управление";
			// 
			// list_Tests
			// 
			this.list_Tests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.list_Tests.FormattingEnabled = true;
			this.list_Tests.Location = new System.Drawing.Point(7, 15);
			this.list_Tests.Name = "list_Tests";
			this.list_Tests.Size = new System.Drawing.Size(268, 407);
			this.list_Tests.TabIndex = 2;
			// 
			// chb_AccessTest
			// 
			this.chb_AccessTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chb_AccessTest.AutoSize = true;
			this.chb_AccessTest.Location = new System.Drawing.Point(7, 446);
			this.chb_AccessTest.Name = "chb_AccessTest";
			this.chb_AccessTest.Size = new System.Drawing.Size(126, 17);
			this.chb_AccessTest.TabIndex = 1;
			this.chb_AccessTest.Text = "Показать ученикам";
			this.chb_AccessTest.UseVisualStyleBackColor = true;
			// 
			// btn_DeleteTest
			// 
			this.btn_DeleteTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_DeleteTest.Location = new System.Drawing.Point(6, 468);
			this.btn_DeleteTest.Name = "btn_DeleteTest";
			this.btn_DeleteTest.Size = new System.Drawing.Size(70, 23);
			this.btn_DeleteTest.TabIndex = 0;
			this.btn_DeleteTest.Text = "Удалить";
			this.btn_DeleteTest.UseVisualStyleBackColor = true;
			// 
			// btn_AddTest
			// 
			this.btn_AddTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_AddTest.Location = new System.Drawing.Point(82, 468);
			this.btn_AddTest.Name = "btn_AddTest";
			this.btn_AddTest.Size = new System.Drawing.Size(86, 23);
			this.btn_AddTest.TabIndex = 0;
			this.btn_AddTest.Text = "Добавить";
			this.btn_AddTest.UseVisualStyleBackColor = true;
			// 
			// btn_ModifyTest
			// 
			this.btn_ModifyTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ModifyTest.Location = new System.Drawing.Point(174, 468);
			this.btn_ModifyTest.Name = "btn_ModifyTest";
			this.btn_ModifyTest.Size = new System.Drawing.Size(101, 23);
			this.btn_ModifyTest.TabIndex = 0;
			this.btn_ModifyTest.Text = "Редактировать";
			this.btn_ModifyTest.UseVisualStyleBackColor = true;
			// 
			// tab_Students
			// 
			this.tab_Students.Controls.Add(this.gb_InformationStudent);
			this.tab_Students.Controls.Add(this.gb_Students);
			this.tab_Students.Location = new System.Drawing.Point(4, 22);
			this.tab_Students.Name = "tab_Students";
			this.tab_Students.Padding = new System.Windows.Forms.Padding(3);
			this.tab_Students.Size = new System.Drawing.Size(759, 506);
			this.tab_Students.TabIndex = 1;
			this.tab_Students.Text = "Ученики";
			this.tab_Students.UseVisualStyleBackColor = true;
			// 
			// gb_InformationStudent
			// 
			this.gb_InformationStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_InformationStudent.Controls.Add(this.gb_TestResult);
			this.gb_InformationStudent.Controls.Add(this.gb_CompleteTests);
			this.gb_InformationStudent.Location = new System.Drawing.Point(303, 3);
			this.gb_InformationStudent.Name = "gb_InformationStudent";
			this.gb_InformationStudent.Size = new System.Drawing.Size(450, 496);
			this.gb_InformationStudent.TabIndex = 1;
			this.gb_InformationStudent.TabStop = false;
			this.gb_InformationStudent.Text = "Информация";
			// 
			// gb_TestResult
			// 
			this.gb_TestResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_TestResult.Controls.Add(this.tb_TestResult);
			this.gb_TestResult.Location = new System.Drawing.Point(212, 23);
			this.gb_TestResult.Name = "gb_TestResult";
			this.gb_TestResult.Size = new System.Drawing.Size(232, 464);
			this.gb_TestResult.TabIndex = 2;
			this.gb_TestResult.TabStop = false;
			this.gb_TestResult.Text = "Результат теста";
			// 
			// tb_TestResult
			// 
			this.tb_TestResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_TestResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_TestResult.Location = new System.Drawing.Point(3, 16);
			this.tb_TestResult.Multiline = true;
			this.tb_TestResult.Name = "tb_TestResult";
			this.tb_TestResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_TestResult.Size = new System.Drawing.Size(226, 445);
			this.tb_TestResult.TabIndex = 0;
			// 
			// gb_CompleteTests
			// 
			this.gb_CompleteTests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gb_CompleteTests.Controls.Add(this.list_CompleteTest);
			this.gb_CompleteTests.Controls.Add(this.chb_AccessCompleteTest);
			this.gb_CompleteTests.Controls.Add(this.btn_DeleteCompleteTest);
			this.gb_CompleteTests.Location = new System.Drawing.Point(6, 23);
			this.gb_CompleteTests.Name = "gb_CompleteTests";
			this.gb_CompleteTests.Size = new System.Drawing.Size(200, 464);
			this.gb_CompleteTests.TabIndex = 1;
			this.gb_CompleteTests.TabStop = false;
			this.gb_CompleteTests.Text = "Выполненные тесты";
			// 
			// list_CompleteTest
			// 
			this.list_CompleteTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.list_CompleteTest.FormattingEnabled = true;
			this.list_CompleteTest.Location = new System.Drawing.Point(7, 16);
			this.list_CompleteTest.Name = "list_CompleteTest";
			this.list_CompleteTest.Size = new System.Drawing.Size(187, 368);
			this.list_CompleteTest.TabIndex = 3;
			// 
			// chb_AccessCompleteTest
			// 
			this.chb_AccessCompleteTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chb_AccessCompleteTest.AutoSize = true;
			this.chb_AccessCompleteTest.Location = new System.Drawing.Point(6, 412);
			this.chb_AccessCompleteTest.Name = "chb_AccessCompleteTest";
			this.chb_AccessCompleteTest.Size = new System.Drawing.Size(117, 17);
			this.chb_AccessCompleteTest.TabIndex = 2;
			this.chb_AccessCompleteTest.Text = "Показать ученику";
			this.chb_AccessCompleteTest.UseVisualStyleBackColor = true;
			// 
			// btn_DeleteCompleteTest
			// 
			this.btn_DeleteCompleteTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_DeleteCompleteTest.Location = new System.Drawing.Point(6, 435);
			this.btn_DeleteCompleteTest.Name = "btn_DeleteCompleteTest";
			this.btn_DeleteCompleteTest.Size = new System.Drawing.Size(187, 23);
			this.btn_DeleteCompleteTest.TabIndex = 1;
			this.btn_DeleteCompleteTest.Text = "Удалить";
			this.btn_DeleteCompleteTest.UseVisualStyleBackColor = true;
			// 
			// gb_Students
			// 
			this.gb_Students.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gb_Students.Controls.Add(this.label1);
			this.gb_Students.Controls.Add(this.tb_StudentInfo);
			this.gb_Students.Controls.Add(this.btn_ModifyStudent);
			this.gb_Students.Controls.Add(this.btn_AddStudent);
			this.gb_Students.Controls.Add(this.btn_DeleteStudent);
			this.gb_Students.Controls.Add(this.list_Students);
			this.gb_Students.Location = new System.Drawing.Point(6, 3);
			this.gb_Students.Name = "gb_Students";
			this.gb_Students.Size = new System.Drawing.Size(291, 496);
			this.gb_Students.TabIndex = 0;
			this.gb_Students.TabStop = false;
			this.gb_Students.Text = "Ученики";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 341);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Информация ученика";
			// 
			// tb_StudentInfo
			// 
			this.tb_StudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_StudentInfo.BackColor = System.Drawing.SystemColors.Window;
			this.tb_StudentInfo.Location = new System.Drawing.Point(6, 360);
			this.tb_StudentInfo.Multiline = true;
			this.tb_StudentInfo.Name = "tb_StudentInfo";
			this.tb_StudentInfo.ReadOnly = true;
			this.tb_StudentInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_StudentInfo.Size = new System.Drawing.Size(279, 92);
			this.tb_StudentInfo.TabIndex = 4;
			// 
			// btn_ModifyStudent
			// 
			this.btn_ModifyStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ModifyStudent.Location = new System.Drawing.Point(192, 464);
			this.btn_ModifyStudent.Name = "btn_ModifyStudent";
			this.btn_ModifyStudent.Size = new System.Drawing.Size(93, 23);
			this.btn_ModifyStudent.TabIndex = 3;
			this.btn_ModifyStudent.Text = "Редактировать";
			this.btn_ModifyStudent.UseVisualStyleBackColor = true;
			// 
			// btn_AddStudent
			// 
			this.btn_AddStudent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_AddStudent.Location = new System.Drawing.Point(100, 464);
			this.btn_AddStudent.Name = "btn_AddStudent";
			this.btn_AddStudent.Size = new System.Drawing.Size(86, 23);
			this.btn_AddStudent.TabIndex = 2;
			this.btn_AddStudent.Text = "Добавить";
			this.btn_AddStudent.UseVisualStyleBackColor = true;
			// 
			// btn_DeleteStudent
			// 
			this.btn_DeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_DeleteStudent.Location = new System.Drawing.Point(6, 464);
			this.btn_DeleteStudent.Name = "btn_DeleteStudent";
			this.btn_DeleteStudent.Size = new System.Drawing.Size(88, 23);
			this.btn_DeleteStudent.TabIndex = 1;
			this.btn_DeleteStudent.Text = "Удалить";
			this.btn_DeleteStudent.UseVisualStyleBackColor = true;
			// 
			// list_Students
			// 
			this.list_Students.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.list_Students.FormattingEnabled = true;
			this.list_Students.Location = new System.Drawing.Point(6, 19);
			this.list_Students.Name = "list_Students";
			this.list_Students.Size = new System.Drawing.Size(279, 316);
			this.list_Students.TabIndex = 0;
			// 
			// tab_Rules
			// 
			this.tab_Rules.Controls.Add(this.chb_AccessRule);
			this.tab_Rules.Controls.Add(this.tb_RuleDescription);
			this.tab_Rules.Controls.Add(this.btn_ModifyRule);
			this.tab_Rules.Controls.Add(this.btn_AddRule);
			this.tab_Rules.Controls.Add(this.btn_DeleteRule);
			this.tab_Rules.Controls.Add(this.list_Rules);
			this.tab_Rules.Location = new System.Drawing.Point(4, 22);
			this.tab_Rules.Name = "tab_Rules";
			this.tab_Rules.Size = new System.Drawing.Size(759, 506);
			this.tab_Rules.TabIndex = 2;
			this.tab_Rules.Text = "Правила";
			this.tab_Rules.UseVisualStyleBackColor = true;
			// 
			// chb_AccessRule
			// 
			this.chb_AccessRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chb_AccessRule.AutoSize = true;
			this.chb_AccessRule.Location = new System.Drawing.Point(9, 442);
			this.chb_AccessRule.Name = "chb_AccessRule";
			this.chb_AccessRule.Size = new System.Drawing.Size(126, 17);
			this.chb_AccessRule.TabIndex = 5;
			this.chb_AccessRule.Text = "Показать ученикам";
			this.chb_AccessRule.UseVisualStyleBackColor = true;
			// 
			// tb_RuleDescription
			// 
			this.tb_RuleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_RuleDescription.BackColor = System.Drawing.SystemColors.Window;
			this.tb_RuleDescription.Location = new System.Drawing.Point(254, 3);
			this.tb_RuleDescription.Multiline = true;
			this.tb_RuleDescription.Name = "tb_RuleDescription";
			this.tb_RuleDescription.ReadOnly = true;
			this.tb_RuleDescription.Size = new System.Drawing.Size(497, 488);
			this.tb_RuleDescription.TabIndex = 4;
			this.tb_RuleDescription.TabStop = false;
			// 
			// btn_ModifyRule
			// 
			this.btn_ModifyRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_ModifyRule.Location = new System.Drawing.Point(173, 468);
			this.btn_ModifyRule.Name = "btn_ModifyRule";
			this.btn_ModifyRule.Size = new System.Drawing.Size(75, 23);
			this.btn_ModifyRule.TabIndex = 3;
			this.btn_ModifyRule.Text = "Редактировать";
			this.btn_ModifyRule.UseVisualStyleBackColor = true;
			// 
			// btn_AddRule
			// 
			this.btn_AddRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_AddRule.Location = new System.Drawing.Point(91, 468);
			this.btn_AddRule.Name = "btn_AddRule";
			this.btn_AddRule.Size = new System.Drawing.Size(75, 23);
			this.btn_AddRule.TabIndex = 2;
			this.btn_AddRule.Text = "Добавить";
			this.btn_AddRule.UseVisualStyleBackColor = true;
			// 
			// btn_DeleteRule
			// 
			this.btn_DeleteRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_DeleteRule.Location = new System.Drawing.Point(9, 468);
			this.btn_DeleteRule.Name = "btn_DeleteRule";
			this.btn_DeleteRule.Size = new System.Drawing.Size(75, 23);
			this.btn_DeleteRule.TabIndex = 1;
			this.btn_DeleteRule.Text = "Удалить";
			this.btn_DeleteRule.UseVisualStyleBackColor = true;
			// 
			// list_Rules
			// 
			this.list_Rules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.list_Rules.FormattingEnabled = true;
			this.list_Rules.Location = new System.Drawing.Point(9, 3);
			this.list_Rules.Name = "list_Rules";
			this.list_Rules.Size = new System.Drawing.Size(239, 407);
			this.list_Rules.TabIndex = 0;
			// 
			// tab_Media
			// 
			this.tab_Media.Controls.Add(this.btn_OpenMediaFile);
			this.tab_Media.Controls.Add(this.chb_AccessMedia);
			this.tab_Media.Controls.Add(this.btn_AddMedia);
			this.tab_Media.Controls.Add(this.btn_DeleteMedia);
			this.tab_Media.Controls.Add(this.tb_InformationMedia);
			this.tab_Media.Controls.Add(this.list_MediaPath);
			this.tab_Media.Location = new System.Drawing.Point(4, 22);
			this.tab_Media.Name = "tab_Media";
			this.tab_Media.Size = new System.Drawing.Size(759, 506);
			this.tab_Media.TabIndex = 3;
			this.tab_Media.Text = "Медиа";
			this.tab_Media.UseVisualStyleBackColor = true;
			// 
			// chb_AccessMedia
			// 
			this.chb_AccessMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chb_AccessMedia.AutoSize = true;
			this.chb_AccessMedia.Location = new System.Drawing.Point(9, 447);
			this.chb_AccessMedia.Name = "chb_AccessMedia";
			this.chb_AccessMedia.Size = new System.Drawing.Size(126, 17);
			this.chb_AccessMedia.TabIndex = 4;
			this.chb_AccessMedia.Text = "Показать ученикам";
			this.chb_AccessMedia.UseVisualStyleBackColor = true;
			// 
			// btn_AddMedia
			// 
			this.btn_AddMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_AddMedia.Location = new System.Drawing.Point(91, 470);
			this.btn_AddMedia.Name = "btn_AddMedia";
			this.btn_AddMedia.Size = new System.Drawing.Size(75, 23);
			this.btn_AddMedia.TabIndex = 3;
			this.btn_AddMedia.Text = "Добавить";
			this.btn_AddMedia.UseVisualStyleBackColor = true;
			// 
			// btn_DeleteMedia
			// 
			this.btn_DeleteMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_DeleteMedia.Location = new System.Drawing.Point(9, 470);
			this.btn_DeleteMedia.Name = "btn_DeleteMedia";
			this.btn_DeleteMedia.Size = new System.Drawing.Size(75, 23);
			this.btn_DeleteMedia.TabIndex = 2;
			this.btn_DeleteMedia.Text = "Удалить";
			this.btn_DeleteMedia.UseVisualStyleBackColor = true;
			// 
			// tb_InformationMedia
			// 
			this.tb_InformationMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_InformationMedia.Location = new System.Drawing.Point(253, 3);
			this.tb_InformationMedia.Multiline = true;
			this.tb_InformationMedia.Name = "tb_InformationMedia";
			this.tb_InformationMedia.Size = new System.Drawing.Size(503, 495);
			this.tb_InformationMedia.TabIndex = 1;
			// 
			// list_MediaPath
			// 
			this.list_MediaPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.list_MediaPath.FormattingEnabled = true;
			this.list_MediaPath.Location = new System.Drawing.Point(8, 3);
			this.list_MediaPath.Name = "list_MediaPath";
			this.list_MediaPath.Size = new System.Drawing.Size(239, 433);
			this.list_MediaPath.TabIndex = 0;
			// 
			// btn_OpenMediaFile
			// 
			this.btn_OpenMediaFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_OpenMediaFile.Location = new System.Drawing.Point(172, 470);
			this.btn_OpenMediaFile.Name = "btn_OpenMediaFile";
			this.btn_OpenMediaFile.Size = new System.Drawing.Size(75, 23);
			this.btn_OpenMediaFile.TabIndex = 5;
			this.btn_OpenMediaFile.Text = "Воспроизвести";
			this.btn_OpenMediaFile.UseVisualStyleBackColor = true;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 556);
			this.Controls.Add(this.tab_Master);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.Text = "Сеанс Учитель";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tab_Master.ResumeLayout(false);
			this.tab_Tests.ResumeLayout(false);
			this.gb_InformationTest.ResumeLayout(false);
			this.gb_InformationTest.PerformLayout();
			this.gb_ControlTests.ResumeLayout(false);
			this.gb_ControlTests.PerformLayout();
			this.tab_Students.ResumeLayout(false);
			this.gb_InformationStudent.ResumeLayout(false);
			this.gb_TestResult.ResumeLayout(false);
			this.gb_TestResult.PerformLayout();
			this.gb_CompleteTests.ResumeLayout(false);
			this.gb_CompleteTests.PerformLayout();
			this.gb_Students.ResumeLayout(false);
			this.gb_Students.PerformLayout();
			this.tab_Rules.ResumeLayout(false);
			this.tab_Rules.PerformLayout();
			this.tab_Media.ResumeLayout(false);
			this.tab_Media.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menu_Master;
		private System.Windows.Forms.ToolStripMenuItem menu_OpenDiary;
		private System.Windows.Forms.ToolStripMenuItem menu_Settings;
		private System.Windows.Forms.ToolStripMenuItem menu_ChangePathDB;
		private System.Windows.Forms.TabControl tab_Master;
		private System.Windows.Forms.TabPage tab_Tests;
		private System.Windows.Forms.GroupBox gb_InformationTest;
		private System.Windows.Forms.TextBox tb_InformationTest;
		private System.Windows.Forms.GroupBox gb_ControlTests;
		private System.Windows.Forms.Button btn_DeleteTest;
		private System.Windows.Forms.Button btn_AddTest;
		private System.Windows.Forms.Button btn_ModifyTest;
		private System.Windows.Forms.TabPage tab_Students;
		private System.Windows.Forms.GroupBox gb_InformationStudent;
		private System.Windows.Forms.GroupBox gb_Students;
		private System.Windows.Forms.Button btn_ModifyStudent;
		private System.Windows.Forms.Button btn_AddStudent;
		private System.Windows.Forms.Button btn_DeleteStudent;
		private System.Windows.Forms.ListBox list_Students;
		private System.Windows.Forms.TabPage tab_Rules;
		private System.Windows.Forms.TabPage tab_Media;
		private System.Windows.Forms.CheckBox chb_AccessTest;
		private System.Windows.Forms.GroupBox gb_TestResult;
		private System.Windows.Forms.TextBox tb_TestResult;
		private System.Windows.Forms.GroupBox gb_CompleteTests;
		private System.Windows.Forms.CheckBox chb_AccessCompleteTest;
		private System.Windows.Forms.Button btn_DeleteCompleteTest;
		private System.Windows.Forms.TextBox tb_RuleDescription;
		private System.Windows.Forms.Button btn_ModifyRule;
		private System.Windows.Forms.Button btn_AddRule;
		private System.Windows.Forms.Button btn_DeleteRule;
		private System.Windows.Forms.ListBox list_Rules;
		private System.Windows.Forms.CheckBox chb_AccessRule;
		private System.Windows.Forms.CheckBox chb_AccessMedia;
		private System.Windows.Forms.Button btn_AddMedia;
		private System.Windows.Forms.Button btn_DeleteMedia;
		private System.Windows.Forms.TextBox tb_InformationMedia;
		private System.Windows.Forms.ListBox list_MediaPath;
		private System.Windows.Forms.TextBox tb_StudentInfo;
		private System.Windows.Forms.ListBox list_CompleteTest;
		private System.Windows.Forms.ListBox list_Tests;
		private System.Windows.Forms.Label lbl_QuestionInfo;
		private System.Windows.Forms.Label lbl_Question;
		private System.Windows.Forms.ListBox list_Questions;
		private System.Windows.Forms.Label lbl_InformationQuestion;
		private System.Windows.Forms.TextBox tb_InformationQuestion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_OpenMediaFile;
	}
}

