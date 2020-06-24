namespace Student
{
	partial class Test
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbl_StartTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbl_Timer = new System.Windows.Forms.ToolStripStatusLabel();
			this.btn_FinishTest = new System.Windows.Forms.Button();
			//this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
			this.list_Question = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbl_yourAnswer = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.list_Answers = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_Question = new System.Windows.Forms.TextBox();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_StartTime,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lbl_Timer});
			this.statusStrip1.Location = new System.Drawing.Point(0, 378);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(616, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 17);
			this.toolStripStatusLabel1.Text = "Время начала:";
			// 
			// lbl_StartTime
			// 
			this.lbl_StartTime.Name = "lbl_StartTime";
			this.lbl_StartTime.Size = new System.Drawing.Size(31, 17);
			this.lbl_StartTime.Text = "0:0:0";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
			this.toolStripStatusLabel3.Text = "|";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(62, 17);
			this.toolStripStatusLabel4.Text = "Осталось:";
			// 
			// lbl_Timer
			// 
			this.lbl_Timer.Name = "lbl_Timer";
			this.lbl_Timer.Size = new System.Drawing.Size(31, 17);
			this.lbl_Timer.Text = "0:0:0";
			// 
			// btn_FinishTest
			// 
			this.btn_FinishTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_FinishTest.Location = new System.Drawing.Point(409, 338);
			this.btn_FinishTest.Name = "btn_FinishTest";
			this.btn_FinishTest.Size = new System.Drawing.Size(195, 23);
			this.btn_FinishTest.TabIndex = 5;
			this.btn_FinishTest.Text = "Завершить";
			this.btn_FinishTest.UseVisualStyleBackColor = true;
			// 
			// sqLiteCommand1
			// 
			//this.sqLiteCommand1.CommandText = null;
			// 
			// list_Question
			// 
			this.list_Question.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.list_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.list_Question.HideSelection = false;
			this.list_Question.LabelWrap = false;
			this.list_Question.Location = new System.Drawing.Point(409, 34);
			this.list_Question.MultiSelect = false;
			this.list_Question.Name = "list_Question";
			this.list_Question.ShowGroups = false;
			this.list_Question.Size = new System.Drawing.Size(194, 298);
			this.list_Question.TabIndex = 6;
			this.list_Question.UseCompatibleStateImageBehavior = false;
			this.list_Question.View = System.Windows.Forms.View.List;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(409, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Вопросы";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(391, 349);
			this.panel1.TabIndex = 8;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.lbl_yourAnswer);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.list_Answers);
			this.groupBox2.Location = new System.Drawing.Point(4, 169);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(384, 177);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Варианты ответа";
			// 
			// lbl_yourAnswer
			// 
			this.lbl_yourAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_yourAnswer.AutoSize = true;
			this.lbl_yourAnswer.Location = new System.Drawing.Point(75, 158);
			this.lbl_yourAnswer.Name = "lbl_yourAnswer";
			this.lbl_yourAnswer.Size = new System.Drawing.Size(37, 13);
			this.lbl_yourAnswer.TabIndex = 2;
			this.lbl_yourAnswer.Text = "Ответ";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ваш ответ:";
			// 
			// list_Answers
			// 
			this.list_Answers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.list_Answers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.list_Answers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.list_Answers.FormattingEnabled = true;
			this.list_Answers.Location = new System.Drawing.Point(7, 20);
			this.list_Answers.Name = "list_Answers";
			this.list_Answers.Size = new System.Drawing.Size(371, 119);
			this.list_Answers.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tb_Question);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 159);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Вопрос";
			// 
			// tb_Question
			// 
			this.tb_Question.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_Question.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Question.Location = new System.Drawing.Point(3, 16);
			this.tb_Question.Multiline = true;
			this.tb_Question.Name = "tb_Question";
			this.tb_Question.ReadOnly = true;
			this.tb_Question.Size = new System.Drawing.Size(379, 140);
			this.tb_Question.TabIndex = 0;
			// 
			// Test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 400);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.list_Question);
			this.Controls.Add(this.btn_FinishTest);
			this.Controls.Add(this.statusStrip1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(632, 439);
			this.Name = "Test";
			this.ShowIcon = false;
			this.Text = "Тестирование";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_StartTime;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel lbl_Timer;
		private System.Windows.Forms.Button btn_FinishTest;
		//private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
		private System.Windows.Forms.ListView list_Question;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_yourAnswer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox list_Answers;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tb_Question;
	}
}