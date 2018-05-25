using System.Collections.Generic;

namespace eShop.UI.Models
{
    public class eShopData
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}