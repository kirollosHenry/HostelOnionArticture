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
            builder.Property(b => b.Deposit).HasColumnType("double").IsRequired();
            builder.Property(b => b.Price).HasColumnType("double").IsRequired();
            builder.Property(b => b.NumberOFDays).HasColumnType("int").IsRequired();
            builder.HasOne(b => b.Cusromer)
                 .WithMany()
                 .HasForeignKey(r => r.CustomerId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
