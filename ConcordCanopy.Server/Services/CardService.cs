using ConcordCanopy.Server.Models;

namespace ConcordCanopy.Server.Services
{
    public class CardService
    {
        public static List<Card> Cards { get; }

        static CardService()
        {
            Cards = new List<Card>
            {
                new(0, "Lorem Ipsum", "Lorem ipsum odor amet, consectetuer adipiscing elit.", "Cicero"),
            };
        }

        public static List<Card> GetAll() => Cards;

        public static Card? Get(int id) => Cards.FirstOrDefault<Card>(d => d.Id == id);

        public static void Add(Card card) => Cards.Add(card);

        public static void Delete(int id)
        {
            var card = Get(id);

            if (card is null)
                return;

            Cards.Remove(card);
        }

        public static void Update(Card card)
        {
            var n = Cards.FindIndex(d => d.Id == card.Id);

            if (n == 1)
                return;

            Cards[n] = card;
        }
    }
}
