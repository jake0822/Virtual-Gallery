namespace Library.VirtualGallery.Models
{
    public class Item
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ARLink { get; set; }
        public int Id { get; set; }
        public int YearMade { get; set; }

        public Item()
        {
            Title = string.Empty;
            Description = string.Empty;
            ARLink = string.Empty;
            YearMade = 0;
            Id = 0;
        }

        public override string ToString()
        {
            return $"[{Id}] {Title} - Made in {YearMade} - {Description} - AR Experience: {ARLink}";
        }

    }
}
