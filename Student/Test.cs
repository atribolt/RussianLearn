namespace Student
{ 
	using System;
	using System.Data;
	using System.Linq; 
	using System.Drawing;
	using System.Threading; 
	using System.Windows.Forms; 
	using System.Collections.Generic; 

	using Base.Data;

	public partial class Test : Form
	{
		#region Events 
		public event Action<List<TestQuestion>> EndTest = delegate { };
		public event Action                     TimeOut = delegate { };
		#endregion

		#region >>> Fields and Props 
		List<TestQuestion>     request;
		
		DateTime               time;
		System.Threading.Timer timer;
		int                    lenghtTest;

		#endregion

		#region >>> Constructors
		public Test() {
			InitializeComponent();
			 
			request = new List<TestQuestion>();
			time    = new DateTime();

			this.ControlBox = false;

			list_Question.ItemSelectionChanged += UpdateQuestionArea;
			list_Answers .SelectedIndexChanged += UpdateCurrentAnswer;
			list_Answers .SelectedIndexChanged += UpdateColor;
			btn_FinishTest.Click               += CloseTest;
			TimeOut                            += TestTimeOut;

			this.FormClosing += SendData;
			this.Shown       += Start;
		}
		 
		public Test(List<TestQuestion> questions, int minutes = 15) : this()
		{
			ResetAll();

			lenghtTest = minutes;
			SetListQuestion(questions);
		}
		#endregion

		#region >>> Methods
		void Start(object sender, EventArgs e)
		{
			time = DateTime.Now;
			time = time.AddMinutes(lenghtTest);

			TimerCallback tCall = (object obj) => {
				var t = time - DateTime.Now;
				if ( (t.Seconds | t.Minutes | t.Hours) == 0) { TimeOut(); }

				lbl_Timer.Text = string.Format("{0}:{1}:{2}", t.Hours, t.Minutes, t.Seconds);
			};

			timer = new System.Threading.Timer(tCall, null, 0, 1000);

			lbl_StartTime.Text = DateTime.Now.ToString();
		}

		void SetListQuestion(List<TestQuestion> questions) {
			request = questions;

			ListViewItem item = new ListViewItem();

			foreach (var r in request) { 
				item.Text = r.Question;
				list_Question.Items.Add( (ListViewItem)item.Clone() );
			}			
		}
		 
		void ResetAll() {
			list_Answers .Items.Clear();
			list_Question.Items.Clear();

			tb_Question   .Text = "";
			lbl_yourAnswer.Text = "";

			lbl_StartTime.Text  = "";
			lbl_Timer.Text      = "";
		}

		void FormClose(ECloseTest type)
		{ 
			if (ECloseTest.TimeOut == type)
			{
				MessageBox.Show("Время выполнения вышло", "Заврешние", MessageBoxButtons.OK);
				this.Close();
			}
			else
			{
				var res = MessageBox.Show("Вы действительно хотите завершить тест?", "Подтверждение", MessageBoxButtons.YesNo);

				switch (res)
				{
					case DialogResult.Yes:
						this.Close();
						break;
					case DialogResult.No:
						break;
					default:
						return;
				}
			}
		}
		#endregion

		#region >>> Event Handlers
		void UpdateQuestionArea(object sender, ListViewItemSelectionChangedEventArgs e) {
			tb_Question.Text = request[e.ItemIndex].Question;
			
			{
				list_Answers.Items.Clear();
				Random r = new Random();

				List<string> answ = new List<string>();
				answ.Add(request[e.ItemIndex].Answer); // добавляем верный ответ
				
				answ.AddRange(request[e.ItemIndex].AnswersBad.Select( x => x.Answer ));
				foreach (var a in answ.OrderBy(x => r.Next() )) {
					list_Answers.Items.Add(a);
				}
			}

			// устанавливаем поле выбранного и выбираем его в списке
			lbl_yourAnswer.Text        = request[e.ItemIndex].UAnswer;
			list_Answers.SelectedIndex = list_Answers.Items.IndexOf(request[e.ItemIndex].UAnswer);
		}

		void UpdateCurrentAnswer(object sender, EventArgs e) {
			try {
				int index = list_Question.SelectedIndices[0];

				lbl_yourAnswer.Text 
					= request[index].UAnswer
					= (string)list_Answers.SelectedItem;
			} catch (Exception) {}
		}

		void UpdateColor(object sender, EventArgs e) {
			for (int i = 0; i < list_Question.Items.Count; ++i) {
				Color back = (
						request[i].UAnswer != null &&
						request[i].UAnswer != ""
					) ? Color.LightGreen : Color.Transparent ;

				list_Question.Items[i].BackColor = back;
			}
		}

		void CloseTest(object sender, EventArgs e) {
			FormClose(ECloseTest.UserClose);
		}

		void SendData(object sender, FormClosingEventArgs e) {
			EndTest(request);
		}

		void TestTimeOut() {
			Action<ECloseTest> a = FormClose;
			timer.Dispose();
			Invoke(a, ECloseTest.TimeOut);
		}
		#endregion
	}

	public enum ECloseTest {
		TimeOut,
		UserClose
	}
}
