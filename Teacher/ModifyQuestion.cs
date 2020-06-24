namespace Teacher {
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Data.Entity.Core.Metadata.Edm;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Windows.Forms;

	using Base.Data;

	public partial class ModifyQuestion : Form
	{
		private string WarningFiledIsEmpty = "Поле не может быть пустым";

		public event Action Done = delegate { };    // срабатывает при сохранении вопроса
												    

		public int      QID  { get; set; } = 0;     // ид вопроса
		public Question Data {                      // данные о вопросе
			get { 
				Question res = new Question();

				res.QID        = QID;
				res.Text       = tb_TextQuestion.Text;
				res.Answer     = tb_TrueAnswer.Text;
				res.BadAnswers = list_Answers.Items.Cast<string>().ToList();
				res.UserAnswer = "";

				return res;
			}
			set { 
				value = value ?? new Question();

				list_Answers.Items.Clear();

				QID                  = value.QID;
				tb_TextQuestion.Text = value.Text;
				tb_TrueAnswer.Text   = value.Answer;

				value.BadAnswers.ForEach( (x) => list_Answers.Items.Add(x) );
			} 
		}

		public ModifyQuestion() {
			InitializeComponent();

			btn_Done.Click += (o, e) => {
				if ( String.IsNullOrEmpty(tb_TextQuestion.Text) ) {
					ShowToolTip(tb_TextQuestion, "Обязательно для заполнения");
					return;
				}
				if ( list_Answers.Items.Count == 0 ) {
					ShowToolTip(list_Answers, "Обязательно для заполнения");
					return;
				}
				if ( String.IsNullOrEmpty(tb_TrueAnswer.Text)) {
					ShowToolTip(tb_TrueAnswer, "Обязательно для заполнения");
					return;
				} 

				Done();
			};

			btn_AddAnswer.Click += (o, e) => {
				if ( !String.IsNullOrEmpty(tb_InputAnswer.Text) ) {
					list_Answers.Items.Add(tb_InputAnswer.Text);
					tb_InputAnswer.Text = "";
					tb_InputAnswer.Focus();
				}
				else {
					ShowToolTip(tb_InputAnswer, WarningFiledIsEmpty);
				}
			};

			btn_DeleteAnswer.Click += (o, e) => {
				if ( list_Answers.SelectedIndex != -1 ) {
					list_Answers.Items.RemoveAt(list_Answers.SelectedIndex);
				}
				else {
					ShowToolTip(list_Answers, "Необходимо выбрать элемент");
				}
			};
		}

		void ShowToolTip (Control c, string message, string caption = "", int duration_ms = 2000) {
			ttip_ShowMessage.Show( message, c, duration_ms );
		}

	}
}
