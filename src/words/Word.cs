namespace wordz.src.words
{
    public sealed class Word
    {
        public Word()
        {
            // there is nothing here...?
        }
        public Word(string word,string meaning,DateTime addedTime,Langs lang = Langs.ENGLISH)
        {
            this.word = word;
            this.meaning = meaning;
            this.addedTime = addedTime;
            this.lang = lang;
        }
        public int id { get; set; }
        public string word { get; set; }
        public string meaning { get; set; }
        public DateTime addedTime { get; set; }
        public Langs lang { get; set; }
    }
}
