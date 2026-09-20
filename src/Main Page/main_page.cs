using Microsoft.EntityFrameworkCore;
using wordz.src.words;
using static Page_OPT;

namespace wordz.src.Main_Page
{
    public partial class main_page : UserControl
    {
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

        private void btn_takequiz_Click(object sender, EventArgs e)
        {
            if (!Util.isTableCreated())
            {
                foreach(var control in Util.arr_controls)
                {
                    control.BackColor = Color.FromArgb(230, 0, 0);
                }
                Util.isErrorPageVisible = true;
                Util.CreatePage(ERROR, Util.control_container);
                Util.set_error("you don't have a words list to take a quiz on!\n add a word first");
            }
            else
            {
               
            }
        }
    }
}