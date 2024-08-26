using ConcordCanopy.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcordCanopy.Server.Data
{
    public class CardRepository : DbContext
    {
        public DbSet<Card> Cards { get; set; }

        public CardRepository(DbContextOptions<CardRepository> options) : base(options)
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

        internal int Max(Func<Card, Int32> value)
        {
            throw new NotImplementedException();
        }
    }
}
