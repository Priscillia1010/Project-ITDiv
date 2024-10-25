using Microsoft.AspNetCore.Mvc;
using RentalCar.Data;
using RentalCar.Models;
using System.Linq;
namespace RentalCar.Controllers
{
    public class AuthController : Controller
    {
        private readonly RentalCarDbContext _context;

        public AuthController(RentalCarDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var customer = _context.MsCustomers
                .FirstOrDefault(c => c.customer_name == username && c.customer_password == password);
            
            if(customer != null)
            {
                HttpContext.Session.SetString("customer_name", customer.customer_name);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Username atau password salah";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string username, string email, string password, string rePassword, string phone, string alamat)
        {
            if(password != rePassword)
            {
                ViewBag.ErrorMessage = "Password tidak cocok";
                return View();
            }

            var newCustomer = new MsCustomer
            {
                customer_name = username,
                customer_email = email,
                customer_password = password,
                customer_phone_number = phone,
                customer_address = alamat,
            };

            _context.MsCustomers.Add(newCustomer);
            _context.SaveChanges();

            return RedirectToAction("Login", "Auth");
        }
    }
}
