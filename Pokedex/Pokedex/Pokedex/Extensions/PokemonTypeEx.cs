using PokeApiNet.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Pokedex.Extensions
{
    public static class PokemonTypeEx
    {
        public static List<string> ToPokemonTypeModel (this List<PokemonType> types)
        {
            var typeModels = new List<string>();
            foreach( var type in types)
            {
                typeModels.Add(type.Type.Name);
            }

            return typeModels;
        }

        public static Color ToTypeColor(this List<PokemonType> types )
        {
            foreach (var type in types)
            {
                switch (type.Type.Name.ToLower())
                {
                    case "grass": return Color.FromHex("#4FC1A6"); //grass green
                    case "bug": return Color.FromHex("#A8B820"); //green yellow
                    case "fire": return Color.FromHex("#F7776A"); //orange
                    case "water": return Color.FromHex("#58AAF6"); //blue
                    case "electric": return Color.FromHex("#FFCE4B"); //yellow
                    case "normal": return Color.FromHex("#A8A878"); //normal
                    case "ice": return Color.FromHex("#98D8D8"); 
                    case "psychic": return Color.FromHex("#F85888"); 
                    case "rock": return Color.FromHex("#B8A038"); 
                    case "steel": return Color.FromHex("#B8B8D0"); 
                    case "ghost": return Color.FromHex("#705898"); 
                    case "ground": return Color.FromHex("#E0C068"); 
                }
            }
            return Color.Gray;
        }
    }
}
