namespace RazorPageDeliveryPersonPersp.models
{
    public class Pay
    {
        public string DeliveryDriverName { get; set; } = string.Empty;

        public decimal PayRate { get; set; }
        public decimal TimeOnJob { get; set; }

        public decimal Tip { get; set; }
    }
}