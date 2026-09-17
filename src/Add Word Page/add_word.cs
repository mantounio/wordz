using wordz.src.dbContext;
using wordz.src.Repository;
using wordz.src.words;

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
            /* var wordrepository = new WordsRepository();//
             var wordservice = new WordService.WordService(wordrepository);*/
            Util.Page_BackWard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var wordrepository = new WordsRepository(Util.db);//
            var wordservice = new WordService.WordService(wordrepository);
            
            Word word1 = new words.Word
            {
                entry = "hello",
                meaning = "salam",
                addedTime = DateTime.Now,
                lang = Langs.ENGLISH
            };
            Util.db.Database.EnsureCreatedAsync();

            Util.db.words.Add(word1);
            Util.db.SaveChanges();

        }
    }
}
