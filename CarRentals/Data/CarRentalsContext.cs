using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentals.Models;
using CarRentalClub.Models;

    public class CarRentalsContext : DbContext
    {
        public CarRentalsContext (DbContextOptions<CarRentalsContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentals.Models.Customer> Customer { get; set; }

        public DbSet<CarRentals.Models.Reservation> Reservation { get; set; }

        public DbSet<CarRentalClub.Models.Location> Location { get; set; }

        public DbSet<CarRentals.Models.Vehicle> Vehicle { get; set; }
    }
