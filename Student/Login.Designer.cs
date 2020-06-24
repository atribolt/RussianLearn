namespace Student
{
	partial class Login
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
			this.tb_UserName = new System.Windows.Forms.TextBox();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.lbl_UserName = new System.Windows.Forms.Label();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tb_UserName
			// 
			this.tb_UserName.Location = new System.Drawing.Point(62, 12);
			this.tb_UserName.Name = "tb_UserName";
			this.tb_UserName.Size = new System.Drawing.Size(234, 20);
			this.tb_UserName.TabIndex = 0;
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(62, 38);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '*';
			this.tb_Password.ShortcutsEnabled = false;
			this.tb_Password.Size = new System.Drawing.Size(234, 20);
			this.tb_Password.TabIndex = 1;
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(183, 64);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(113, 23);
			this.btn_Login.TabIndex = 2;
			this.btn_Login.Text = "Авторизоваться";
			this.btn_Login.UseVisualStyleBackColor = true;
			// 
			// lbl_UserName
			// 
			this.lbl_UserName.AutoSize = true;
			this.lbl_UserName.Location = new System.Drawing.Point(9, 15);
			this.lbl_UserName.Name = "lbl_UserName";
			this.lbl_UserName.Size = new System.Drawing.Size(38, 13);
			this.lbl_UserName.TabIndex = 4;
			this.lbl_UserName.Text = "Логин";
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(9, 41);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(45, 13);
			this.lbl_Password.TabIndex = 4;
			this.lbl_Password.Text = "Пароль";
			// 
			// btn_Exit
			// 
			this.btn_Exit.Location = new System.Drawing.Point(62, 64);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(115, 23);
			this.btn_Exit.TabIndex = 5;
			this.btn_Exit.Text = "Выход";
			this.btn_Exit.UseVisualStyleBackColor = true;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 96);
			this.Controls.Add(this.btn_Exit);
			this.Controls.Add(this.lbl_Password);
			this.Controls.Add(this.lbl_UserName);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.tb_UserName);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(324, 135);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(324, 135);
			this.Name = "Login";
			this.ShowIcon = false;
			this.Text = "Вход ученика";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_UserName;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label lbl_UserName;
		private System.Windows.Forms.Label lbl_Password;
		public System.Windows.Forms.Button btn_Exit;
		public System.Windows.Forms.Button btn_Login;
	}
}