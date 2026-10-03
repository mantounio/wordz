

namespace wordz.src.WordsList
{
    public partial class WordsList : UserControl
    {
        public WordsList()
        {
            InitializeComponent();
            dataGridView1.DataSource = from i in Util.db.words
                                       select new
                                       {
                                           ID = i.Id,
                                           word = i._Word,
                                           meaning = i.Meaning,
                                           lang = i.Lang,
                                           date = i.AddedTime
                                       };
        }
    }
}
