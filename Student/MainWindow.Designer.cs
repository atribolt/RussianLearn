namespace Student
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
			this.tab_MainLayout = new System.Windows.Forms.TabControl();
			this.tab_AllowTests = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.list_AllowTest = new System.Windows.Forms.ListBox();
			this.btn_StartTest = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_DescriptionTest = new System.Windows.Forms.TextBox();
			this.tab_Materials = new System.Windows.Forms.TabPage();
			this.tab_Education = new System.Windows.Forms.TabControl();
			this.tab_Rules = new System.Windows.Forms.TabPage();
			this.tb_RulesDescription = new System.Windows.Forms.TextBox();
			this.list_Rules = new System.Windows.Forms.ListBox();
			this.tab_Media = new System.Windows.Forms.TabPage();
			this.list_Media = new System.Windows.Forms.ListBox();
			this.tab_Progress = new System.Windows.Forms.TabPage();
			this.list_TestResult = new System.Windows.Forms.ListBox();
			this.tb_ShowResult = new System.Windows.Forms.TextBox();
			this.tab_MainLayout.SuspendLayout();
			this.tab_AllowTests.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tab_Materials.SuspendLayout();
			this.tab_Education.SuspendLayout();
			this.tab_Rules.SuspendLayout();
			this.tab_Media.SuspendLayout();
			this.tab_Progress.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab_MainLayout
			// 
			this.tab_MainLayout.Controls.Add(this.tab_AllowTests);
			this.tab_MainLayout.Controls.Add(this.tab_Materials);
			this.tab_MainLayout.Controls.Add(this.tab_Progress);
			this.tab_MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_MainLayout.Location = new System.Drawing.Point(0, 0);
			this.tab_MainLayout.Name = "tab_MainLayout";
			this.tab_MainLayout.SelectedIndex = 0;
			this.tab_MainLayout.Size = new System.Drawing.Size(546, 342);
			this.tab_MainLayout.TabIndex = 0;
			// 
			// tab_AllowTests
			// 
			this.tab_AllowTests.Controls.Add(this.groupBox2);
			this.tab_AllowTests.Controls.Add(this.groupBox1);
			this.tab_AllowTests.Location = new System.Drawing.Point(4, 22);
			this.tab_AllowTests.Name = "tab_AllowTests";
			this.tab_AllowTests.Size = new System.Drawing.Size(538, 316);
			this.tab_AllowTests.TabIndex = 0;
			this.tab_AllowTests.Text = "Доступные тесты";
			this.tab_AllowTests.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.list_AllowTest);
			this.groupBox2.Controls.Add(this.btn_StartTest);
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(191, 305);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// list_AllowTest
			// 
			this.list_AllowTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.list_AllowTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.list_AllowTest.FormattingEnabled = true;
			this.list_AllowTest.Location = new System.Drawing.Point(6, 19);
			this.list_AllowTest.Name = "list_AllowTest";
			this.list_AllowTest.Size = new System.Drawing.Size(179, 234);
			this.list_AllowTest.TabIndex = 0;
			// 
			// btn_StartTest
			// 
			this.btn_StartTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_StartTest.Enabled = false;
			this.btn_StartTest.Location = new System.Drawing.Point(5, 277);
			this.btn_StartTest.Name = "btn_StartTest";
			this.btn_StartTest.Size = new System.Drawing.Size(180, 23);
			this.btn_StartTest.TabIndex = 2;
			this.btn_StartTest.Text = "Запустить";
			this.btn_StartTest.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tb_DescriptionTest);
			this.groupBox1.Location = new System.Drawing.Point(200, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(336, 306);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Описание";
			// 
			// tb_DescriptionTest
			// 
			this.tb_DescriptionTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_DescriptionTest.BackColor = System.Drawing.SystemColors.Window;
			this.tb_DescriptionTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_DescriptionTest.Location = new System.Drawing.Point(6, 19);
			this.tb_DescriptionTest.Multiline = true;
			this.tb_DescriptionTest.Name = "tb_DescriptionTest";
			this.tb_DescriptionTest.ReadOnly = true;
			this.tb_DescriptionTest.Size = new System.Drawing.Size(324, 281);
			this.tb_DescriptionTest.TabIndex = 0;
			// 
			// tab_Materials
			// 
			this.tab_Materials.Controls.Add(this.tab_Education);
			this.tab_Materials.Location = new System.Drawing.Point(4, 22);
			this.tab_Materials.Name = "tab_Materials";
			this.tab_Materials.Size = new System.Drawing.Size(538, 316);
			this.tab_Materials.TabIndex = 1;
			this.tab_Materials.Text = "Обучение";
			this.tab_Materials.UseVisualStyleBackColor = true;
			// 
			// tab_Education
			// 
			this.tab_Education.Controls.Add(this.tab_Rules);
			this.tab_Education.Controls.Add(this.tab_Media);
			this.tab_Education.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tab_Education.Location = new System.Drawing.Point(0, 0);
			this.tab_Education.Name = "tab_Education";
			this.tab_Education.SelectedIndex = 0;
			this.tab_Education.Size = new System.Drawing.Size(538, 316);
			this.tab_Education.TabIndex = 0;
			// 
			// tab_Rules
			// 
			this.tab_Rules.Controls.Add(this.tb_RulesDescription);
			this.tab_Rules.Controls.Add(this.list_Rules);
			this.tab_Rules.Location = new System.Drawing.Point(4, 22);
			this.tab_Rules.Name = "tab_Rules";
			this.tab_Rules.Padding = new System.Windows.Forms.Padding(3);
			this.tab_Rules.Size = new System.Drawing.Size(530, 290);
			this.tab_Rules.TabIndex = 0;
			this.tab_Rules.Text = "Правила";
			this.tab_Rules.UseVisualStyleBackColor = true;
			// 
			// tb_RulesDescription
			// 
			this.tb_RulesDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_RulesDescription.Location = new System.Drawing.Point(194, 6);
			this.tb_RulesDescription.Multiline = true;
			this.tb_RulesDescription.Name = "tb_RulesDescription";
			this.tb_RulesDescription.Size = new System.Drawing.Size(330, 270);
			this.tb_RulesDescription.TabIndex = 1;
			// 
			// list_Rules
			// 
			this.list_Rules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.list_Rules.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.list_Rules.FormattingEnabled = true;
			this.list_Rules.Location = new System.Drawing.Point(6, 6);
			this.list_Rules.Name = "list_Rules";
			this.list_Rules.Size = new System.Drawing.Size(182, 260);
			this.list_Rules.TabIndex = 0;
			// 
			// tab_Media
			// 
			this.tab_Media.Controls.Add(this.list_Media);
			this.tab_Media.Location = new System.Drawing.Point(4, 22);
			this.tab_Media.Name = "tab_Media";
			this.tab_Media.Padding = new System.Windows.Forms.Padding(3);
			this.tab_Media.Size = new System.Drawing.Size(728, 440);
			this.tab_Media.TabIndex = 1;
			this.tab_Media.Text = "Медийные материалы";
			this.tab_Media.UseVisualStyleBackColor = true;
			// 
			// list_Media
			// 
			this.list_Media.Dock = System.Windows.Forms.DockStyle.Fill;
			this.list_Media.FormattingEnabled = true;
			this.list_Media.Location = new System.Drawing.Point(3, 3);
			this.list_Media.Name = "list_Media";
			this.list_Media.Size = new System.Drawing.Size(722, 434);
			this.list_Media.TabIndex = 0;
			// 
			// tab_Progress
			// 
			this.tab_Progress.Controls.Add(this.list_TestResult);
			this.tab_Progress.Controls.Add(this.tb_ShowResult);
			this.tab_Progress.Location = new System.Drawing.Point(4, 22);
			this.tab_Progress.Name = "tab_Progress";
			this.tab_Progress.Size = new System.Drawing.Size(538, 316);
			this.tab_Progress.TabIndex = 2;
			this.tab_Progress.Text = "Результаты тестов";
			this.tab_Progress.UseVisualStyleBackColor = true;
			// 
			// list_TestResult
			// 
			this.list_TestResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.list_TestResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.list_TestResult.FormattingEnabled = true;
			this.list_TestResult.Location = new System.Drawing.Point(3, 3);
			this.list_TestResult.Name = "list_TestResult";
			this.list_TestResult.Size = new System.Drawing.Size(232, 442);
			this.list_TestResult.TabIndex = 1;
			// 
			// tb_ShowResult
			// 
			this.tb_ShowResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_ShowResult.Location = new System.Drawing.Point(241, 3);
			this.tb_ShowResult.Multiline = true;
			this.tb_ShowResult.Name = "tb_ShowResult";
			this.tb_ShowResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_ShowResult.Size = new System.Drawing.Size(486, 455);
			this.tb_ShowResult.TabIndex = 0;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 342);
			this.Controls.Add(this.tab_MainLayout);
			this.MinimumSize = new System.Drawing.Size(562, 381);
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.Text = "Ученик";
			this.tab_MainLayout.ResumeLayout(false);
			this.tab_AllowTests.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tab_Materials.ResumeLayout(false);
			this.tab_Education.ResumeLayout(false);
			this.tab_Rules.ResumeLayout(false);
			this.tab_Rules.PerformLayout();
			this.tab_Media.ResumeLayout(false);
			this.tab_Progress.ResumeLayout(false);
			this.tab_Progress.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tab_MainLayout;
		private System.Windows.Forms.TabPage tab_AllowTests;
		private System.Windows.Forms.TabPage tab_Materials;
		private System.Windows.Forms.TabPage tab_Progress;
		private System.Windows.Forms.ListBox list_TestResult;
		private System.Windows.Forms.TextBox tb_ShowResult;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox list_AllowTest;
		private System.Windows.Forms.TabControl tab_Education;
		private System.Windows.Forms.TabPage tab_Rules;
		private System.Windows.Forms.TabPage tab_Media;
		private System.Windows.Forms.Button btn_StartTest;
		private System.Windows.Forms.TextBox tb_DescriptionTest;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tb_RulesDescription;
		private System.Windows.Forms.ListBox list_Rules;
		private System.Windows.Forms.ListBox list_Media;
	}
}

