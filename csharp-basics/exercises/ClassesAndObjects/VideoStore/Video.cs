using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        bool isCheckedOut;
        List<double> ratings = new List<double>();
        public string Title { get; }

        public Video(string title)
        {
            this.Title = title;
        }

        public void BeingCheckedOut()
        {
            isCheckedOut = true;
        }

        public void BeingReturned()
        {
            isCheckedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            ratings.Add(rating);
        }

        public double AverageRating()
        {
            double sum = 0;

            foreach (double rating in ratings)
            {
                sum += rating;
            }

            return sum/ratings.Count;
        }

        public bool Available()
        {
            return !isCheckedOut;
        }

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
