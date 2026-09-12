using Microsoft.EntityFrameworkCore;
using wordz.src.words;
using static Page_OPT;

namespace wordz.src.Main_Page
{
    public partial class main_page : UserControl
    {
        // events
        public static event EventHandler ShowWindow;
        // methods
        public main_page()
        {
            InitializeComponent();
        }

        // main events
        private void main_page_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler dohandle;
        private void btn_addword_Click(object sender, EventArgs e) =>
        
            Util.CreatePage(ADDWORD, Util.control_container);
    }
}