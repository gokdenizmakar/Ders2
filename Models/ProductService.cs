namespace Ders2.Models
{
    public class ProductService
    {
        public static List<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product(1, "Tavuk", 80, new Category(1, "Et&Tavuk")));
            products.Add(new Product(2, "Kola", 37, new Category(2, "Icecek")));
            products.Add(new Product(3, "Fanta", 34, new Category(2, "Icecek")));
            products.Add(new Product(4, "Karpuz", 15, new Category(3, "Meyve")));

            return products;
        }
    }
}
