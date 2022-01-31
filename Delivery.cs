using System.ComponentModel.DataAnnotations;

namespace RazorPageDeliveryPersonPersp.models
{
    public class DeliveryWindow
    {
        public int DeliveryID { get; set; }

        public int CustomerID { get; set; }

        public string CustomerAddress { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public string DeliveryTimeWindow { get; set; } = string.Empty;
    }
}