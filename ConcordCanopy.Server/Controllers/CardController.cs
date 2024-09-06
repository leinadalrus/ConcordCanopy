using ConcordCanopy.Server.Data;
using ConcordCanopy.Server.Models;
using ConcordCanopy.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcordCanopy.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : Controller
    {
        readonly CardData _cardData;

        public CardController(CardData cardData)
        {
            _cardData = cardData;
        }

        [HttpGet("{id}")]
        public ActionResult<Card> Index(int id)
        {
            var index = CardService.Get(id);

            if (index is null)
                return NotFound();

            return View(_cardData.Cards.ToList<Card>());
        }
    }
}
