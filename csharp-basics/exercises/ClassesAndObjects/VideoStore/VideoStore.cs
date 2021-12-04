using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        List<Video> videosInStore = new List<Video>();

        public VideoStore(){}

        public void AddVideo(string title)
        {
            videosInStore.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            foreach (Video video in videosInStore)
            {
                if (video.Title == title) { video.BeingCheckedOut(); return; }
            }

            Console.WriteLine("Video not found");
        }

        public void ReturnVideo(string title)
        {
            foreach (Video video in videosInStore)
            {
                if (video.Title == title) { video.BeingReturned(); return; }
            }

            Console.WriteLine("Video not found");
        }

        public void TakeUsersRating(double rating, string title)
        {
            foreach (Video video in videosInStore)
            {
                if (video.Title == title) { video.ReceivingRating(rating); return; }
            }

            Console.WriteLine("Video not found");
        }

        public void ListInventory()
        {
            foreach (Video video in videosInStore)
            {
                if (video.Available())
                {
                    Console.WriteLine("Video name: {0}, average rating: {1}, is available", video.Title, video.AverageRating());
                }
            }
        }
    }
}
