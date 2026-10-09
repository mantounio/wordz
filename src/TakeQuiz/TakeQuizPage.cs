

namespace wordz.src
{
    public partial class TakeQuizPage : UserControl
    {
        public TakeQuizPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int queue_count = Util.word_queue.Count;

            label1.Text = Util.word_queue.Peek()._Word;
            Util.word_queue.Dequeue();

            if()
        }
    }
}
