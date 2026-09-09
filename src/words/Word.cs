using System.Diagnostics.CodeAnalysis;


namespace wordz.src.words
{
    public sealed class Word
    {
        public Word()
        {
            // there is nothing here...?
        }
        public Word(string entry,string meaning,DateTime addedTime,Langs lang = Langs.ENGLISH)
        {
            this.entry = entry;
            this.meaning = meaning;
            this.addedTime = addedTime;
            this.lang = lang;
        }
        public int id { get; set; }
        public string entry { get; set; }
        public string meaning { get; set; }
        public DateTime addedTime { get; set; }
        public Langs lang { get; set; }
    }
}
