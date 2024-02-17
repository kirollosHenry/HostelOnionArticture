﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HostelReservation.Model;

namespace HostelReservation.Context.Configration
{
    internal class AuthorizationConfigration : IEntityTypeConfiguration<Authorizations>
    {
        public void Configure(EntityTypeBuilder<Authorizations> builder)
        {
            builder.HasKey(a=>a.Id);
        }
    }
}
