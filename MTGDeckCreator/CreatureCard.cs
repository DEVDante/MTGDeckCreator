using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGDeckCreator
{
    class CreatureCard : SpellCard
    {
        public int Power { get; set; }
        public int Toughtness { get; set; }

        public CreatureCard(string name, string set, string[] supertypes, string[] types, string[] subtypes, string rarity, string rules, string flavor, string artist, int num, int mid, string picture, char[] mana, int pow, int tough) : base(name, set, supertypes, types, subtypes, rarity, rules, flavor, artist, num, mid, picture, mana)
        {
            Power = pow;
            Toughtness = tough;
        }
    }
}
