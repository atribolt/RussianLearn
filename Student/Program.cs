namespace Student
{
	using System;
	using System.IO;
	using System.Windows.Forms;

	static class Program
	{ 
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);


			Base.Data.IDataBase data = null;
			string settings = "settings.dat";
			string path_db  = "";

			try
			{
				path_db = File.ReadAllLines(settings)[0];

				if( !File.Exists(path_db) ) throw new Exception();
			} catch (Exception) {
				MessageBox.Show("Выберите файл базы данных", "", MessageBoxButtons.OK);

				OpenFileDialog op = new OpenFileDialog();
				op.Filter = "All Files (*.*)|*.*";

				if ( op.ShowDialog() == DialogResult.OK ) {
					File.WriteAllLines( settings, new string[]{ op.FileName } );
					path_db = op.FileName;
				}
			}

			try {
				data = new Base.Data.StudentData(path_db);
				Application.Run(new IdleMasterForm(data));
			} 
			catch ( Exception )  {
				MessageBox.Show("База данных повреждена\r\nРабота программы не возможна", "Ошибка", MessageBoxButtons.OK);
				File.Create(settings);
			}
		}
	}
}
