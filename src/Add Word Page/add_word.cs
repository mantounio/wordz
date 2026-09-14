using wordz.src.Repository;

namespace wordz.src.add_word
{
    public partial class Add_word : UserControl
    {
        public Add_word()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // make a dbcontext 
            var wordrepository = new WordsRepository();//
            var wordservice = new WordService.WordService(wordrepository);
            Util.Page_BackWard();
        }
    }
}
