﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGDeckCreator
{
    class Deck
    {
        public List<Card> CardsList { get; set; }

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

            foreach (Card card in CardsList)
                list[card.calculateCMC()] +=1;

            return list;
        }

        private int calculateOthersCount()
        {
            int i =0;
            foreach (Card card in CardsList)
            {
                if (card.Types.Contains("Instant") || card.Types.Contains("Sorcery"))
                    i++;
            }
            return i;
        }

        public int calculateCreatureCount()
        {
            int i = 0;
            foreach (Card card in CardsList)
            {
                if (card.Types.Contains("Creature") )
                    i++;
            }
            return i;
        }

        public int calculateLandCount()
        {
            int i = 0;
            foreach (Card card in CardsList)
            {
                if (card.Types.Contains("Land") )
                    i++;
            }
            return i;
        }

    }
}