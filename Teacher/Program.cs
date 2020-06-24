using Base.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			string path_db = "";
			string setting = "settings.dat";

			try
			{
				path_db = File.ReadAllLines(setting)[0];
			} catch( Exception ) {
				MessageBox.Show("Выберите путь к файлу базы данных", "Ошибка", MessageBoxButtons.OK);

				OpenFileDialog op = new OpenFileDialog();
				op.Filter = "All files (*.*)|*.*";
				if( op.ShowDialog() == DialogResult.OK ) {
					File.WriteAllLines(setting, new string[]{ op.FileName });
					path_db = op.FileName;
				} 
			}

			if ( !String.IsNullOrEmpty(path_db) )
			{
				IDataManager d  = new TeacherData(path_db);
				MainWindow test = new MainWindow(d);
				test.PathSettingsFile = setting;

				Application.Run(test);
			} else {
				MessageBox.Show("Приложение не может работать без базы данных", "Ошибка", MessageBoxButtons.OK);
			}
		}
	}
}
