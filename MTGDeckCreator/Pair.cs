using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGDeckCreator
{
    public class Pair<T, U>
    {
        public Pair()
        {
        }

        public Pair(int first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        private int first;

        public int First
        {
            get { return first; }
            set { if (value <= 4) first = value; }
        }
        public U Second { get; set; }
    }
}
