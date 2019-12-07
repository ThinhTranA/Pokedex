using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Pokedex.Views;
using PropertyChanged;
using Xamarin.Forms;

namespace Pokedex.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class HomeViewModel
    {
        public ICommand ViewPokedexCommand { get; set; }
        public HomeViewModel()
        {
            ViewPokedexCommand = new Command(ViewPokedexHandler);
        }

        private void ViewPokedexHandler()
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new PokedexPage(), animated: false);
        }
    }
}
