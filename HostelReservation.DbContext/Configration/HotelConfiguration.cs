using HostelReservation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Context.Configration
{
    internal class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasKey(h => h.HotelID);
            builder.Property(h => h.HotelName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(h => h.HotelPhone).HasColumnType("varchar(50)").IsRequired();
            builder.Property(h => h.HotelZipCode).HasColumnType("intger").IsRequired();
        }
    }
}
