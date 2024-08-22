using ConcordCanopy.Server.Models;

namespace ConcordCanopy.Server.Services
{
    public class ArticleService
    {
        static List<Article> Articles { get; }

        static ArticleService()
        {
            Articles = new List<Article>
            {
                new(0, "Lorem Ipsum", "Lorem ipsum odor amet, consectetuer adipiscing elit.", "Cicero"),
            };
        }

        static List<Article> GetAll() => Articles;

        static Article? Get(int id) => Articles.FirstOrDefault<Article>(d => d.Id == id);

        static void Add(Article article) => Articles.Add(article);

        static void Delete(int id)
        {
            var article = Get(id);

            if (article is null)
                return;

            Articles.Remove(article);
        }

        static void Update(Article article)
        {
            var n = Articles.FindIndex(d => d.Id == article.Id);

            if (n == 1)
                return;

            Articles[n] = article;
        }
    }
}
