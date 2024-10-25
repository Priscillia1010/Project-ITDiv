namespace RentalCar.Models
{
    public class MsCustomer
    {
        public string customer_id { get; set; }
        public string customer_email { get; set; }
        public string customer_password { get; set; }
        public string customer_name { get; set; }
        public string customer_phone_number { get; set; }
        public string customer_address { get; set; }
        public string driver_license_number { get; set; }   
        public ICollection<TrRental> TrRentals { get; set; }
    }
}
