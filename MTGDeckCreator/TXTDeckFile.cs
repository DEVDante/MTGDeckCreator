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
