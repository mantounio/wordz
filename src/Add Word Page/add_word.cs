using MaterialSkin.Controls;
using wordz.src.dbContext;
using wordz.src.Repository;
using wordz.src.words;
using wordz.service;


namespace wordz.src.add_word
{
    public partial class Add_word : UserControl
    {
        public Add_word()
        {
            InitializeComponent();
            materialComboBox1.Items.AddRange(Util.language_items.ToArray());
        }

        private void button3_Click(object sender, EventArgs e) => Util.Page_BackWard();

        private void materialButton1_Click(object sender, EventArgs e)
        {
            IRepository repository = new WordsRepository(Util.db);
            WordService words = new(repository);

            

            words.CreateWord(new words.Word
            {
                _Word = materialTextBox1.Text.TrimEnd().Trim().TrimStart(),
                Meaning = materialTextBox2.Text.TrimEnd().Trim().TrimStart(),
                AddedTime = DateTime.Now,
                Lang = Enum.Parse<Langs>(materialComboBox1.SelectedItem!.ToString()!)
            });

            Util.db.SaveChangesAsync();


        }
    }
}
