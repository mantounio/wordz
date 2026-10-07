// make this UI 
namespace wordz.src
{
    public partial class ChooseLanguage : UserControl
    {
        public ChooseLanguage()
        {
            InitializeComponent();
            combo_choose_lang.Items.AddRange(Util.language_items.ToArray());
        }

        private void btn_back_Click(object sender, EventArgs e) => Util.Page_BackWard();
    }
}
