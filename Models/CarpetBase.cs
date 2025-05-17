namespace SoliAntique.Models
{
    public class CarpetBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Dimensions { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public List<CarpetImage> Images { get; set; }
    }
}
