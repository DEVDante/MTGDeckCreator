﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGDeckCreator
{
    class Deck
    {
        public List<Tuple<int, SpellCard>> CardsList { get; set; }

        public int CreatureCards 
        {
            get { return calculateCreatureCount();} 
        }

        public int CardsCount
        {
            get { return CardsList.Count; }
        }

        public List<int> calculateManaCurve()
        {
            List<int> list = new List<int>();

            foreach (Tuple<int, SpellCard> card in CardsList)
                list[card.Item2.calculateCMC()] +=1;

            return list;
        }

        private int calculateOthersCount()
        {
            int i =0;
            foreach (Tuple<int, SpellCard> card in CardsList)
            {
                if (!card.Item2.Types.Contains("Creature") && !card.Item2.Types.Contains("Land"))
                    i++;
            }
            return i;
        }

        public int calculateCreatureCount()
        {
            int i = 0;
            foreach (Tuple<int, SpellCard> card in CardsList)
            {
                if (card.Item2.Types.Contains("Creature") )
                    i++;
            }
            return i;
        }

        public int calculateLandCount()
        {
            int i = 0;
            foreach (Tuple<int, SpellCard> card in CardsList)
            {
                if (card.Item2.Types.Contains("Land") )
                    i++;
            }
            return i;
        }

    }
}
