namespace RentalCar.Models
{
    public class MsCarImage
    {
        public string image_car_id { get; set; }
        public string image_link { get; set; }
        public string car_id { get; set; }
        public MsCar MsCar { get; set; }
    }
}
