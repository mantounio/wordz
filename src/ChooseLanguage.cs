// make this UI 
using System.Diagnostics;
using wordz.src.Repository;
using wordz.src.WordService;

namespace wordz.src
{
    public partial class ChooseLanguage : UserControl
    {
        // method
        public ChooseLanguage()
        {
            InitializeComponent();
            combo_choose_lang.Items.AddRange(Util.language_items.ToArray());
            combo_choose_lang.SelectedIndex = 0;
        }

        
        // events
        private void btn_back_Click(object sender, EventArgs e) => Util.Page_BackWard();

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(combo_choose_lang.SelectedIndex == 0)
            {
                Util.show_error("Please select a language to take the quiz!"
                    ,false);
            }
            else
            {
                IRepository repo = new WordsRepository(Util.db);
                WordService.WordService service = new(repo);


                MessageBox.Show(combo_choose_lang.SelectedItem.ToString());
                Util.gen_quiz_queue(service,combo_choose_lang.SelectedItem!.ToString()!);
                Util.CreatePage(Page_OPT.TAKEQUIZ, Util.control_container);
            }
        }
    }
}
