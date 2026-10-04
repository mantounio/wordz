using Microsoft.EntityFrameworkCore;
using wordz.src.words;

namespace wordz.src.Repository
{
    internal class WordsRepository : IRepository
    {
        private readonly DbContext _context;

        public WordsRepository(DbContext context) => _context = context;

        public async void Add(Word word)
        { 
           /* if(await _context.Set<Word>().AnyAsync(i => i.Id == word.Id || i._Word == word._Word || i.Meaning == word.Meaning))
            {

            }*/
            _context.Database.EnsureCreated();
            await _context.Set<Word>().AddAsync(word);
            await _context.SaveChangesAsync();
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
