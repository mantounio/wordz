using System.Windows.Forms.VisualStyles;
using wordz.src.Quiz;

namespace wordz.src
{
    public partial class TakeQuizPage : UserControl
    {
        private int old_rand_num;
        public TakeQuizPage()
        {
            InitializeComponent();
            lbl_word.Text = QuizSession.questions.First().question_word;

            for (int i = 0; i < 4; i++)
            {
               foreach(var item in QuizSession.questions.Peek().options)
               {
                    Controls[get_random_btn().Name!].Text = item;
                    QuizSession.next();
               }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuizSession.questions.Dequeue();
            lbl_word.Text = QuizSession.questions.Peek().question_word;
        }

        private void b1_Click(object sender, EventArgs e)
        {
            QuizSession.next();
            lbl_word.Text = QuizSession.questions.Peek().question_word;
        }

        private void b2_Click(object sender, EventArgs e)
        {
           
        }


        private Button get_random_btn()
        {
            var btn = Controls.OfType<Button>();
            int val = Random.Shared.Next(1, btn.Count() + 1);

            if (val == old_rand_num)
            {
                val = Random.Shared.Next(1, btn.Count() + 1);
            }

            old_rand_num = val;

            Button rand_btn = rand_btn = btn.Where(i => i.Name.Contains(val.ToString())).First();

            return rand_btn;
        }

    }
}
