using PokeApiNet;
using PokeApiNet.Models;
using Pokedex.Extensions;
using Pokedex.Models;
using Pokedex.Views;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pokedex.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class PokedexViewmodel
    {
        public ObservableCollection<PokemonModel> PokemonModels { get; set; } = new ObservableCollection<PokemonModel>();
        public ICommand LoadPokemonsCommand { get; set; }
        public ICommand ViewPokemonDetailsCommand { get; set; }
        public PokedexViewmodel()
        {
            LoadPokemonsCommand = new Command(async () => await LoadPokemons());
            ViewPokemonDetailsCommand = new Command(ViewPokemonDetails);
            LoadPokemonsCommand.Execute(null);
        }

        private void ViewPokemonDetails(object selectedPokemon)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(
                new PokemonDetailsPage(new PokemonDetailsViewModel((PokemonModel)selectedPokemon))
                );
        }

        public async Task LoadPokemons()
        {
            var pokiApiClient = new PokeApiClient();

            var pokemons = new List<Pokemon>();
            
            for(var i =1; i< 101; i++)
            {
                var poke = await pokiApiClient.GetResourceAsync<Pokemon>(i);
                pokemons.Add(poke);

                var pokeModel = poke.ToPokemonModel();
                PokemonModels.Add(pokeModel);
            }

            Console.WriteLine(PokemonModels.Count);
           
        }
    }
}
