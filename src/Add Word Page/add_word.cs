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
        private void button2_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e) => Util.Page_BackWard();

    }
}
