using HostelReservation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Context.Configration
{
    public class RoomConfigration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            //builder.HasOne(r => r.Hotel)
            //     .WithMany()
            //     .HasForeignKey(r => r.HotelID)
            //     .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
