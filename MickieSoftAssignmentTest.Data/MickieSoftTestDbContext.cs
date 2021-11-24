using MickieSoftAssignmentTest.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace MickieSoftAssignmentTest.Data
{
    public class MickieSoftTestDbContext : DbContext
    {
        public MickieSoftTestDbContext(DbContextOptions<MickieSoftTestDbContext> options) : base(options)
        {

        }

        public DbSet<QrCode> qrCodes { get; set; }
        public DbSet<TimeClock> timeClock { get; set; }

        public void Seed()
        {
            var timeClockBelgium = new TimeClock
            {
                Id = 1,
                UserId = 1,
                Type = "test",
                StartTime = new DateTime(2022, 01, 19),
                EndTime = new DateTime(2022, 02, 19),
                FromLocation = "Belgium",
                ToLocation = "Sri Lanka"
            };

            var qrCodeTest = new QrCode
            {
                ProjectId = 1,
                Date = new DateTime(2021, 10, 14),
                Location = "Belgium",
                VehicleNr = 1
            };

            timeClock.Add(timeClockBelgium);
            qrCodes.Add(qrCodeTest);

            SaveChanges();
        }
    }
}
