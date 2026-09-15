using Microsoft.EntityFrameworkCore;
using wordz.src.words;

namespace wordz.src.dbContext
{
    public class db : DbContext
    {
        public DbSet<Word> words { get; set; }
        public db()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var currentdir = Util.current_dir;
            var file = Util.table_name;
            var path = Path.Combine(currentdir, file);

            optionsBuilder.UseSqlite($"data source = {path}");
        }

    }
}
