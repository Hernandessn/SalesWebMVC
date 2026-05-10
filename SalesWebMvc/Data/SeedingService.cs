using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has beem seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Computers");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Charlie White", "charlie@gmail.com", new DateTime(1988, 7, 15), 2200.0, d3);
            Seller s4 = new Seller(4, "Anna Purple", "anna@gmail.com", new DateTime(1993, 5, 8), 3000.0, d3);
            Seller s5 = new Seller(5, "John Black", "john@gmail.com", new DateTime(1985, 3, 19), 4000.0, d2);
            Seller s6 = new Seller(6, "Laura Red", "laura@gmail.com", new DateTime(2000, 1, 7), 1800.0, d4);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 10, 03), 7500.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 10, 07), 3200.0, SalesStatus.Canceled, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 10, 12), 9400.0, SalesStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 10, 19), 6100.0, SalesStatus.Pending, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 10, 22), 4200.0, SalesStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 11, 01), 8800.0, SalesStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 11, 05), 2100.0, SalesStatus.Canceled, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 11, 11), 5300.0, SalesStatus.Pending, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 11, 15), 13500.0, SalesStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 11, 20), 7700.0, SalesStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 11, 27), 3900.0, SalesStatus.Pending, s6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 12, 02), 6600.0, SalesStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 12, 08), 4800.0, SalesStatus.Canceled, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 12, 14), 9200.0, SalesStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 12, 19), 1500.0, SalesStatus.Pending, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 12, 23), 11200.0, SalesStatus.Billed, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 01, 04), 5500.0, SalesStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 01, 09), 3100.0, SalesStatus.Canceled, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 01, 15), 8400.0, SalesStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 01, 21), 6900.0, SalesStatus.Pending, s3);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 01, 28), 4300.0, SalesStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 02, 03), 12000.0, SalesStatus.Billed, s5);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 02, 09), 2700.0, SalesStatus.Canceled, s6);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 02, 14), 7100.0, SalesStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 02, 20), 5800.0, SalesStatus.Pending, s2);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 02, 25), 9700.0, SalesStatus.Billed, s3);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 03, 03), 3400.0, SalesStatus.Canceled, s4);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 03, 08), 10500.0, SalesStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 03, 14), 6200.0, SalesStatus.Pending, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }

    }
}
