using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SLACalculation.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SLACalculation.Helper.Enums;

namespace SLACalculation.Controllers
{
    public class CustomerController : Controller
    {
        private readonly SLACalcContext _context;

        public CustomerController(SLACalcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("save")]
        public async Task<IActionResult> Save()
        {
            var customers = GetMockCustomer();

            foreach (var customer in customers)
            {
                await Save(customer);
            }

            return View();
        }

        private static IList<Customer> GetMockCustomer()
        {
            var customerList = new List<Customer>
            {
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Emre Durmayaz",
                    Phone = "0-50-123 1222",
                    Segment = CustomerSegment.Vip
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Ali Veli",
                    Phone = "0-50-124 5421",
                    Segment = CustomerSegment.MassRetail
                }
            };

            return customerList;
        }

        private async Task<bool> Save(Customer model)
        {
            await _context.AddAsync(model);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
