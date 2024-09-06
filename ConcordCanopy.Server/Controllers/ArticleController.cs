using Microsoft.AspNetCore.Mvc;

using ConcordCanopy.Server.Models;
using ConcordCanopy.Server.Data;
using ConcordCanopy.Server.Services;

namespace ConcordCanopy.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : Controller
    {
        readonly ArticleData _articleData; // NOTE(Daniel): Should initialise, but it is a "final" readonly member.
        // ArticleRepository _articleRepository = InitArticleRepositoryData(0,
        //     "Lorem Ipsum",
        //     "Lorem ipsum odor amet, consectetuer adipiscing elit.",
        //     "Cicero");

        // NOTE(Daniel): Dependency Injection/Composition
        public ArticleController(ArticleData articleData)
        {
            _articleData = articleData;
        }

        // GET: ArticleController
        [HttpGet("{id}")]
        public ActionResult<Article> Index(int id)
        {
            var index = ArticleService.Get(id);

            if (index is null)
                return NotFound();

            return View(_articleData.Articles.ToList<Article>());
        }

        [HttpGet]
        public ActionResult<List<Article>> GetAll() => ArticleService.GetAll();

        // GET: ArticleController/Details/5

        // GET: ArticleController/Create
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Article> Create(Article article)
        {
            ArticleService.Add(article);

            return CreatedAtAction(nameof(Index), new { id = article.Id }, article);
        }

        // POST: ArticleController/Create

        // GET: ArticleController/Edit/5

        // POST: ArticleController/Edit/5

        // PUT: ArticleController/Put
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Update(Article article, int id)
        {
            if (id != article.Id)
                return BadRequest();

            var existingArticle = ArticleService.Get(id);

            if (existingArticle is null)
                return NotFound();

            ArticleService.Update(article);

            return NoContent();
        }

        // POST: ArticleController/Delete/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var article = ArticleService.Get(id);

            if (article is null)
                return NotFound();

            ArticleService.Delete(id);

            return NoContent();
        }
    }
}
