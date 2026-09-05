using wordz.src.add_word;
using static Page_OPT;
enum Page_OPT 
{
    TAKEQUIZ,
    ADDWORD,
    WORDSLIST,
    SETTING,
}
namespace wordz.src.Main_Page
{
    public partial class main_page : UserControl
    {
        // methods
        private void hide_all_controls()
        {
            foreach (Control control in Controls.OfType<Control>())
            {
                control.Hide();
            }
        }

        private void OpenPage(Page_OPT op)
        {
            hide_all_controls();
            Control page = null;
            switch (op)
            {
                case TAKEQUIZ:
                    // add TAKE QUIZ WINDOW LATER
                    break;
                case ADDWORD:
                    page = new Add_word()
                    {
                        Name = "addword",
                        Dock = DockStyle.Fill
                    };
                    Util.Push_window((UserControl)page);

                    break;
                case WORDSLIST:
                    // add WORDS LIST WINDOW LATER:
                    break;
                case SETTING:
                    // add SETTING WINDOW LATER
                    break;
            }
            Controls.Add(page);
        }
        public main_page()
        {
            InitializeComponent();
        }

        // main events
        private void main_page_Click(object sender, EventArgs e)
        {

        }
        private void btn_addword_Click(object sender, EventArgs e) => OpenPage(ADDWORD);



    }
        

}
