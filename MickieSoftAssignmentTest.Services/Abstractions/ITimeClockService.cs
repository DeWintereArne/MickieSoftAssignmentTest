using MickieSoftAssignmentTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MickieSoftAssignmentTest.Services.Abstractions
{
    public interface ITimeClockService
    {
        TimeClock Get(int id);

        IList<TimeClock> Find();

        TimeClock Create(TimeClock timeClock);
        TimeClock Update(int id, TimeClock timeclock);
        bool Delete(int id);
    }
}
