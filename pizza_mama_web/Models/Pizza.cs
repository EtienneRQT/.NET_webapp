namespace pizza_mama_web.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public bool vegetarian { get; set; }
        public string ingredients { get; set; }
    }
}