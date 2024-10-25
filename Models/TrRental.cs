namespace RentalCar.Models
{
    public class TrRental
    {
        public string rental_id { get; set; }
        public DateTime rental_date { get; set; }   
        public DateTime return_date { get; set; }   
        public decimal total_price {  get; set; }
        public bool payment_status { get; set; }
        public string customer_id { get; set; }
        public MsCustomer MsCustomer { get; set; }
        public string car_id { get; set; }
        public MsCar MsCar { get; set; }

        public ICollection<TrPayment> TrPayments { get; set; }

    }
}
