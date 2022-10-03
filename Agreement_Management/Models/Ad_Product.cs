namespace Agreement_Management.Models
{
    public class Ad_Product
    {
        public string Group{get; set;}
        public string Product { get; set; }
        public DateOnly Effective_Date { get; set; }
        public DateOnly Expiration_Date { get; set; }
        public int Price { get; set; }
        public bool Active { get; set; }
    }
}
