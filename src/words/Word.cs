using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wordz.src.words
{
    [Table("words")] 
    public sealed class Word
    {
        public Word()
        {
            // there is nothing here...?
        }
      
        public Word(string Word,string Meaning,DateTime AddedTime,Langs Lang = Langs.EMPTY)
        {
            _Word = Word;
            this.Meaning = Meaning;
            this.AddedTime = AddedTime;
            this.Lang = Lang;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string _Word { get; set; }
        [Required]
        [MaxLength(100)]
        public string Meaning { get; set; }
        [Required]
        public DateTime AddedTime { get; set; }
        [Required]
        public Langs Lang { get; set; }
    }
}
