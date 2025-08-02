using System;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{

    public class Job
    {
        public int Id { get; set; }

        [Required]
        public string? CompanyName { get; set; }

        [Required]
        public string? Position { get; set; }

        public string Status { get; set; } = "Applied";

        [DataType(DataType.Date)]
        public DateTime ApplicationDate { get; set; } = DateTime.Today;
    }
}
