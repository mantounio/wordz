using wordz.src.Repository;
using wordz.src.words;

namespace wordz.WordService
{
    public class WordService
    {
        internal IRepository _repository;

        internal WordService(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Word> GetAllWords() => _repository.GetAll();
        public void CreateWord(Word word) => _repository.Add(word);
        public void UpdateWord(Word word) => _repository.Update(word);
        public void GetWordById(int id) => _repository.GetById(id);
        public void DeleteWord(int id)
        {
            var word = _repository.GetById(id);
            if(word != null)
            {
                _repository.Delete(word);
            }
        }
    }
}
