using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class VideoStoreTest
    {
        public VideoStoreTest()
        {
            VideoStore videoStore = new VideoStore();
            videoStore.AddVideo("The Matrix");
            videoStore.AddVideo("Godfather II");
            videoStore.AddVideo("Star Wars Episode IV: A New Hope");

            videoStore.TakeUsersRating(10, "The Matrix");
            videoStore.TakeUsersRating(8, "The Matrix");
            videoStore.TakeUsersRating(2, "The Matrix");
            videoStore.TakeUsersRating(10, "The Matrix");

            videoStore.TakeUsersRating(5, "Godfather II");
            videoStore.TakeUsersRating(8, "Godfather II");
            videoStore.TakeUsersRating(2, "Godfather II");
            videoStore.TakeUsersRating(0, "Godfather II");

            videoStore.TakeUsersRating(5, "Star Wars Episode IV: A New Hope");
            videoStore.TakeUsersRating(7, "Star Wars Episode IV: A New Hope");
            videoStore.TakeUsersRating(8, "Star Wars Episode IV: A New Hope");
            videoStore.TakeUsersRating(10, "Star Wars Episode IV: A New Hope");

            videoStore.Checkout("The Matrix");
            videoStore.ReturnVideo("The Matrix");

            videoStore.Checkout("Godfather II");
            videoStore.ReturnVideo("Godfather II");

            videoStore.Checkout("Star Wars Episode IV: A New Hope");
            videoStore.ReturnVideo("Star Wars Episode IV: A New Hope");

            videoStore.Checkout("Godfather II");

            videoStore.ListInventory();
        }
    }
}
