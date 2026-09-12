using wordz.src.words;

namespace wordz.src.Repository
{
    internal interface IRepository
    {
        IEnumerable<Word> GetAll();
        Word GetById(int id);
        void Add(Word word);
        void Update(Word word);
        void Delete(Word word);
    }
}
