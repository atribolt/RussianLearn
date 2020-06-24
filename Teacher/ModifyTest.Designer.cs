namespace Teacher
{
	partial class ModifyTest
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
			this.tree_Questions = new System.Windows.Forms.TreeView();
			this.tb_TestName = new System.Windows.Forms.TextBox();
			this.gb_Questions = new System.Windows.Forms.GroupBox();
			this.gb_TestParams = new System.Windows.Forms.GroupBox();
			this.btn_DeleteQuestion = new System.Windows.Forms.Button();
			this.btn_AddQuestion = new System.Windows.Forms.Button();
			this.chb_AccessTest = new System.Windows.Forms.CheckBox();
			this.btn_ModifyQuestion = new System.Windows.Forms.Button();
			this.num_TimeExec = new System.Windows.Forms.NumericUpDown();
			this.lbl_TimeExec = new System.Windows.Forms.Label();
			this.tb_Question = new System.Windows.Forms.TextBox();
			this.btn_Done = new System.Windows.Forms.Button();
			this.gb_Questions.SuspendLayout();
			this.gb_TestParams.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_TimeExec)).BeginInit();
			this.SuspendLayout();
			// 
			// tree_Questions
			// 
			this.tree_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tree_Questions.Location = new System.Drawing.Point(6, 19);
			this.tree_Questions.Name = "tree_Questions";
			this.tree_Questions.Size = new System.Drawing.Size(183, 228);
			this.tree_Questions.TabIndex = 2;
			// 
			// tb_TestName
			// 
			this.tb_TestName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_TestName.Location = new System.Drawing.Point(6, 19);
			this.tb_TestName.Name = "tb_TestName";
			this.tb_TestName.Size = new System.Drawing.Size(383, 20);
			this.tb_TestName.TabIndex = 3;
			// 
			// gb_Questions
			// 
			this.gb_Questions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_Questions.Controls.Add(this.tb_Question);
			this.gb_Questions.Controls.Add(this.btn_ModifyQuestion);
			this.gb_Questions.Controls.Add(this.btn_AddQuestion);
			this.gb_Questions.Controls.Add(this.btn_DeleteQuestion);
			this.gb_Questions.Controls.Add(this.tree_Questions);
			this.gb_Questions.Location = new System.Drawing.Point(15, 89);
			this.gb_Questions.Name = "gb_Questions";
			this.gb_Questions.Size = new System.Drawing.Size(395, 282);
			this.gb_Questions.TabIndex = 5;
			this.gb_Questions.TabStop = false;
			this.gb_Questions.Text = "Вопросы";
			// 
			// gb_TestParams
			// 
			this.gb_TestParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_TestParams.Controls.Add(this.lbl_TimeExec);
			this.gb_TestParams.Controls.Add(this.num_TimeExec);
			this.gb_TestParams.Controls.Add(this.chb_AccessTest);
			this.gb_TestParams.Controls.Add(this.tb_TestName);
			this.gb_TestParams.Location = new System.Drawing.Point(15, 12);
			this.gb_TestParams.Name = "gb_TestParams";
			this.gb_TestParams.Size = new System.Drawing.Size(395, 71);
			this.gb_TestParams.TabIndex = 6;
			this.gb_TestParams.TabStop = false;
			this.gb_TestParams.Text = "Название теста";
			// 
			// btn_DeleteQuestion
			// 
			this.btn_DeleteQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_DeleteQuestion.Location = new System.Drawing.Point(6, 253);
			this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
			this.btn_DeleteQuestion.Size = new System.Drawing.Size(132, 23);
			this.btn_DeleteQuestion.TabIndex = 3;
			this.btn_DeleteQuestion.Text = "Удалить вопрос";
			this.btn_DeleteQuestion.UseVisualStyleBackColor = true;
			// 
			// btn_AddQuestion
			// 
			this.btn_AddQuestion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_AddQuestion.Location = new System.Drawing.Point(143, 253);
			this.btn_AddQuestion.Name = "btn_AddQuestion";
			this.btn_AddQuestion.Size = new System.Drawing.Size(134, 23);
			this.btn_AddQuestion.TabIndex = 4;
			this.btn_AddQuestion.Text = "Добавить вопрос";
			this.btn_AddQuestion.UseVisualStyleBackColor = true;
			// 
			// chb_AccessTest
			// 
			this.chb_AccessTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chb_AccessTest.AutoSize = true;
			this.chb_AccessTest.Location = new System.Drawing.Point(7, 46);
			this.chb_AccessTest.Name = "chb_AccessTest";
			this.chb_AccessTest.Size = new System.Drawing.Size(170, 17);
			this.chb_AccessTest.TabIndex = 4;
			this.chb_AccessTest.Text = "Разрешить доступ ученикам";
			this.chb_AccessTest.UseVisualStyleBackColor = true;
			// 
			// btn_ModifyQuestion
			// 
			this.btn_ModifyQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_ModifyQuestion.Location = new System.Drawing.Point(282, 253);
			this.btn_ModifyQuestion.Name = "btn_ModifyQuestion";
			this.btn_ModifyQuestion.Size = new System.Drawing.Size(107, 23);
			this.btn_ModifyQuestion.TabIndex = 5;
			this.btn_ModifyQuestion.Text = "Редактировать";
			this.btn_ModifyQuestion.UseVisualStyleBackColor = true;
			// 
			// num_TimeExec
			// 
			this.num_TimeExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.num_TimeExec.Location = new System.Drawing.Point(323, 43);
			this.num_TimeExec.Name = "num_TimeExec";
			this.num_TimeExec.Size = new System.Drawing.Size(66, 20);
			this.num_TimeExec.TabIndex = 5;
			this.num_TimeExec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_TimeExec
			// 
			this.lbl_TimeExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_TimeExec.AutoSize = true;
			this.lbl_TimeExec.Location = new System.Drawing.Point(245, 47);
			this.lbl_TimeExec.Name = "lbl_TimeExec";
			this.lbl_TimeExec.Size = new System.Drawing.Size(72, 13);
			this.lbl_TimeExec.TabIndex = 6;
			this.lbl_TimeExec.Text = "Время (мин):";
			// 
			// tb_Question
			// 
			this.tb_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Question.Location = new System.Drawing.Point(196, 20);
			this.tb_Question.Multiline = true;
			this.tb_Question.Name = "tb_Question";
			this.tb_Question.ReadOnly = true;
			this.tb_Question.Size = new System.Drawing.Size(193, 227);
			this.tb_Question.TabIndex = 6;
			this.tb_Question.TabStop = false;
			// 
			// btn_Done
			// 
			this.btn_Done.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Done.Location = new System.Drawing.Point(15, 377);
			this.btn_Done.Name = "btn_Done";
			this.btn_Done.Size = new System.Drawing.Size(395, 23);
			this.btn_Done.TabIndex = 7;
			this.btn_Done.Text = "Готово";
			this.btn_Done.UseVisualStyleBackColor = true;
			// 
			// ModifyTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 405);
			this.Controls.Add(this.btn_Done);
			this.Controls.Add(this.gb_TestParams);
			this.Controls.Add(this.gb_Questions);
			this.MinimumSize = new System.Drawing.Size(442, 425);
			this.Name = "ModifyTest";
			this.ShowIcon = false;
			this.Text = "Редатировани/Создание теста";
			this.gb_Questions.ResumeLayout(false);
			this.gb_Questions.PerformLayout();
			this.gb_TestParams.ResumeLayout(false);
			this.gb_TestParams.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_TimeExec)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TreeView tree_Questions;
		private System.Windows.Forms.TextBox tb_TestName;
		private System.Windows.Forms.GroupBox gb_Questions;
		private System.Windows.Forms.Button btn_AddQuestion;
		private System.Windows.Forms.Button btn_DeleteQuestion;
		private System.Windows.Forms.GroupBox gb_TestParams;
		private System.Windows.Forms.CheckBox chb_AccessTest;
		private System.Windows.Forms.Button btn_ModifyQuestion;
		private System.Windows.Forms.Label lbl_TimeExec;
		private System.Windows.Forms.NumericUpDown num_TimeExec;
		private System.Windows.Forms.TextBox tb_Question;
		private System.Windows.Forms.Button btn_Done;
	}
}