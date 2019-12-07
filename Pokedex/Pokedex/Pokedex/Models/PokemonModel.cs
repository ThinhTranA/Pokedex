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
    }
}
