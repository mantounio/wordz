namespace wordz.src.Error_page
{
    public partial class ErrorPage : UserControl
    {
        public ErrorPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.isErrorPageVisible = false;
            Util.Page_BackWard();
        }
    }
}
