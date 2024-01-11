using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Messe.Datenbank.DatabaseKlassen
{
    public class Customer_Product
    {
        [Key]
        public int ConnectionID { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerID { get; set; }

        [StringLength(100)]
        public string ProductID { get; set; }

    }
}

