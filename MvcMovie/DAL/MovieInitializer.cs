using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MvcMovie.Models;

namespace MvcMovie.DAL
{
    public class MovieInitializer : DropCreateDatabaseIfModelChanges<MvcMovieContext>
    {
        protected override void Seed(MvcMovieContext context)
        {
            var movies = new List<Movie>
            {
                new Movie{ID = 1050, Title = "Other Side of Heaven", ReleaseDate = DateTime.Now, Genre = "Chruch", Price = 1},
                new Movie{ID = 4022, Title = "Best Two Years", ReleaseDate = DateTime.Now, Genre = "Chruch", Price = 1},
                new Movie{ID = 4041, Title = "The RM", ReleaseDate = DateTime.Now, Genre = "Chruch", Price = 1},
                new Movie{ID = 1045, Title = "Singles Ward", ReleaseDate = DateTime.Now, Genre = "Chruch", Price = 1},
                new Movie{ID = 3141, Title = "Saints and Soldiers", ReleaseDate = DateTime.Now, Genre = "Chruch", Price = 1}
            };
            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();
        }
    }
}