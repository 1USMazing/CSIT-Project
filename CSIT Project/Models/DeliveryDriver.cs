namespace CSIT_Project.Models
{
    public class DeliveryDriver
    {
        public int DriverID { get; set; }
        public string Name { get; set; }

        public string ContactInfo { get; set; }
        public string Availability { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual ICollection<DeliveryDriver> Deliverys { get; set; }

        public virtual Address Address { get; set; }

    }
}
