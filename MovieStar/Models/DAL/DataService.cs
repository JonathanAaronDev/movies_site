using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieStar.Models.DAL
{
    public class DataService
    {
        static List<Movie> movieList;
        public int Insert(Movie movie)
        {
            if (movieList == null)
                movieList = new List<Movie>();
            movieList.Add(movie);
            return 1;
        }
        public List<Movie> Get()
        {
            return movieList;
        }
      
    }
}
