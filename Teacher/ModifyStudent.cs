using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher
{
	using Base.Data;

	public partial class ModifyStudent : Form
	{
		public event Action Done = delegate { };

		public int SID { get; set; }

		public Student Student {
			get {
				Student res = new Student();

				res.SID        = SID;
				res.Login      = tb_Login.Text;
				res.Password   = tb_Password.Text;
				res.Name       = tb_Name.Text;
				res.Surname    = tb_Surname.Text;
				res.Patronymic = tb_Patronymic.Text;

				return res;
			}
			set {
				value = value ?? new Student();

				SID                  = value.SID; 
				tb_Login.Text        = value.Login;
				tb_Password.Text     = value.Password;
				tb_ControllPass.Text = value.Password;

				tb_Name.Text	     = value.Name;
				tb_Surname.Text      = value.Surname;
				tb_Patronymic.Text   = value.Patronymic;
			}
		}
		ToolTip _msgTip = new ToolTip();

		public ModifyStudent()
		{
			InitializeComponent();

			chb_ShowPassword.CheckedChanged += (o, e) => {
				tb_ControllPass.PasswordChar =
				tb_Password.PasswordChar     = (chb_ShowPassword.Checked) ? '\0' : '*';
			};

			btn_Done.Click += (o, e) => {
				if ( String.IsNullOrEmpty(tb_Login.Text) ) {
					ShowMessage(tb_Login, "Обязательно для заполнения");
					return;
				} 
				if ( String.IsNullOrEmpty(tb_Password.Text) ) {
					ShowMessage(tb_Password, "Обязательно для заполнения");
					return;
				} 
				if ( tb_Password.Text != tb_ControllPass.Text ) {
					ShowMessage(tb_ControllPass, "Пароли не совпадают");
					return;
				}
				 
				Done();
			};
		}

		void ShowMessage( Control c, string message, string caption = "", int dur_ms = 2000) {
			_msgTip.Show(message, c, dur_ms);
		}
	}
}
