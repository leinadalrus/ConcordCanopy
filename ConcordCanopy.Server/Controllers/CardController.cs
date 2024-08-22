using Microsoft.AspNetCore.Mvc;

namespace ConcordCanopy.Server.Controllers
{
    public class CardController : ControllerBase
    {
        public CardController() { }

        [HttpGet("{id}")]
        public ActionResult<Card> Index(int id)
        {
            var index = CardService.Get(id);

            if (index is null)
                return NotFound();

            return View(_cardRepository.Cards.ToList<Card>());
        }
    }
}
