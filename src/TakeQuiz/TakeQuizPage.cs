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
            /* int count = Util.word_queue.Count;
             MessageBox.Show(count.ToString());

             label1.Text = Util.word_queue.Peek()._Word;
             Util.next_word(Util.service,"ENGLISH");*/

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
            foreach(var item in QuizSession.questions)
            {
                MessageBox.Show($"world : {item.question_word}");
            }
        }
    }
}
