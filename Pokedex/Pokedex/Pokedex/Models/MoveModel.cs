using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Models
{
    public class MoveModel
    {
        public string Name { get; set; }
        public int LevelLearnedAt { get; set; }
        public string Type { get; set; }
        /// <summary>
        /// The elemental type of this move.
        /// </summary>

        //public NamedApiResource<Type> Type { get; set; }
    }
}
