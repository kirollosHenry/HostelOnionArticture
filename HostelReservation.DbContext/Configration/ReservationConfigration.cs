using HostelReservation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Context.Configration
{
    public class ReservationConfigration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(s => s.ReservationID);
            builder.Property(c=>c.ReservationCheckIn).HasColumnType("DateTime").IsRequired();

           
        }
    }
}
