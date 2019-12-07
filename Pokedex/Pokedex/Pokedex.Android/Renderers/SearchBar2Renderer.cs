using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Pokedex.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SearchBar), typeof(SearchBar2Renderer))]

namespace Pokedex.Droid.Renderers
{
    public class SearchBar2Renderer : SearchBarRenderer
    {
        [Obsolete]
        public SearchBar2Renderer()
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {

            base.OnElementChanged(e);

            if (Control == null || e.NewElement == null) return;

            var plateId = Resources.GetIdentifier("android:id/search_plate", null, null);
            var plate = Control.FindViewById(plateId);
            plate.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}