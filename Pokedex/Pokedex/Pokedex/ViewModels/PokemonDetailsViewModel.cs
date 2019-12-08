using System;
using System.Collections.Generic;
using System.Text;
using Pokedex.Models;
using PropertyChanged;

namespace Pokedex.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class PokemonDetailsViewModel
    {
        public PokemonModel PokemonModel { get; set; }
        public PokemonDetailsViewModel(PokemonModel pokemonModel)
        {
            PokemonModel = pokemonModel;
        }
    }
}
