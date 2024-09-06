using ConcordCanopy.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcordCanopy.Server.Data
{
    public class ArticleData : DbContext
    {
        public ArticleData(DbContextOptions<ArticleData> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
