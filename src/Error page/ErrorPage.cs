using static Page_OPT;
namespace wordz.src.Error_page
{
    public partial class ErrorPage : UserControl
    {
        public ErrorPage()
        {
            InitializeComponent();
            Util.error_lbl = lbl_msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.isErrorPageVisible = false;
            Util.Page_BackWard();

            foreach (var control in Util.arr_controls)
            {
                control.BackColor = Color.FromName("control");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.CreatePage(ADDWORD, Util.control_container);
            Util.isErrorPageVisible = false;
        }

        private void link_lbl_redirect_add_word_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.WINDPTR_POP();
            Util.change_colors(Color.FromName("control"), Util.arr_controls);
            Util.isErrorPageVisible = false;
            Util.CreatePage(ADDWORD, Util.control_container);
            
        }
    }
}
