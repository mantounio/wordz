// make this UI 
using System.Diagnostics;

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
                    , false);
            }
            else
                Util.CreatePage(Page_OPT.TAKEQUIZ, Util.control_container);
        }
         
    }
}
