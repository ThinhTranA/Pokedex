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
        public bool AboutSelected { get; set; } = true;
        public bool BaseStatsSelected { get; set; }
        public bool EvolutionSelected { get; set; }
        public bool MovesSelected { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand AboutCommand => new Command(SetAbout);
        public ICommand BaseStatsCommand => new Command(SetBaseStats);
        public ICommand EvolutionCommand => new Command(SetEvolution);
        public ICommand MovesCommand => new Command(SetMoves);

        public PokemonDetailsViewModel()
        {
            
        }

        public PokemonDetailsViewModel(PokemonModel pokemonModel)
        {
            PokemonModel = pokemonModel;
            BackCommand = new Command(() => { Application.Current.MainPage.Navigation.PopModalAsync();});
        }
        private void SetAbout()
        {
            AboutSelected = true;
            BaseStatsSelected = false;
            EvolutionSelected = false;
            MovesSelected = false;
        }
        private void SetBaseStats()
        {
            AboutSelected = false;
            BaseStatsSelected = true;
            EvolutionSelected = false;
            MovesSelected = false;
        }
        private void SetEvolution()
        {
            AboutSelected = false;
            BaseStatsSelected = false;
            EvolutionSelected = true;
            MovesSelected = false;
        }
        private void SetMoves()
        {
            AboutSelected = false;
            BaseStatsSelected = false;
            EvolutionSelected = false;
            MovesSelected = true;
        }
    }
}
