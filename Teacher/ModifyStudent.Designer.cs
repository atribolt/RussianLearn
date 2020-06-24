namespace Teacher
{
	partial class ModifyStudent
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
			this.gb_DataInput = new System.Windows.Forms.GroupBox();
			this.gb_InformationStudent = new System.Windows.Forms.GroupBox();
			this.btn_Done = new System.Windows.Forms.Button();
			this.tb_Login = new System.Windows.Forms.TextBox();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.lbl_Login = new System.Windows.Forms.Label();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.tb_ControllPass = new System.Windows.Forms.TextBox();
			this.lbl_ControllPass = new System.Windows.Forms.Label();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.lbl_Surname = new System.Windows.Forms.Label();
			this.tb_Surname = new System.Windows.Forms.TextBox();
			this.lbl_Patronymic = new System.Windows.Forms.Label();
			this.tb_Patronymic = new System.Windows.Forms.TextBox();
			this.chb_ShowPassword = new System.Windows.Forms.CheckBox();
			this.gb_DataInput.SuspendLayout();
			this.gb_InformationStudent.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_DataInput
			// 
			this.gb_DataInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_DataInput.Controls.Add(this.chb_ShowPassword);
			this.gb_DataInput.Controls.Add(this.lbl_ControllPass);
			this.gb_DataInput.Controls.Add(this.lbl_Password);
			this.gb_DataInput.Controls.Add(this.lbl_Login);
			this.gb_DataInput.Controls.Add(this.tb_ControllPass);
			this.gb_DataInput.Controls.Add(this.tb_Password);
			this.gb_DataInput.Controls.Add(this.tb_Login);
			this.gb_DataInput.Location = new System.Drawing.Point(12, 12);
			this.gb_DataInput.Name = "gb_DataInput";
			this.gb_DataInput.Size = new System.Drawing.Size(314, 125);
			this.gb_DataInput.TabIndex = 0;
			this.gb_DataInput.TabStop = false;
			this.gb_DataInput.Text = "Данные входа";
			// 
			// gb_InformationStudent
			// 
			this.gb_InformationStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_InformationStudent.Controls.Add(this.tb_Patronymic);
			this.gb_InformationStudent.Controls.Add(this.lbl_Patronymic);
			this.gb_InformationStudent.Controls.Add(this.tb_Surname);
			this.gb_InformationStudent.Controls.Add(this.lbl_Surname);
			this.gb_InformationStudent.Controls.Add(this.tb_Name);
			this.gb_InformationStudent.Controls.Add(this.lbl_Name);
			this.gb_InformationStudent.Location = new System.Drawing.Point(12, 141);
			this.gb_InformationStudent.Name = "gb_InformationStudent";
			this.gb_InformationStudent.Size = new System.Drawing.Size(314, 114);
			this.gb_InformationStudent.TabIndex = 1;
			this.gb_InformationStudent.TabStop = false;
			this.gb_InformationStudent.Text = "Информация об ученике";
			// 
			// btn_Done
			// 
			this.btn_Done.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Done.Location = new System.Drawing.Point(12, 261);
			this.btn_Done.Name = "btn_Done";
			this.btn_Done.Size = new System.Drawing.Size(314, 23);
			this.btn_Done.TabIndex = 2;
			this.btn_Done.Text = "Готово";
			this.btn_Done.UseVisualStyleBackColor = true;
			// 
			// tb_Login
			// 
			this.tb_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Login.Location = new System.Drawing.Point(112, 19);
			this.tb_Login.Name = "tb_Login";
			this.tb_Login.Size = new System.Drawing.Size(189, 20);
			this.tb_Login.TabIndex = 0;
			// 
			// tb_Password
			// 
			this.tb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Password.Location = new System.Drawing.Point(112, 45);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '*';
			this.tb_Password.Size = new System.Drawing.Size(189, 20);
			this.tb_Password.TabIndex = 0;
			// 
			// lbl_Login
			// 
			this.lbl_Login.AutoSize = true;
			this.lbl_Login.Location = new System.Drawing.Point(6, 22);
			this.lbl_Login.Name = "lbl_Login";
			this.lbl_Login.Size = new System.Drawing.Size(38, 13);
			this.lbl_Login.TabIndex = 1;
			this.lbl_Login.Text = "Логин";
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(6, 48);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(45, 13);
			this.lbl_Password.TabIndex = 1;
			this.lbl_Password.Text = "Пароль";
			// 
			// tb_ControllPass
			// 
			this.tb_ControllPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_ControllPass.Location = new System.Drawing.Point(112, 71);
			this.tb_ControllPass.Name = "tb_ControllPass";
			this.tb_ControllPass.PasswordChar = '*';
			this.tb_ControllPass.Size = new System.Drawing.Size(189, 20);
			this.tb_ControllPass.TabIndex = 0;
			// 
			// lbl_ControllPass
			// 
			this.lbl_ControllPass.AutoSize = true;
			this.lbl_ControllPass.Location = new System.Drawing.Point(6, 74);
			this.lbl_ControllPass.Name = "lbl_ControllPass";
			this.lbl_ControllPass.Size = new System.Drawing.Size(100, 13);
			this.lbl_ControllPass.TabIndex = 1;
			this.lbl_ControllPass.Text = "Повторите пароль";
			// 
			// tb_Name
			// 
			this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Name.Location = new System.Drawing.Point(112, 24);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(189, 20);
			this.tb_Name.TabIndex = 0;
			// 
			// lbl_Name
			// 
			this.lbl_Name.AutoSize = true;
			this.lbl_Name.Location = new System.Drawing.Point(6, 27);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(29, 13);
			this.lbl_Name.TabIndex = 1;
			this.lbl_Name.Text = "Имя";
			// 
			// lbl_Surname
			// 
			this.lbl_Surname.AutoSize = true;
			this.lbl_Surname.Location = new System.Drawing.Point(6, 53);
			this.lbl_Surname.Name = "lbl_Surname";
			this.lbl_Surname.Size = new System.Drawing.Size(56, 13);
			this.lbl_Surname.TabIndex = 1;
			this.lbl_Surname.Text = "Фамилия";
			// 
			// tb_Surname
			// 
			this.tb_Surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Surname.Location = new System.Drawing.Point(112, 50);
			this.tb_Surname.Name = "tb_Surname";
			this.tb_Surname.Size = new System.Drawing.Size(189, 20);
			this.tb_Surname.TabIndex = 0;
			// 
			// lbl_Patronymic
			// 
			this.lbl_Patronymic.AutoSize = true;
			this.lbl_Patronymic.Location = new System.Drawing.Point(6, 79);
			this.lbl_Patronymic.Name = "lbl_Patronymic";
			this.lbl_Patronymic.Size = new System.Drawing.Size(54, 13);
			this.lbl_Patronymic.TabIndex = 1;
			this.lbl_Patronymic.Text = "Отчество";
			// 
			// tb_Patronymic
			// 
			this.tb_Patronymic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Patronymic.Location = new System.Drawing.Point(112, 76);
			this.tb_Patronymic.Name = "tb_Patronymic";
			this.tb_Patronymic.Size = new System.Drawing.Size(189, 20);
			this.tb_Patronymic.TabIndex = 0;
			// 
			// chb_ShowPassword
			// 
			this.chb_ShowPassword.AutoSize = true;
			this.chb_ShowPassword.Location = new System.Drawing.Point(112, 98);
			this.chb_ShowPassword.Name = "chb_ShowPassword";
			this.chb_ShowPassword.Size = new System.Drawing.Size(114, 17);
			this.chb_ShowPassword.TabIndex = 2;
			this.chb_ShowPassword.Text = "Показать пароль";
			this.chb_ShowPassword.UseVisualStyleBackColor = true;
			// 
			// ModifyStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 294);
			this.Controls.Add(this.btn_Done);
			this.Controls.Add(this.gb_InformationStudent);
			this.Controls.Add(this.gb_DataInput);
			this.MinimumSize = new System.Drawing.Size(355, 333);
			this.Name = "ModifyStudent";
			this.ShowIcon = false;
			this.Text = "Редактирование ученика";
			this.gb_DataInput.ResumeLayout(false);
			this.gb_DataInput.PerformLayout();
			this.gb_InformationStudent.ResumeLayout(false);
			this.gb_InformationStudent.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gb_DataInput;
		private System.Windows.Forms.Label lbl_ControllPass;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.Label lbl_Login;
		private System.Windows.Forms.TextBox tb_ControllPass;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.TextBox tb_Login;
		private System.Windows.Forms.GroupBox gb_InformationStudent;
		private System.Windows.Forms.TextBox tb_Patronymic;
		private System.Windows.Forms.Label lbl_Patronymic;
		private System.Windows.Forms.TextBox tb_Surname;
		private System.Windows.Forms.Label lbl_Surname;
		private System.Windows.Forms.TextBox tb_Name;
		private System.Windows.Forms.Label lbl_Name;
		private System.Windows.Forms.Button btn_Done;
		private System.Windows.Forms.CheckBox chb_ShowPassword;
	}
}