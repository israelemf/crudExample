using CRUD.Models;
using CRUD.Models.Enums;
using System;
using System.Linq;

namespace CRUD.Data
{
    public class SeedingService
    {
        private CRUDContext _context;

        public SeedingService(CRUDContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //Database Seeded
            }

            Department d1 = new Department(1, "Eletronicos");
            Department d2 = new Department(2, "Livros");
            Department d3 = new Department(3, "Computadores");
            Department d4 = new Department(4, "Fashion");
            Department d5 = new Department(5, "Perfumaria");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Bob Brown", "bob1@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s3 = new Seller(3, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s4 = new Seller(4, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s5 = new Seller(5, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s6 = new Seller(6, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s7 = new Seller(7, "Alex Pink", "pink@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);
            Seller s8 = new Seller(8, "Ze do Sabara", "ze@gmail.com", new DateTime(1970, 3, 4), 2000.0, d5);
            Seller s9 = new Seller(9, "Ze do Sabara", "ze2@gmail.com", new DateTime(1970, 3, 4), 2000.0, d5);
            Seller s10 = new Seller(10, "Ze do Sabara", "ze3@gmail.com", new DateTime(1970, 3, 4), 2000.0, d4);
            Seller s11 = new Seller(11, "Ze do Sabara", "ze4@gmail.com", new DateTime(1970, 3, 4), 2000.0, d4);
            Seller s12 = new Seller(12, "Ze do Sabara", "ze5@gmail.com", new DateTime(1970, 3, 4), 2000.0, d2);
            Seller s13 = new Seller(13, "Ze do Sabara", "ze6@gmail.com", new DateTime(1970, 3, 4), 2000.0, d5);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2021, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2021, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2021, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2021, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2021, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2021, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2021, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2021, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2021, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2021, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2021, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2021, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2021, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2021, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2021, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2021, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2021, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2021, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2021, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2021, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2021, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2021, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2021, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2021, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2021, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2021, 10, 12), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r31 = new SalesRecord(31, new DateTime(2021, 10, 12), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r32 = new SalesRecord(32, new DateTime(2021, 10, 12), 5000.0, SaleStatus.Billed, s2);
            SalesRecord r33 = new SalesRecord(33, new DateTime(2021, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r34 = new SalesRecord(34, new DateTime(2021, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r35 = new SalesRecord(35, new DateTime(2021, 10, 24), 6000.0, SaleStatus.Billed, s3);

            _context.Department.AddRange(d1, d2, d3, d4, d5);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30, 
                r31, r32, r33, r34, r35
            );

            _context.SaveChanges();
        }
    }
}
