using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MvcMovie.Models;

namespace MvcMovie.DAL
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext() : base("MvcMovieContext")
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}