using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemagiC.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemagiC.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FilmDetailPage : ContentPage
	{
        private Movie tappedMovie;

        public FilmDetailPage ()
		{
			InitializeComponent ();
		}

        public FilmDetailPage(Movie tappedMovie)
        {
            InitializeComponent();
            this.tappedMovie = tappedMovie;
            titleLabel.Text = tappedMovie.Title;
            descriptionLabel.Text = tappedMovie.Overview;
        }
    }
}