using MickieSoftAssignmentTest.Data;
using MickieSoftAssignmentTest.Model;
using MickieSoftAssignmentTest.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MickieSoftAssignmentTest.Services
{
    public class TimeClockService : ITimeClockService
    {
        private readonly MickieSoftTestDbContext _dbContext;

        public TimeClockService(MickieSoftTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TimeClock Get(int id)
        {
            var timeclock = _dbContext.timeClock
                .SingleOrDefault(t => t.Id == id);

            return timeclock;
        }

        public IList<TimeClock> Find()
        {
            var timeclock = _dbContext.timeClock
                .ToList();

            return timeclock;
        }

        public TimeClock Create(TimeClock timeclock)
        {
            _dbContext.timeClock.Add(timeclock);
            _dbContext.SaveChanges();

            return timeclock;
        }

        public TimeClock Update(int id, TimeClock timeclock)
        {
            var dbTimeclock = Get(id);

            if (dbTimeclock is null)
            {
                return null;
            }

            dbTimeclock.UserId = timeclock.UserId;
            dbTimeclock.Type = timeclock.Type;
            dbTimeclock.StartTime = timeclock.StartTime;
            dbTimeclock.EndTime = timeclock.EndTime;
            dbTimeclock.FromLocation = timeclock.FromLocation;
            dbTimeclock.ToLocation = timeclock.ToLocation;

            _dbContext.SaveChanges();

            return dbTimeclock;
        }

        public bool Delete(int id)
        {
            var dbTimeclock = Get(id);

            if (dbTimeclock is null)
            {
                return false;
            }

            _dbContext.timeClock.Remove(dbTimeclock);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
