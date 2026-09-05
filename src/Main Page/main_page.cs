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
        public main_page()
        {
            InitializeComponent();
        }

        private void main_page_Click(object sender, EventArgs e)
        {
           
        }

        // methods
        private void OpenPage(Page_OPT op)
        {
            switch (op) 
            {
                case TAKEQUIZ:
                    // add TAKE QUIZ WINDOW LATER
                    break;
                case ADDWORD:

                    break;
                case WORDSLIST:
                    // add WORDS LIST WINDOW LATER:
                    break;
                case SETTING:
                    // add SETTING WINDOW LATER
                    break;
            }

        }
    }

}
