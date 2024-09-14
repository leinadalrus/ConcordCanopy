using ConcordCanopy.Server.Data;
using ConcordCanopy.Server.Models;
using ConcordCanopy.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConcordCanopy.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {
        readonly CardData _cardData;

        public CardController(CardData cardData)
        {
            _cardData = cardData;
        }

        [HttpGet("{id}")]
        public IEnumerable<Card> Index(int id)
        {
            var index = CardService.Get(id);

            if (index is null)
                Console.WriteLine("An error has occurred. Index has returned null.");

            return _cardData.Cards.ToList<Card>();
        }
    }
}
