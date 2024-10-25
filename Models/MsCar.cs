namespace RentalCar.Models
{
    public class MsCar
    {
        public string car_id { get; set; }
        public string car_name { get; set; }
        public string car_model { get; set; }
        public string licence_plate { get; set; }
        public decimal price_per_day { get; set; }
        public int number_of_seats { get; set; }
        public string transmission { get; set; }
        public int car_year { get; set; }
        public bool car_status { get; set; }
        public ICollection<MsCarImage> MsCarImages { get; set; }
        public ICollection<TrRental> TrRentals { get; set; }
        
    }
}
