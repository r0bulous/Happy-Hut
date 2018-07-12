using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Happy_Hut.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }   

    }
}