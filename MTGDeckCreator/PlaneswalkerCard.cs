using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGDeckCreator
{
    class PlaneswalkerCard : SpellCard
    {
        public int Loyalty { get; set; }

        public PlaneswalkerCard(string name, string set, string[] supertypes, string[] types, string[] subtypes, string rarity, string rules, string flavor, string artist, int num, int mid, string picture, char[] mana, int loyalty) : base(name, set, supertypes, types, subtypes, rarity, rules, flavor, artist, num, mid, picture, mana)
        {
            Loyalty = loyalty;
        }
    }
}
