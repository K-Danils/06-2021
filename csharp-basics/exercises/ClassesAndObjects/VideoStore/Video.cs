using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private bool _isCheckedOut;
        private List<double> _ratings = new List<double>();
        public string Title { get; private set; }

        public Video(string title)
        {
            Title = title;
        }

        public void BeingCheckedOut()
        {
            _isCheckedOut = true;
        }

        public void BeingReturned()
        {
            _isCheckedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            _ratings.Add(rating);
        }

        public double AverageRating()
        {
            double sum = 0;

            foreach (double rating in _ratings)
            {
                sum += rating;
            }

            return sum/_ratings.Count;
        }

        public bool Available()
        {
            return !_isCheckedOut;
        }

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
