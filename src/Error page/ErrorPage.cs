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

        private void button2_Click(object sender, EventArgs e)
        {
            Util.set_error("this is a error");
            MessageBox.Show(lbl_msg.Location.ToString());
        }
    }
}
