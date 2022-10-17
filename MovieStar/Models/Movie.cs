using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStar.Models.DAL;

namespace MovieStar.Models
{
    public class Movie
    {
        //fields
        ulong movieID;
        string title;
        string overview;
        List<string> geners;
        DateTime releaseDate;
        string posterLink;
        double avgScore;

        public Movie(ulong movieID, string title, string overview, List<string> geners,
             DateTime releaseDate, string posterLink, double avgScore)
        {
            this.movieID = movieID;
            this.title = title;
            this.overview = overview;
            this.geners = geners;
            this.releaseDate = releaseDate;
            this.posterLink = posterLink;
            this.avgScore = avgScore;
        }

        public Movie()
        {
            
        }

        public ulong MovieID { get => movieID; set => movieID = value; }
        public string Title { get => title; set => title = value; }
        public string Overview { get => overview; set => overview = value; }
        public List<string> Geners { get => geners; set => geners = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string PosterLink { get => posterLink; set => posterLink = value; }
        public double AvgScore { get => avgScore; set => avgScore = value; }

        public int Insert()
        {
            DataService ds = new DataService();
            ds.Insert(this);
            return 1;
        }

        public List<Movie> Get()
        {
            DataService ds = new DataService();
            List<Movie> movielist = ds.Get();
            return movielist;
        }
    }
}