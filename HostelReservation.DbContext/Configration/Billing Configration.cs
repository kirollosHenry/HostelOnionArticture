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
    internal class Billing_Configration : IEntityTypeConfiguration<Billings>
    {
        
        public void Configure(EntityTypeBuilder<Billings> builder)
        {
            builder.HasKey(b => b.BillingId);
            builder.Property(b => b.Deposit).HasColumnType("decimal").IsRequired();
            builder.Property(b => b.Price).HasColumnType("decimal").IsRequired();
            builder.Property(b => b.NumberOFDays).HasColumnType("int").IsRequired();

            builder.HasOne(b => b.Customer)
                .WithMany(c => c.Billings)  // Assuming you have a navigation property in Customer class representing the relationship
                .HasForeignKey(b => b.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
