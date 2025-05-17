namespace SoliAntique.Models
{
    public class CartItem
        {
            public int ProductId { get; set; }
            public string Title { get; set; } = string.Empty;
            public decimal Price { get; set; }
            public string ImageUrl { get; set; } = string.Empty;
            public int Quantity { get; set; } = 1;
            public string ProductType { get; set; } = string.Empty;
        }

        
}
