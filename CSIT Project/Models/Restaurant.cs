namespace CSIT_Project.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string ContactInfo { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual Address Address { get; set; }


    }
}
