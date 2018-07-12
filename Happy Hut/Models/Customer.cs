using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Happy_Hut.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustommerPhone { get; set; }
        public decimal LargestBill { get; set; }

        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }


    }
}