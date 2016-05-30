using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MTGDeckCreator
{
    abstract class Card
    {
        public string Name { get; set; }
        public string Set { get; set; }
        public string[] SuperTypes { get; set; }
        public string[] Types { get; set; }
        public string[] SubTypes { get; set; }
        public string Rarity { get; set; }
        public string Text { get; set; }
        public string Flavor { get; set; }
        public string Artist { get; set; }
        public int Number { get; set; }
        public int MultiverseID { get; set; }
        public Image Picture { get; set; }
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
    }
}
