using Bogus;

namespace ASP.NET_LEARNİNG.Models
{
    public class RepositoryContext
    {
        public static List<Product> GetProducts() {
            var productFaker = new Faker<Product>()
                .RuleFor(p => p.Id, f => f.UniqueIndex)
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Stock, f => f.Random.Int(min: 0, max: 100))
                .RuleFor(p => p.Price, f => decimal.Parse(f.Commerce.Price()));

            return productFaker.Generate(40);    
            }
            
    }
    
}
