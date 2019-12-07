using PokeApiNet.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
