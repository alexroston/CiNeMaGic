using System;
using System.Collections.Generic;
using System.Text;

namespace CinemagiC.Models
{
    class Movie
    {
        public string title { get; set; }
        public string id { get; set; }
        public string overview { get; set; }
        public string vote_average { get; set; }
        public string poster_path { get; set; }
    }
}
