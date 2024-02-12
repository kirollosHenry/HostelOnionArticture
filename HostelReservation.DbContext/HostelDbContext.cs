using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelReservation.Context.Configration;
using HostelReservation.Model;
using Microsoft.EntityFrameworkCore;


namespace HostelReservation.Context
{
    public class HostelDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HostelDB;Integrated Security=True;Encrypt=false;Trust Server Certificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HostelDbContext).Assembly);
        }
    }
}
