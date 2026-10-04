using wordz.src.Repository;
using wordz.src.words;
using static Page_OPT;
using static Langs;


namespace wordz.src.add_word
{
    public partial class Add_word : UserControl
    {
        public bool validate(Word w) // (refactor this later!!!!!!!
                                     // find a better solution for this is a bad approach!!!)
        {
            bool err = false;

            // write tests for every combination of words
            string msg = string.Empty;
            if (string.IsNullOrWhiteSpace(w._Word) &&
                string.IsNullOrWhiteSpace(w.Meaning) &&
                w.Lang == EMPTY)
            {
                msg = "Please fill in all required fields!";
                err = true;
            }

            else if (string.IsNullOrWhiteSpace(w._Word) &&
                string.IsNullOrWhiteSpace(w.Meaning))
            {
                msg = "Please enter a word and its meaning!";
                err = true;
            }

            else if (string.IsNullOrWhiteSpace(w._Word) &&
                 w.Lang == EMPTY)
            {
                msg = "Please enter a word and select its language!";
                err = true;
            }
            else if (string.IsNullOrWhiteSpace(w.Meaning) &&
                w.Lang == EMPTY)
            {
                msg = "Please enter a meaning and select its language!";
                err = true;
            }

            else if (string.IsNullOrWhiteSpace(w._Word))
            {
                msg = "Please fill the word you want to add!";
                err = true;
            }

            else if (string.IsNullOrWhiteSpace(w.Meaning))
            {
                msg = "Please fill a meaning for this word!";
                err = true;
            }

            else if (w.Lang == EMPTY)
            {
                msg = "Please select the language of this word!";
                err = true;
            }

            if (err)
            {
                 // make this 3 line of code a single method
                foreach (var control in Util.arr_controls)
                {
                    control.BackColor = Color.FromArgb(230, 0, 0);
                }
                Util.isErrorPageVisible = true;

                Util.CreatePage(ERROR, Util.control_container);

                Util.set_error($"Can't add the word \n{msg}");
            }

            return err;
        }
        public Add_word()
        {
            InitializeComponent();
            combo_lang.Items.AddRange(Util.language_items.ToArray());
            combo_lang.SelectedIndex = 0;
        }
        // events

        private void button3_Click(object sender, EventArgs e) => Util.Page_BackWard();

        private void materialButton1_Click(object sender, EventArgs e)
        {
            IRepository repository = new WordsRepository(Util.db);
            WordService.WordService service = new(repository);

            Word word = new()
            {
                _Word = txt_word.Text.TrimEnd().Trim().TrimStart(),
                Meaning = txt_meaning.Text.TrimEnd().Trim().TrimStart(),
                AddedTime = DateTime.Now,
                Lang = Enum.Parse<Langs>(combo_lang.SelectedItem!.ToString()!)
            };

            if (validate(word)) return;

            service.CreateWord(word);
        }

        private void materialCard1_Click(object sender, EventArgs e) => ActiveControl = null;

        private void Add_word_Click(object sender, EventArgs e) => ActiveControl = null;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_meaning.Text = "";txt_word.Text = "";
            combo_lang.SelectedIndex = 0;
        }
    }
}
