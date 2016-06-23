﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGDeckCreator
{
    abstract class DeckFile
    {
        public string Filename { get; set; }

        abstract public Deck load();

        abstract public void save();
    }
}
