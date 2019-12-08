using PokeApiNet.Models;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Pokedex.Extensions
{
    public static class PokemonEx
    {
        public static PokemonModel ToPokemonModel(this Pokemon pokemon)
        {
            var pokemonModel = new PokemonModel
            {
                DisplayName = pokemon.Name,
                ImageUrl = pokemon.Sprites.FrontDefault,
                TypeColor = pokemon.Types.ToTypeColor(),
                Sprites = pokemon.Sprites.ToSpriteList(),
                Types = pokemon.Types.ToPokemonTypeModel(),
                Stats = pokemon.Stats.ToStatModels(),

                Species = pokemon.Species.Name,
                Height = pokemon.Height,
                Weight = pokemon.Weight,
                Abilities = pokemon.Abilities.ToAblilitesString(),

                GenderRate = 2,
                EggGroups = "egg groups",
                HasGenderDifferences = true

            };

            return pokemonModel;
        }

        public static string ToAblilitesString(this List<PokemonAbility> abilities)
        {
            var ablityString = string.Empty;
            foreach(var ab in abilities)
            {
                ablityString += $"{ab.Ability.Name}, ";
            }
            return ablityString.Substring(0, ablityString.Length - 2);
        }

        public static List<string> ToSpriteList(this PokemonSprites sprites)
        {
            var spriteList = new List<string>();
            var type = typeof(PokemonSprites);
            PropertyInfo[] properties = type.GetProperties();

            foreach(var prop in properties)
            {
                if (prop.PropertyType != typeof(string)) continue;

                var imageUrl = prop.GetValue(sprites);

                if (imageUrl == null) continue;

                spriteList.Add(imageUrl.ToString());
            }

            return spriteList;
        }

        public static List<StatModel> ToStatModels(this List<PokemonStat> pokemonStats)
        {
            var statModelList = new List<StatModel>();
            foreach(var pokeStat in pokemonStats)
            {
                statModelList.Add(pokeStat.ToStatModel());
            }
            return statModelList;
        }


        public static StatModel ToStatModel(this PokemonStat pokemonStat)
        {
            var statModel = new StatModel
            {
                StatName = pokemonStat.Stat.Name,
                BaseStat = pokemonStat.BaseStat,
            };

            return statModel;
        }
    }
}
