using MaterialSkin;
using src.errortype;
using wordz.src.Repository;
using wordz.src.words;
using static Page_OPT;
using static src.errortype.ErrorType;


namespace wordz.src.add_word
{
    public partial class Add_word : UserControl
    {
        public void validate(Word w)
        {
            string msg = string.Empty;
            if (string.IsNullOrWhiteSpace(w._Word))
                msg = "Please fill the word you want to add!";
            if (string.IsNullOrWhiteSpace(w.Meaning))
                msg = "Please fill a meaning for this word!";
            if (w.Lang == Langs.EMPTY)
                msg = "Please select the language of this word!";

            Util.isErrorPageVisible = true;
            Util.CreatePage(ERROR, Util.control_container);
            Util.set_error($"Can't add the word : \n{msg}");
            
        }
        public Add_word()
        {
            InitializeComponent();
            combo_lang.Items.AddRange(Util.language_items.ToArray());
        }

        // events

        private void button3_Click(object sender, EventArgs e) => Util.Page_BackWard();

        private void materialButton1_Click(object sender, EventArgs e)
        {
            IRepository repository = new WordsRepository(Util.db);
            WordService.WordService words = new(repository);

            Util.db.Database.EnsureCreated(); // move this to somewhere better

            Word word = new()
            {
                _Word = txt_word.Text.TrimEnd().Trim().TrimStart(),
                Meaning = txt_meaning.Text.TrimEnd().Trim().TrimStart(),
                AddedTime = DateTime.Now,
                Lang = Enum.Parse<Langs>(combo_lang.SelectedItem!.ToString()!)
            };

            validate(word);
        }
/*
            words.CreateWord(new words.Word
            {
                _Word = materialTextBox1.Text.TrimEnd().Trim().TrimStart(),
                Meaning = materialTextBox2.Text.TrimEnd().Trim().TrimStart(),
                AddedTime = DateTime.Now,
                Lang = Enum.Parse<Langs>(materialComboBox1.SelectedItem!.ToString()!)
            });

            Util.db.SaveChangesAsync();*/
        

        

        private void materialCard1_Click(object sender, EventArgs e) => ActiveControl = null;

        private void Add_word_Click(object sender, EventArgs e) => ActiveControl = null;

    }
}
