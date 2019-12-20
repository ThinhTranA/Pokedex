using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Models
{
    public class StatModel
    {
        public string StatName { get; set; }
        public int BaseStat { get; set; }

        public double BaseStatProgress => ((double) BaseStat / 120);
        
    }
}
