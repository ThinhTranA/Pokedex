﻿using System.Collections.Generic;
using System.Linq;
using PropertyChanged;
using Xamarin.Forms;

namespace Pokedex.Models
{
    [AddINotifyPropertyChangedInterface]
    public class PokemonModel
    {
        public string DisplayName { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Types { get; set; }

        public Color TypeColor { get; set; }

    //        < Color x:Key="GreenColor">#4FC1A6</Color>
    //<Color x:Key="OrangeColor">#F7776A</Color>
    //<Color x:Key="BlueColor">#58AAF6</Color>

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
        public int TotalBaseStat => Stats.Select(x => x.BaseStat).Sum();
        public double TotalProgressBaseStat =>((double) TotalBaseStat / (Stats.Count * 120));

        //Evolution
        public string Evolution { get; set; }

        //Moves
        public List<MoveModel> Moves { get; set; }

    }
}
