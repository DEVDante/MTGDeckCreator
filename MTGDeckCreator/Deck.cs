using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGDeckCreator
{
    class Deck
    {
        public List<Pair<int, SpellCard>> CardsList { get; set; }

        public Deck()
        {
            CardsList = new List<Pair<int, SpellCard>>();
        }

        public Pair<int, SpellCard> this[int i]
        {
            get { return CardsList[i]; }
        }

        public void addCard(SpellCard card)
        {
            if(!countUpgrade(card))
                CardsList.Add(new Pair<int,SpellCard>(1,card));
        }

        private bool countUpgrade(SpellCard card)
        {
            foreach(Pair < int, SpellCard > pair in CardsList)
             if (pair.Second == card)
            {
                pair.First++;
                return true;
            }
            return false;
        }

        public void deleteCard(SpellCard card)
        {
            for (int i = 0; i < CardsList.Count; i++)
                if (CardsList[i].Second == card)
                    if(CardsList[i].First > 1)
                        CardsList[i].First--;
                    else
                        CardsList.RemoveAt(i);
        }

        public int CardsCount
        {
            get
            {
                int n = 0;
                foreach (Pair<int, SpellCard> item in CardsList)
                    n += item.First;
                return n;
            }
        }

        public List<int> calculateManaCurve()
        {
            List<int> list = new List<int>();
            int maxCMC = 0;

            foreach (Pair<int, SpellCard> card in CardsList)
                if(card.Second.calculateCMC()>maxCMC)
                    maxCMC = card.Second.calculateCMC();

            for (int i = 0; i < maxCMC + 1; i++)
                list.Add(0);

            foreach (Pair<int, SpellCard> card in CardsList)
                list[card.Second.calculateCMC()] +=1;
            return list;
        }

        public int calculateOtherCount()
        {
            int i = 0;
            foreach (Pair< int, SpellCard> card in CardsList)
                if (!card.Second.Types.Contains("Creature") && !card.Second.Types.Contains("Land"))
                    i+=card.First;
            return i;
        }

        public int calculateCreatureCount()
        {
            int i = 0;
            foreach (Pair< int, SpellCard> card in CardsList)
                if (card.Second.Types.Contains("Creature") )
                    i+=card.First;
            return i;
        }

        public int calculateLandCount()
        {
            int i = 0;
            foreach (Pair<int, SpellCard> card in CardsList)
                if (card.Second.Types.Contains("Land") )
                    i+=card.First;
            return i;
        }
    }
}