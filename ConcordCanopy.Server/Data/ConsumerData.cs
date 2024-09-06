using ConcordCanopy.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcordCanopy.Server.Data
{
    public class ConsumerData : DbContext
    {
        public ConsumerData(DbContextOptions<ConsumerData> options)
            : base(options)
        {
        }

        public DbSet<Author> Consumers { get; set; }
    }
}
