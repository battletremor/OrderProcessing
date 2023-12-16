namespace OrderProcessing.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products = new List<Product>();
        public ProductRepository()
        {
            products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = "P0001",
                Name = "Lenovo Laptop",
                Quantity_In_Stock = 15,
                Unit_Price = 125000
            });

            products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = "P0002",
                Name = "DELL Laptop",
                Quantity_In_Stock = 25,
                Unit_Price = 135000
            });

            products.Add(new Product
            {
                Id = Guid.NewGuid(),
                Code = "P0003",
                Name = "HP Laptop",
                Quantity_In_Stock = 35,
                Unit_Price = 145000
            });
        }

        public Task<List<Product>> GetAllProducts()
        {
            return Task.FromResult(products);
        }
    }
}
