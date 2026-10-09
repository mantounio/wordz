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
            int count = Util.word_queue.Count;
            MessageBox.Show(count.ToString());

            label1.Text = Util.word_queue.Peek()._Word;
            Util.next_word(Util.service,"ENGLISH");
        }
    }
}
