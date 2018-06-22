using CinemagiC.Models;
using Newtonsoft.Json;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CinemagiC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            string json = @"{
                           'name': 'Bad Boys',
                            'ReleaseDate': '1995-4-7T00:00:00',
                            'Genres': [
                                'Action',
                                'Comedy'
                              ]
                            }";

            Movie m = JsonConvert.DeserializeObject<Movie>(json);
        }
    }
}