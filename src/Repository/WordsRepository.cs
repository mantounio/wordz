using Microsoft.EntityFrameworkCore;
using wordz.src.words;

namespace wordz.src.Repository
{
    internal class WordsRepository : IRepository
    {
        private readonly DbContext _context;

        public WordsRepository(DbContext context) => _context = context;

        public void Add(Word word)
        {
            _context.Set<Word>().Add(word);
            _context.SaveChanges();
        }

        public void Delete(Word word)
        {
            _context.Set<Word>().Remove(word);
            _context.SaveChanges();
        }

        public IEnumerable<Word> GetAll()
        {
            return _context.Set<Word>().ToList();
        }

        public Word GetById(int id)
        {
            return _context.Set<Word>().Find(id)!;
        }

        public void Update(Word word)
        {
            _context.Set<Word>().Update(word);
            _context.SaveChanges();
        }
    }
}
