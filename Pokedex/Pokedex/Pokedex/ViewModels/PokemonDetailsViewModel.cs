using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Pokedex.Models;
using PropertyChanged;
using Xamarin.Forms;

namespace Pokedex.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class PokemonDetailsViewModel
    {
        public PokemonModel PokemonModel { get; set; }
        public ICommand BackCommand { get; set; }
        public PokemonDetailsViewModel(PokemonModel pokemonModel)
        {
            PokemonModel = pokemonModel;
            BackCommand = new Command(() => { Application.Current.MainPage.Navigation.PopModalAsync();});
        }
    }
}
