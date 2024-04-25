namespace CSIT_Project.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }

        public int RestaurantID { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public string Status { get; set; }

        public virtual User User { get; set; }

        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}
