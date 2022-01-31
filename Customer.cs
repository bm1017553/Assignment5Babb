namespace RazorPageDeliveryPersonPersp.models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerAddress { get; set; } = string.Empty;

        public decimal Tip { get; set; }
    }
}