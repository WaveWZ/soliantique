namespace SoliAntique.Models
{
    public class CarpetImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public int? VintageCarpetId { get; set; }
        public VintageCarpet VintageCarpet { get; set; }

        public int? TurkishCarpetId { get; set; }
        public TurkishCarpet TurkishCarpet { get; set; }

        public int? IranianCarpetId { get; set; }
        public IranianCarpet IranianCarpet { get; set; }
    }
}
