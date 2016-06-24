using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MTGDeckCreator
{
    class TXTDeckFile : DeckFile
    {
        public override Deck load()
        {
            Deck deck = new Deck();

            if (File.Exists(Filename))
            {
                var lines = File.ReadLines(Filename);

                foreach (var line in lines)
                {
                    if (line == "Sideboard")
                        break;

                    int amount = 0;
                    Int32.TryParse(line.Substring(0, line.IndexOf(' ')), out amount);
                    string cardName = line.Substring(line.IndexOf(' ') + 1);
                }
            }

            return deck;
        }

        public override void save()
        {
            throw new NotImplementedException();
        }
    }
}
