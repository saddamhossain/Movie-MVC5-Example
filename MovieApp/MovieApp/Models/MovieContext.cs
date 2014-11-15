using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { set; get; } 
    }
}