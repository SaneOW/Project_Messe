using Project_Messe.Datenbank.DatabaseKlassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Messe.Datenbank.Context;
using Microsoft.EntityFrameworkCore;

namespace Project_Messe.Services
{
    internal class CustomerServices
    {
        public async Task<List<Customer>> GetAllCustomerDataAsync()
        {
            using (var context = new MesseDbContext())
            {
                var customers = await context.Customers
                    .Include(c => c.Products)
                    .ToListAsync();
                return customers;
            }
        }

        public async Task DeleteAllCustomersAsync()
        {
            using (var context = new MesseDbContext())
            {
                var allCustomers = await context.Customers.ToListAsync();
                context.Customers.RemoveRange(allCustomers);
                await context.SaveChangesAsync();
            }
        }
    }
}
