namespace HandlingDb.Components.Pages
{
    public partial class CustomerPage
    {
        public Customer CustomerModel { get; set; } = new Customer();

        public List<Customer>? CustomerList { get; set; }


        //public CustomerPage() { }

        public void HandleValidSubmit()
        {


        }


    }
}
