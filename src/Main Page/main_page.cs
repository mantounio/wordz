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
            try
            {
              /*  dataGridView1.DataSource = null;
                dataGridView1.DataSource = (from i in Util.db.words
                                            select new
                                            {
                                                i._Word,
                                                i.Meaning,
                                                i.AddedTime,
                                                i.Lang
                                            }).ToList();*/
            }
            catch (Microsoft.Data.Sqlite.SqliteException)
            {
                // do nothing for now
            }
            
        }

        // main events
        private void main_page_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
        public event EventHandler dohandle;
        private void btn_addword_Click(object sender, EventArgs e) =>

            Util.CreatePage(ADDWORD, Util.control_container);

        private void btn_takequiz_Click(object sender, EventArgs e)
        {

            if (!Util.isTableCreated())
            {
                foreach (var control in Util.arr_controls)
                {
                    control.BackColor = Color.FromArgb(230, 0, 0);
                }
                Util.isErrorPageVisible = true;
                Util.CreatePage(ERROR, Util.control_container);
                Util.set_error("You need at least 10 words in your list to take a quiz. Add some more words and try again!");
            }
            else
            {

            }
        }
    }
}