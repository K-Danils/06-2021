using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        string title;
        string studio;
        string rating;

        public Movie(string title, string studio, string rating)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }

        public Movie(string title, string studio)
        {
            this.title = title;
            this.studio = studio;
            rating = "PG";
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            var result = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.rating == "PG")
                {
                    result.Add(movie);
                }
            }

            return result.ToArray();
        }
    }
}
