using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Persistance {
    public class CarWorkshopDbContext : DbContext 
    {
        public CarWorkshopDbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<Domain.Entities.CarWorkshop>carWorkshops { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Domain.Entities.CarWorkshop>()
                .OwnsOne(x => x.ContactDetails);
        }

    }
}
