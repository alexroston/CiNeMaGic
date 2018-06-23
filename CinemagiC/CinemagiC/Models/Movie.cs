using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemagiC.Models
{
    class Movie
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "overview")]
        public string Overview { get; set; }
        [JsonProperty(PropertyName = "vote_average")]
        public string VoteAverage { get; set; }
        [JsonProperty(PropertyName = "poster_path")]
        public string PosterPath { get; set; }
    }
}
