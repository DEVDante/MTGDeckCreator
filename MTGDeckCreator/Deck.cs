using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGDeckCreator
{
    class Deck
    {
        public List<Pair<int, SpellCard>> CardsList { get; set; }

        public int CreatureCards
        {
            get { return calculateCreatureCount(); }
        }

        public int CardsCount
        {
            get { return CardsList.Count; }
        }

        public List<int> calculateManaCurve()
        {
            List<int> list = new List<int>();

            foreach (Pair<int, SpellCard> card in CardsList)
                list[card.Second.calculateCMC()] += 1;

            return list;
        }

        private int calculateOthersCount()
        {
            int i = 0;
            foreach (Pair<int, SpellCard> card in CardsList)
            {
                if (!card.Second.Types.Contains("Creature") && !card.Second.Types.Contains("Land"))
                    i++;
            }
            return i;
        }

        public int calculateCreatureCount()
        {
            int i = 0;
            foreach (Pair<int, SpellCard> card in CardsList)
            {
                if (card.Second.Types.Contains("Creature"))
                    i++;
            }
            return i;
        }

        public int calculateLandCount()
        {
            int i = 0;
            foreach (Pair<int, SpellCard> card in CardsList)
            {
                if (card.Second.Types.Contains("Land"))
                    i++;
            }
            return i;
        }

    }

    public class Pair<T, U>
    {
        public Pair()
        {
        }

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        public T First { get; set; }
        public U Second { get; set; }
    }
}