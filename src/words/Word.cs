using System.Diagnostics.CodeAnalysis;


namespace wordz.src.words
{
    public sealed class Word()//(int guid,string word_entry,string meaning,DateTime date)
    {
        [NotNull]
        public int id { get; set; }
        [NotNull]
        public string entry{ get; set; }
        [NotNull]
        public string meaning { get; set; }
        [NotNull]
        public DateTime date { get; set; }
        public Langs language { get; set; }


    }
}
