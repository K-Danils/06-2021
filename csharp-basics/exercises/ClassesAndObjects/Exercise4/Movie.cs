using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            var result = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie._rating == "PG")
                {
                    result.Add(movie);
                }
            }

            return result.ToArray();
        }
    }
}
