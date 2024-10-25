namespace RentalCar.Models
{
    public class TrPayment
    {
        public string payment_id { get; set; }
        public DateTime payment_date { get; set; }
        public decimal amount { get; set; }
        public string payment_method {  get; set; }
        public string rental_id { get; set; }
        public TrRental TrRental { get; set; }
    }
}
