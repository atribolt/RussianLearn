namespace Teacher
{
	partial class ModifyQuestion
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
			this.components = new System.ComponentModel.Container();
			this.list_Answers = new System.Windows.Forms.ListBox();
			this.tb_TextQuestion = new System.Windows.Forms.TextBox();
			this.gb_TextQuestion = new System.Windows.Forms.GroupBox();
			this.gb_Variants = new System.Windows.Forms.GroupBox();
			this.tb_InputAnswer = new System.Windows.Forms.TextBox();
			this.btn_AddAnswer = new System.Windows.Forms.Button();
			this.btn_DeleteAnswer = new System.Windows.Forms.Button();
			this.lbl_TrueAnswer = new System.Windows.Forms.Label();
			this.tb_TrueAnswer = new System.Windows.Forms.TextBox();
			this.btn_Done = new System.Windows.Forms.Button();
			this.ttip_ShowMessage = new System.Windows.Forms.ToolTip(this.components);
			this.gb_TextQuestion.SuspendLayout();
			this.gb_Variants.SuspendLayout();
			this.SuspendLayout();
			// 
			// list_Answers
			// 
			this.list_Answers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.list_Answers.FormattingEnabled = true;
			this.list_Answers.Location = new System.Drawing.Point(6, 19);
			this.list_Answers.Name = "list_Answers";
			this.list_Answers.Size = new System.Drawing.Size(188, 147);
			this.list_Answers.TabIndex = 0;
			// 
			// tb_TextQuestion
			// 
			this.tb_TextQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_TextQuestion.Location = new System.Drawing.Point(3, 16);
			this.tb_TextQuestion.Multiline = true;
			this.tb_TextQuestion.Name = "tb_TextQuestion";
			this.tb_TextQuestion.Size = new System.Drawing.Size(194, 81);
			this.tb_TextQuestion.TabIndex = 1;
			// 
			// gb_TextQuestion
			// 
			this.gb_TextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_TextQuestion.Controls.Add(this.tb_TextQuestion);
			this.gb_TextQuestion.Location = new System.Drawing.Point(12, 12);
			this.gb_TextQuestion.Name = "gb_TextQuestion";
			this.gb_TextQuestion.Size = new System.Drawing.Size(200, 100);
			this.gb_TextQuestion.TabIndex = 2;
			this.gb_TextQuestion.TabStop = false;
			this.gb_TextQuestion.Text = "Текст вопроса";
			// 
			// gb_Variants
			// 
			this.gb_Variants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_Variants.Controls.Add(this.tb_InputAnswer);
			this.gb_Variants.Controls.Add(this.btn_AddAnswer);
			this.gb_Variants.Controls.Add(this.btn_DeleteAnswer);
			this.gb_Variants.Controls.Add(this.lbl_TrueAnswer);
			this.gb_Variants.Controls.Add(this.tb_TrueAnswer);
			this.gb_Variants.Controls.Add(this.list_Answers);
			this.gb_Variants.Location = new System.Drawing.Point(12, 118);
			this.gb_Variants.Name = "gb_Variants";
			this.gb_Variants.Size = new System.Drawing.Size(200, 281);
			this.gb_Variants.TabIndex = 3;
			this.gb_Variants.TabStop = false;
			this.gb_Variants.Text = "Варианты ответов";
			// 
			// tb_InputAnswer
			// 
			this.tb_InputAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_InputAnswer.Location = new System.Drawing.Point(6, 172);
			this.tb_InputAnswer.Name = "tb_InputAnswer";
			this.tb_InputAnswer.Size = new System.Drawing.Size(188, 20);
			this.tb_InputAnswer.TabIndex = 5;
			// 
			// btn_AddAnswer
			// 
			this.btn_AddAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_AddAnswer.Location = new System.Drawing.Point(104, 198);
			this.btn_AddAnswer.Name = "btn_AddAnswer";
			this.btn_AddAnswer.Size = new System.Drawing.Size(90, 23);
			this.btn_AddAnswer.TabIndex = 4;
			this.btn_AddAnswer.Text = "Добавить";
			this.btn_AddAnswer.UseVisualStyleBackColor = true;
			// 
			// btn_DeleteAnswer
			// 
			this.btn_DeleteAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_DeleteAnswer.Location = new System.Drawing.Point(6, 198);
			this.btn_DeleteAnswer.Name = "btn_DeleteAnswer";
			this.btn_DeleteAnswer.Size = new System.Drawing.Size(89, 23);
			this.btn_DeleteAnswer.TabIndex = 3;
			this.btn_DeleteAnswer.Text = "Удалить";
			this.btn_DeleteAnswer.UseVisualStyleBackColor = true;
			// 
			// lbl_TrueAnswer
			// 
			this.lbl_TrueAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_TrueAnswer.AutoSize = true;
			this.lbl_TrueAnswer.Location = new System.Drawing.Point(6, 235);
			this.lbl_TrueAnswer.Name = "lbl_TrueAnswer";
			this.lbl_TrueAnswer.Size = new System.Drawing.Size(80, 13);
			this.lbl_TrueAnswer.TabIndex = 2;
			this.lbl_TrueAnswer.Text = "Верный ответ:";
			// 
			// tb_TrueAnswer
			// 
			this.tb_TrueAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_TrueAnswer.Location = new System.Drawing.Point(6, 251);
			this.tb_TrueAnswer.Name = "tb_TrueAnswer";
			this.tb_TrueAnswer.Size = new System.Drawing.Size(188, 20);
			this.tb_TrueAnswer.TabIndex = 1;
			// 
			// btn_Done
			// 
			this.btn_Done.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Done.Location = new System.Drawing.Point(15, 406);
			this.btn_Done.Name = "btn_Done";
			this.btn_Done.Size = new System.Drawing.Size(197, 23);
			this.btn_Done.TabIndex = 4;
			this.btn_Done.Text = "Применить";
			this.btn_Done.UseVisualStyleBackColor = true;
			// 
			// ModifyQuestion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 441);
			this.Controls.Add(this.btn_Done);
			this.Controls.Add(this.gb_Variants);
			this.Controls.Add(this.gb_TextQuestion);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(240, 480);
			this.Name = "ModifyQuestion";
			this.ShowIcon = false;
			this.Text = "Вопрос";
			this.gb_TextQuestion.ResumeLayout(false);
			this.gb_TextQuestion.PerformLayout();
			this.gb_Variants.ResumeLayout(false);
			this.gb_Variants.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox list_Answers;
		private System.Windows.Forms.TextBox tb_TextQuestion;
		private System.Windows.Forms.GroupBox gb_TextQuestion;
		private System.Windows.Forms.GroupBox gb_Variants;
		private System.Windows.Forms.TextBox tb_InputAnswer;
		private System.Windows.Forms.Button btn_AddAnswer;
		private System.Windows.Forms.Button btn_DeleteAnswer;
		private System.Windows.Forms.Label lbl_TrueAnswer;
		private System.Windows.Forms.TextBox tb_TrueAnswer;
		private System.Windows.Forms.Button btn_Done;
		private System.Windows.Forms.ToolTip ttip_ShowMessage;
	}
}