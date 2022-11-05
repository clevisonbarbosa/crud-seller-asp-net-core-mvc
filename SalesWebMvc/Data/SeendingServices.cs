using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enum;

namespace SalesWebMvc.Data
{
    public class SeendingServices
    {
        private SalesWebMvcContext _context;

        public SeendingServices(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Electronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Lina Brown", "lina@gmail.com", new DateTime(1994, 4, 25), 2000.0, d2);
            Seller s3 = new Seller(3, "David Brown", "david@gmail.com", new DateTime(1993, 4, 30), 3000.0, d3);
            Seller s4 = new Seller(4, "Alan Brown", "alan@gmail.com", new DateTime(1991, 4, 01), 4000.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 14), 12000.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 27), 13000.0, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 23), 14000.0, SalesStatus.Billed, s4);

            _context.Departament.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1,s2,s3,s4);
            _context.SalesRecord.AddRange(r1,r2,r3,r4);

            _context.SaveChanges();
        }
    }
}
