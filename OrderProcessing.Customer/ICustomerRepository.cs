namespace OrderProcessing.Customer
{
    public interface ICustomerRepository
    {
        public Task<List<Customer>> GetAllCustomers();
    }
}
