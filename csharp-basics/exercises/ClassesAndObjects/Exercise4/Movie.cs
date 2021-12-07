using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        public string Title { get; private set; }
        public string Studio { get; private set; }
        public string Rating { get; private set; }

        public Movie(string title, string studio, string rating)
        {
            Title = title;
            Studio = studio;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            Title = title;
            Studio = studio;
            Rating = "PG";
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            var result = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.Rating == "PG")
                {
                    result.Add(movie);
                }
            }

            return result.ToArray();
        }
    }
}
