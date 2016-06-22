using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MTGDeckCreator
{
    class SpellCard
    {
        public string Name { get; set; }
        public string Set { get; set; }
        public string[] SuperTypes { get; set; }
        public string[] Types { get; set; }
        public string[] SubTypes { get; set; }
        public string Rarity { get; set; }
        public string RulesText { get; set; }
        public string Flavor { get; set; }
        public string Artist { get; set; }
        public int Number { get; set; }
        public int MultiverseID { get; set; }
        public string Picture { get; set; }
        public char[] ManaCost { get; set; }


        public byte calculateCMC()
        { 
            byte result = 0;

            foreach (char item in ManaCost)
            {
                if (Char.IsDigit(item))
                    result += Convert.ToByte(item);
                else
                    result += 1;
            }

            return result;
        }

        public SpellCard(string name, string set, string[] supertypes, string[] types, string[] subtypes, string rarity, string rules, string flavor, string artist, int num, int mid, string picture, char[] mana)
        {
            Name = name;
            Set = set;
            SuperTypes = supertypes;
            Types = types;
            SubTypes = subtypes;
            Rarity = rarity;
            RulesText = rules;
            Flavor = flavor;
            Artist = artist;
            Number = num;
            MultiverseID = mid;
            Picture = picture;
            ManaCost = mana;
        }
    }
}
