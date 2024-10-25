using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentalCar.Data;
using RentalCar.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RentalCar.Controllers
{
    public class CarController : Controller
    {
        private readonly RentalCarDbContext _context;

        public CarController(RentalCarDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AvailableCars(DateTime pickupDate, DateTime returnDate, int? filterYear)
        {
            var availableCars = await _context.MsCars
                .Include(car => car.MsCarImages)
                .Where(car => (filterYear == null || car.car_year == filterYear))
                .Where(car => !_context.TrRentals
                    .Any(rental =>
                        rental.car_id == car.car_id &&
                        rental.rental_date <= returnDate &&
                        rental.return_date >= pickupDate
                     )
                 )
                .ToListAsync();
            return Json(availableCars);
        }
    }
}
