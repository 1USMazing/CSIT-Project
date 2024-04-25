namespace CSIT_Project.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public int UserID { get; set; }

        public int RestaurantID { get; set; }
        
        public int DriverID { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public virtual User User { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual DeliveryDriver DeliveryDriver { get; set; }



    }
}
