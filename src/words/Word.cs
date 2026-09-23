using System.Diagnostics.CodeAnalysis;

namespace wordz.src.words
{
    public sealed class Word
    {
        public Word()
        {
            // there is nothing here...?
        }
        public Word(string Word,string Meaning,DateTime AddedTime,Langs Lang = Langs.ENGLISH)
        {
            _Word = Word;
            this.Meaning = Meaning;
            this.AddedTime = AddedTime;
            this.Lang = Lang;
        }
        
        public int Id { get; set; }
        public string _Word { get; set; }
        public string Meaning { get; set; }
        public DateTime AddedTime { get; set; }
        public Langs Lang { get; set; }
    }
}
