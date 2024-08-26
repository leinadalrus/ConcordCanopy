using ConcordCanopy.Server.Data;
using ConcordCanopy.Server.Models;
using ConcordCanopy.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcordCanopy.Server.Controllers
{
    public class CardController : Controller
    {
        readonly CardRepository _cardRepository;

        public CardController(CardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

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
