using System;
using Library.VirtualGallery.Models;
using Library.VirtualGallery.Services;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCollection = Collection.Current;
            var item1 = new Item
            {
                Title = "The Starry Night",
                Description = "The Starry Night is an oil on canvas painting by Dutch Post-Impressionist painter Vincent van Gogh.",
                ARLink = "https://www.artic.edu/artworks/1115/the-starry-night",
                YearMade = 1889,
                Id = 0
            };
            myCollection.AddOrUpdate(item1);
            myCollection?.Items?.ToList()?.ForEach(Console.WriteLine);
        }
    }
}