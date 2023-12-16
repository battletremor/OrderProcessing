namespace OrderProcessing.Product
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllProducts();
    }
}
