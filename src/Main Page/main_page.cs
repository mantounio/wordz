using wordz.src.add_word;
using static Page_OPT;

namespace wordz.src.Main_Page
{
    public partial class main_page : UserControl
    {
        // events
        public static event EventHandler ShowWindow;
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
          
        }
        public main_page()
        {
            InitializeComponent();
        }

        // main events
        private void main_page_Click(object sender, EventArgs e)
        {

        }
        private void btn_addword_Click(object sender, EventArgs e)
        {
            Util.CreatePage(ADDWORD, Util.control_container);
            ShowWindow?.Invoke(this, EventArgs.Empty);
        }
    }

}
