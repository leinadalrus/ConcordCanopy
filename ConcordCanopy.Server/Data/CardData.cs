using ConcordCanopy.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcordCanopy.Server.Data
{
    public class CardData : DbContext
    {

        public CardData(DbContextOptions<CardData> options) : base(options)
        {
        }
        public DbSet<Card> Cards { get; set; }

        //
        // NOTE(Daniel): Overriding inherited functions proved wasteful.

    }
}
