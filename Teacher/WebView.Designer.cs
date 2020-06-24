namespace Teacher
{
	partial class WebView
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
			this.web_View = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// web_View
			// 
			this.web_View.Dock = System.Windows.Forms.DockStyle.Fill;
			this.web_View.Location = new System.Drawing.Point(0, 0);
			this.web_View.MinimumSize = new System.Drawing.Size(20, 20);
			this.web_View.Name = "web_View";
			this.web_View.Size = new System.Drawing.Size(905, 726);
			this.web_View.TabIndex = 0;
			this.web_View.Url = new System.Uri("https://dnevnik.ru/", System.UriKind.Absolute);
			// 
			// WebView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 726);
			this.Controls.Add(this.web_View);
			this.Name = "WebView";
			this.ShowIcon = false;
			this.Text = "Онлайн дневник";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser web_View;
	}
}