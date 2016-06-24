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

        public Pair<int, SpellCard> this[int i]
        {
            get { return cardsList[i]; }
        }

        public void addCard(SpellCard card)
        {
            foreach (Pair<int, SpellCard> pair in cardsList)
             if (pair.Second == card)
                {
                    pair.First++;
                    break;
                }
                    
            cardsList.Add(new Pair<int,SpellCard>(1,card));
        }
        
        private List<Pair<int, SpellCard>> cardsList = new List<Pair<int, SpellCard>>();

        public int CardsCount
        {
            get { return cardsList.Count; }
        }

        public List<int> calculateManaCurve()
        {
            MessageBox.Show(cardsList[0].GetType().ToString());
            List<int> list = new List<int>();
            int maxCMC = 0;

            foreach (Pair<int, SpellCard> card in CardsList)
                if(card.Second.calculateCMC()>maxCMC)
                    maxCMC = card.Second.calculateCMC();

            for (int i = 0; i < maxCMC + 1; i++)
                list.Add(0);

            foreach (Pair<int, SpellCard> card in cardsList)
                list[card.Second.calculateCMC()] +=1;

            return list;
        }

        public int calculateOtherCount()
        {
            int i =0;
            foreach (Pair< int, SpellCard> card in cardsList)
                if (!card.Second.Types.Contains("Creature") && !card.Second.Types.Contains("Land"))
                    i++;
            
            return i;
        }

        public int calculateCreatureCount()
        {
            int i = 0;
            foreach (Pair< int, SpellCard> card in cardsList)
                if (card.Second.Types.Contains("Creature") )
                    i++;
            
            return i;
        }

        public int calculateLandCount()
        {
            int i = 0;
            foreach (Pair<int, SpellCard> card in cardsList)
                if (card.Second.Types.Contains("Land") )
                    i++;
            return i;
        }

    }

    //public class Pair<T, U>
    //{
    //    public Pair()
    //    {
    //    }

    //    public Pair(T first, U second)
    //    {
    //        this.First = first;
    //        this.Second = second;
    //    }

    //    public T First { get; set; }
    //    public U Second { get; set; }
    //}
}