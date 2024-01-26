namespace HandlingDb.Components
{
    public partial class Customer
    {
        public Customer CustomerModel { get; set; } = new Customer();

        public List<Customer> Customers { get; set; }


        public void HandleValidSubmit()
        {

        }
        public Customer()
        {
            Customers = new List<Customer>();
        }
        public void AddCustomer(Customer customer)
        {

        }
    }
}
