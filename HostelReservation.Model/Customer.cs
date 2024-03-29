﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelReservation.Model
{
    public class Customer
    {
        //
        public int ID { get; set; }
        public string Name { get; set; }
        public string? City { get; set; }
        public int Phone { get; set; }
        public ICollection<Billings> Billings { get; set; }
    }
}
