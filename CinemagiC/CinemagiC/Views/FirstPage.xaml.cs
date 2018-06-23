using CinemagiC.Models;
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
	public partial class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie() { title = "Film1", imagepath = "https://image.tmdb.org/t/p/w200/ePyN2nX9t8SOl70eRW47Q29zUFO.jpg" });
            filmListView.ItemsSource = movies;
        }
    }
}