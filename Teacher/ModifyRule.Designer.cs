namespace Teacher
{
	partial class ModifyRule
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
			this.gb_Name = new System.Windows.Forms.GroupBox();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.gb_Description = new System.Windows.Forms.GroupBox();
			this.tb_Description = new System.Windows.Forms.TextBox();
			this.btn_Done = new System.Windows.Forms.Button();
			this.chb_Access = new System.Windows.Forms.CheckBox();
			this.gb_Name.SuspendLayout();
			this.gb_Description.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_Name
			// 
			this.gb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_Name.Controls.Add(this.tb_Name);
			this.gb_Name.Location = new System.Drawing.Point(13, 13);
			this.gb_Name.Name = "gb_Name";
			this.gb_Name.Size = new System.Drawing.Size(425, 47);
			this.gb_Name.TabIndex = 0;
			this.gb_Name.TabStop = false;
			this.gb_Name.Text = "Название";
			// 
			// tb_Name
			// 
			this.tb_Name.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Name.Location = new System.Drawing.Point(3, 16);
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(419, 20);
			this.tb_Name.TabIndex = 0;
			// 
			// gb_Description
			// 
			this.gb_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_Description.Controls.Add(this.tb_Description);
			this.gb_Description.Location = new System.Drawing.Point(12, 66);
			this.gb_Description.Name = "gb_Description";
			this.gb_Description.Size = new System.Drawing.Size(426, 250);
			this.gb_Description.TabIndex = 1;
			this.gb_Description.TabStop = false;
			this.gb_Description.Text = "Подробное описание";
			// 
			// tb_Description
			// 
			this.tb_Description.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Description.Location = new System.Drawing.Point(3, 16);
			this.tb_Description.Multiline = true;
			this.tb_Description.Name = "tb_Description";
			this.tb_Description.Size = new System.Drawing.Size(420, 231);
			this.tb_Description.TabIndex = 0;
			// 
			// btn_Done
			// 
			this.btn_Done.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Done.Location = new System.Drawing.Point(12, 341);
			this.btn_Done.Name = "btn_Done";
			this.btn_Done.Size = new System.Drawing.Size(426, 23);
			this.btn_Done.TabIndex = 2;
			this.btn_Done.Text = "Готово";
			this.btn_Done.UseVisualStyleBackColor = true;
			// 
			// chb_Access
			// 
			this.chb_Access.AutoSize = true;
			this.chb_Access.Location = new System.Drawing.Point(16, 323);
			this.chb_Access.Name = "chb_Access";
			this.chb_Access.Size = new System.Drawing.Size(126, 17);
			this.chb_Access.TabIndex = 3;
			this.chb_Access.Text = "Показать ученикам";
			this.chb_Access.UseVisualStyleBackColor = true;
			// 
			// ModifyRule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 376);
			this.Controls.Add(this.chb_Access);
			this.Controls.Add(this.btn_Done);
			this.Controls.Add(this.gb_Description);
			this.Controls.Add(this.gb_Name);
			this.Name = "ModifyRule";
			this.ShowIcon = false;
			this.Text = "Редактирование правила";
			this.gb_Name.ResumeLayout(false);
			this.gb_Name.PerformLayout();
			this.gb_Description.ResumeLayout(false);
			this.gb_Description.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gb_Name;
		private System.Windows.Forms.TextBox tb_Name;
		private System.Windows.Forms.GroupBox gb_Description;
		private System.Windows.Forms.TextBox tb_Description;
		private System.Windows.Forms.Button btn_Done;
		private System.Windows.Forms.CheckBox chb_Access;
	}
}