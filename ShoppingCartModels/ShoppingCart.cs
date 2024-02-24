// ShoppingCart.cs
using System.Collections.Generic;

namespace ShoppingCartModels
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string User { get; set; } // User's email or unique identifier
        public List<Product> Products { get; set; } = new List<Product>();

        // Other properties related to the shopping cart (if needed)
    }
}
