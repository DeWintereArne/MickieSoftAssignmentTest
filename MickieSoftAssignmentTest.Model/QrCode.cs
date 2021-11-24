using System.ComponentModel.DataAnnotations;
using System;

namespace MickieSoftAssignmentTest.Model
{
    public class QrCode
    {
        [Required]
        public int ProjectId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int VehicleNr { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
