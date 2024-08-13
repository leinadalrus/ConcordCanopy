using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ConcordCanopy.Server.Models;

namespace ConcordCanopy.Server.Controllers
{
    public class ArticleController : ControllerBase
    {
        Article article = new Article(0,
            "Lorem Ipsum",
            "Lorem ipsum odor amet, consectetuer adipiscing elit.",
            "Cicero");
        // GET: ArticleController

        // GET: ArticleController/Details/5

        // GET: ArticleController/Create

        // POST: ArticleController/Create

        // GET: ArticleController/Edit/5

        // POST: ArticleController/Edit/5

        // POST: ArticleController/Delete/5
    }
}
