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
    public class QrCodeService : IQrCodeService
    {
        private readonly MickieSoftTestDbContext _dbContext;

        public QrCodeService(MickieSoftTestDbContext dbContext)
        {
            _dbContext =dbContext;
        }

        public QrCode Get(int id)
        {
            var qrcode = _dbContext.qrCodes
                .SingleOrDefault(q => q.ProjectId == id);

            return qrcode;
        }

        public IList<QrCode> Find()
        {
            var qrcodes = _dbContext.qrCodes
                .ToList();

            return qrcodes;
        }

        public QrCode Create(QrCode qrcode)
        {
            _dbContext.qrCodes.Add(qrcode);
            _dbContext.SaveChanges();

            return Get(qrcode.ProjectId);
        }

        public QrCode Update(int id, QrCode qrcode)
        {
            var dbQrcode = Get(id);

            if (dbQrcode is null)
            {
                return null;
            }

            dbQrcode.ProjectId = qrcode.ProjectId;
            dbQrcode.Date = qrcode.Date;
            dbQrcode.VehicleNr = qrcode.VehicleNr;
            dbQrcode.Location = qrcode.Location;

            _dbContext.SaveChanges();

            return Get(id);
        }

        public bool Delete(int id)
        {
            var dbQrcode = Get(id);

            if (dbQrcode is null)
            {
                return false;
            }

            _dbContext.qrCodes.Remove(dbQrcode);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
