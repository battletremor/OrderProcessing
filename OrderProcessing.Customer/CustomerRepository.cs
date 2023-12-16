using System.Runtime.CompilerServices;

namespace OrderProcessing.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> customers = new List<Customer>();
        public CustomerRepository()
        {
            customers.Add(new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Srinivas",
                LastName = "A",
                EmailAddress = "sriniabhiram@gmail.com"
            });

            customers.Add(new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Rohit",
                LastName = "Sharma",
                EmailAddress = "rohitsharma6@gmail.com"
            });
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            return Task.FromResult(customers);
        }
    }
}
