using Microsoft.EntityFrameworkCore;
using RentalCar.Models;

namespace RentalCar.Data
{
    public class RentalCarDbContext : DbContext
    {
        public RentalCarDbContext(DbContextOptions<RentalCarDbContext> options) : base(options)
        {

        }

        public DbSet<MsCar> MsCars { get; set; }
        public DbSet<MsCarImage> MsCarImages { get; set; }
        public DbSet<MsCustomer> MsCustomers { get; set; }
        public DbSet<TrRental> TrRentals { get; set; }
        public DbSet<TrPayment> TrPayments { get; set; }
    }
}
