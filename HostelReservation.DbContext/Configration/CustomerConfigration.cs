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
    internal class CustomerConfigration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(c => c.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Phone).HasColumnType("intger").IsRequired();
            builder.Property(c => c.City).HasColumnType("varchar(50)").IsRequired();


        }
    
    }
}
