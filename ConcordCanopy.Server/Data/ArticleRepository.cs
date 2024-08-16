using ConcordCanopy.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcordCanopy.Server.Data
{
    public class ArticleRepository : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public ArticleRepository(DbContextOptions<ArticleRepository> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        internal bool Any()
        {
            throw new NotImplementedException();
        }

        internal int Max()
        {
            throw new NotImplementedException();
        }

        internal int Max(Func<Article, Int32> value)
        {
            throw new NotImplementedException();
        }
    }
}
