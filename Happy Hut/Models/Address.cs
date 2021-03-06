﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Happy_Hut.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        public string StreetAddress { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

    }
}