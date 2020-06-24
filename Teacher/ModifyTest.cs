namespace Teacher
{
	using System;
	using System.Data;
	using System.Linq;
	using System.Text;
	using System.Drawing;
	using System.Windows.Forms;
	using System.ComponentModel;
	using System.Threading.Tasks;
	using System.Collections.Generic;

	using Base.Data;

	public partial class ModifyTest : Form
	{
		public event Action Done = delegate { };

		List<Question> _Questions = new List<Question>();
		ToolTip        _msgTip    = new ToolTip();

		public int  TID  { get; set; }
		public Test Test {  
			get {
				Test res = new Test();

				res.Access    = Convert.ToInt32(chb_AccessTest.Checked);
				res.Name      = tb_TestName.Text;
				res.TID       = TID;
				res.Time      = (int)num_TimeExec.Value;
				res.Questions = _Questions;

				return res;
			} 
			set {
				value = value ?? new Test();

				TID                    = value.TID;
			//	_Questions             = value.Questions;
				tb_TestName.Text       = value.Name;
				chb_AccessTest.Checked = value.Access != 0;

				tree_Questions.Nodes.Clear();
				value.Questions.ForEach((x) => AddQuestion(x));

				num_TimeExec.Value = value.Time;
			} 
		}

		public ModifyTest()
		{
			InitializeComponent();

			btn_AddQuestion.Click += (o, e) => {
				ModifyQuestion mq = new ModifyQuestion();
				mq.Done += () => { 
					AddQuestion(mq.Data); 
					mq.Close();
				};
				mq.ShowDialog();
			};

			btn_ModifyQuestion.Click += (o, e) => {
				if ( tree_Questions.SelectedNode != null ) {
					// find top level
					TreeNode top = tree_Questions.SelectedNode;
					while(top.Level != 0) { top = top.Parent; }

					// modify question
					ModifyQuestion mq = new ModifyQuestion();
					mq.Data = _Questions[top.Index];

					mq.Done += () => {
						int index = top.Index;

						_Questions[index] = mq.Data;

						top.Nodes.Clear();
						top = top.Nodes.Add(_Questions[index].Answer);
						_Questions[index].BadAnswers.ForEach((x) => top.Nodes.Add(x));

						mq.Close();
					};
					
					mq.ShowDialog();
				} else ShowMsgTip(tree_Questions, "Необходимо выбрать вопрос");
			};

			btn_DeleteQuestion.Click += (o, e) => {
				if (tree_Questions.SelectedNode != null) {
					// find top level
					TreeNode top = tree_Questions.SelectedNode;
					while (top.Level != 0) {
						top = top.Parent;
					}

					_Questions.RemoveAt(top.Index);
					tree_Questions.Nodes.RemoveAt(top.Index);
				} else ShowMsgTip(tree_Questions, "Необходимо выбрать вопрос");
			};

			btn_Done.Click += (o, e) => {
				if ( String.IsNullOrEmpty(tb_TestName.Text) ) {
					ShowMsgTip(tb_TestName, "Укажите имя теста");
					return;
				}
				if ( num_TimeExec.Value == 0 ) {
					ShowMsgTip(num_TimeExec, "Время теста не может быть 0");
					return;
				}
				if ( tree_Questions.Nodes.Count == 0 ) {
					ShowMsgTip(tree_Questions, "В тесте должны быть вопросы");
					return;
				}

				Done();
			};

			tree_Questions.AfterSelect += (o, te) => {
				if ( te.Node != null )
				{
					// find top node
					TreeNode top = te.Node;
					while (top.Level != 0) {
						top = top.Parent;
					}

					tb_Question.Text = "";

					tb_Question.Text = _Questions[top.Index].Text;
				}
			};
		}

		void AddQuestion(Question q) {
			_Questions.Add(q);

			var node = tree_Questions.Nodes.Add( q.Text ).Nodes.Add(q.Answer);
			q.BadAnswers.ForEach( (x) => node.Nodes.Add(x));
		}
		
		void ShowMsgTip(Control c, string msg, string caption = "", int duration_ms = 2000) {
			_msgTip.Show(msg, c, duration_ms);
		}
	}
}
