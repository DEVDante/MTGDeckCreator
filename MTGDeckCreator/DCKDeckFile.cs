using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MTGDeckCreator
{
    class DCKDeckFile : DeckFile
    {
        public DCKDeckFile(string name)
        {
            Filename = name;
        }

        public override List<Pair<int, string>> load()
        {
            List<Pair<int, string>> deck = new List<Pair<int, string>>();

            if (File.Exists(Filename))
            {
                var lines = File.ReadLines(Filename);

                foreach (var line in lines)
                {
                    if (line.Contains("SB:"))
                        continue;

                    int amount = 0;
                    Int32.TryParse(line.Substring(0, line.IndexOf(' ')), out amount);

                    string cardName = line.Substring(line.IndexOf(' ') + 1);
                    cardName = cardName.Substring(cardName.IndexOf(' ') + 1);

                    deck.Add(new Pair<int, string>(amount, cardName));
                }
            }

            return deck;
        }

        public override void save(ref Deck d)
        {
            List<string> decklist = new List<string>();

            if (File.Exists(Filename))
                if (MessageBox.Show("Are you sure you want to overwrite?", "Overwrite deck file", MessageBoxButtons.YesNo) == DialogResult.No) return;


            for (int i = 0; i < d.CardsCount; i++)
                decklist.Add(d[i].First.ToString() + " [" + d[i].Second.Set + ":" + d[i].Second.Number + "] " + d[i].Second.Name);

            File.WriteAllLines(Filename, decklist);
        }
    }
}
