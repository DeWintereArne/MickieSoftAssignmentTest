using MickieSoftAssignmentTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MickieSoftAssignmentTest.Services.Abstractions
{
    public interface IQrCodeService
    {
        QrCode Get(int id);
        IList<QrCode> Find();

        QrCode Create(QrCode qrCode);
        QrCode Update(int id, QrCode qrCode);
        bool Delete(int id);
    }
}
