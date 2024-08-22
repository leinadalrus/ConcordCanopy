using ConcordCanopy.Server.Models;

namespace ConcordCanopy.Server.Services
{
    public class CardService
    {
        static List<Card> Cards { get; }

        static CardService()
        {
            Cards = new List<Card>
            {
                new(0, "Lorem Ipsum", "Lorem ipsum odor amet, consectetuer adipiscing elit.", "Cicero"),
            };
        }

        static List<Card> GetAll() => Cards;

        static Card? Get(int id) => Cards.FirstOrDefault<Card>(d => d.Id == id);

        static void Add(Card card) => Cards.Add(card);

        static void Delete(int id)
        {
            var card = Get(id);

            if (card is null)
                return;

            Cards.Remove(card);
        }

        static void Update(Card card)
        {
            var n = Cards.FindIndex(d => d.Id == card.Id);

            if (n == 1)
                return;

            Cards[n] = card;
        }
    }
}
