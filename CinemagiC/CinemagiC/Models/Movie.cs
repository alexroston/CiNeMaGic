using System;
using System.Collections.Generic;
using System.Text;

namespace CinemagiC.Models
{
    class Movie
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public string Overview { get; set; }
        public string Vote_average { get; set; }
        public string Poster_path { get; set; }
    }
}
