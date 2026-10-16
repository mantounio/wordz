using System.Windows.Forms.VisualStyles;
using wordz.src.Quiz;

namespace wordz.src
{
    public partial class TakeQuizPage : UserControl
    {

        public TakeQuizPage()
        {
            InitializeComponent();
            lbl_word.Text = QuizSession.questions.First().question_word;
            QuizSession.questions.Dequeue();
            lbl_word.Text = QuizSession.questions.Peek().question_word;
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
            MessageBox.Show(get_random_btn().Name);
        }

        private Button get_random_btn()
        {
            var btn = Controls.OfType<Button>();
            int val = Random.Shared.Next(1, btn.Count() + 1);

            Button rand_btn = btn.Where(i => i.Name.Contains(val.ToString())).First();

            return rand_btn;
        }

    }
}
