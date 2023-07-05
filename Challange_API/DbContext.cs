using Challange_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challange_API
{
    public class ShipmentContext : DbContext
    {
        public ShipmentContext(DbContextOptions<ShipmentContext> options) : base(options)
        {
        }


        public DbSet<Shipper> Shippers { get; set; }

        public DbSet<ShipperShipmentDetails> Shipper_Shipment_Details { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipper>().ToTable("SHIPPER", schema: "dbo");
        }

    }

}
