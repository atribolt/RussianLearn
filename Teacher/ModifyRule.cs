using Base.Data.Tables;
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
	public partial class ModifyRule : Form
	{
		public event Action Done;
		public int RID { get; set; }

		public Rules Rule {  
			get {
				Rules res = new Rules();

				res.ID          = RID;
				res.Access      = (chb_Access.Checked) ? 1 : 0;
				res.Name        = tb_Name.Text;
				res.Description = tb_Description.Text;

				return res;
			}
			set {
				value = value ?? new Rules();

				RID = value.ID;
				tb_Name.Text = value.Name;
				tb_Description.Text = value.Description;
				chb_Access.Checked = (value.Access != 0);
			}
		}

		ToolTip _msgTip = new ToolTip();

		public ModifyRule()
		{
			InitializeComponent();

			btn_Done.Click += (o, e) => {
				if ( String.IsNullOrEmpty(tb_Name.Text) ) {
					_msgTip.Show( "Название не может быть пустым", tb_Name, 2_000 );
					return;
				}
				if ( String.IsNullOrEmpty(tb_Description.Text) ) {
					tb_Description.Text = "Нет описания";
				}

				Done();
			};
		}
	}
}
