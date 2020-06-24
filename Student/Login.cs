 namespace Student
{
	using System.Windows.Forms; 

	public partial class Login : Form
	{  
		public string UserName {  get { return tb_UserName.Text; } }
		public string Password {  get { return tb_Password.Text; } }

		public Login() {
			InitializeComponent();
			this.ControlBox   = false;
			this.AcceptButton = btn_Login;
		}

		public void Reset() {
			tb_UserName.Text = "";
			tb_Password.Text = "";
		}
	} 
}
