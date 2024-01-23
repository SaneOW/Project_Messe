using Project_Messe.Datenbank.DatabaseKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// CustomerDTO.cs
namespace Project_Messe.Dto
{
    public class CustomerDto
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string StreetAddress { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public byte[] Picture { get; set; }

        // Contains IDs of related products
        public List<int> ProductIds { get; set; }
    }
}



