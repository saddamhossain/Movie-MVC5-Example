using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public DateTime RelaseDate { set; get; }


    }
}