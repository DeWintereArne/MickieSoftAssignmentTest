using System;
using System.ComponentModel.DataAnnotations;

namespace MickieSoftAssignmentTest.Model
{
    public class TimeClock
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "User id")]
        public int UserId { get; set; }
        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }
        [Required]
        [Display(Name = "Start time")]
        public DateTime StartTime { get; set; }
        [Required]
        [Display(Name = "End time")]
        public DateTime EndTime { get; set; }
        [Required]
        [Display(Name = "From location")]
        public string FromLocation { get; set; }
        [Required]
        [Display(Name = "To Location")]
        public string ToLocation { get; set; }
    }
}

