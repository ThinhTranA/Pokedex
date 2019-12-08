using System.Collections.Generic;
using PropertyChanged;

namespace Pokedex.Models
{
    [AddINotifyPropertyChangedInterface]
    public class PokemonModel
    {
        public string DisplayName { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Types { get; set; }

        //About
        public List<string> Sprites { get; set; }
        public string Species { get; set; }
        public int Height { get; set; } //in decimetres.
        public int Weight { get; set; }    //in hectograms.
        public string Abilities { get; set; }

        //Breeding
        /// <summary>
        /// The chance of this Pokémon being female, in eighths; or -1 for
        /// genderless.
        /// </summary>
        public int GenderRate { get; set; }
        public string EggGroups { get; set; }
        public bool HasGenderDifferences { get; set; }

        //Stats
        public List<StatModel> Stats { get; set; }

        //Evolution
        public string Evolution { get; set; }

        //Moves
        public List<MoveModel> Moves { get; set; }

    }
}
