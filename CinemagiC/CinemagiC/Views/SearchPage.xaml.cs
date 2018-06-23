using CinemagiC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemagiC.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            string filmName = searchEntry.Text;
            string json = Services.HttpRequest.HttpSearchRequester(filmName);
            Movies movies = JsonConvert.DeserializeObject<Movies>(json);
            foreach (var item in movies.results)
            {
                item.PosterPath = "https://image.tmdb.org/t/p/w200" + item.PosterPath;
            };
            filmSearchListView.ItemsSource = movies.results;
        }

        private void filmSearchListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Movie tappedMovie = (Movie)e.Item;
            Navigation.PushAsync(new FilmDetailPage(tappedMovie));
        }
    }
}