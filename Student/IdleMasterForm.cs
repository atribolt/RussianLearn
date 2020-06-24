using System; 
using System.Windows.Forms;
using Base.Data;

namespace Student
{
	public partial class IdleMasterForm : Form
	{
		#region >>> Fields and Props
		public int       ID { get; private set; } = -1;
		public IDataBase DB { get; set; }

		Login	   login;
		MainWindow window;
		#endregion

		public IdleMasterForm(IDataBase data)
		{
			InitializeComponent();

			DB        = data;
			login     = new Login();
			window    = new MainWindow(); 
			window.DB = DB;

			login.btn_Login.Click += (object o, EventArgs e) => { 
				ID = DB.GetUID(login.UserName, login.Password);

				if ( ID == -1 ) MessageBox.Show("Неверные данные. Обратитесь к учителю", "Ошибка", MessageBoxButtons.OK);
				else {
					window.UID     = ID;
					login.Visible  = false;
					window.Visible = true;
				}
			};

			login.btn_Exit.Click += (object o, EventArgs e) => { 
				this.Close();
			};

			window.FormClosing += (object o, FormClosingEventArgs e) => {
				window.Visible = false;
				window.UID     = -1;
				window.Reset();
				e.Cancel       = true; 

				login.Reset();
				login.Visible  = true;
			};

			this.Shown += (object o, EventArgs e) => {
				this.Hide();
				login.ShowDialog();
			};
		}
	}
}
