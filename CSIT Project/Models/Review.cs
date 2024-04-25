namespace CSIT_Project.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }

        public int RestaurantID { get; set; }

        public int DriverId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime Created { get; set; }

        public virtual User User { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual DeliveryDriver DeliveryDriver { get; set; }
    }
}
