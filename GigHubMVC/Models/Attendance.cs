using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GigHubMVC.Models
{
    public class Attendance
    {
        public ApplicationUser Attendie { get; set; }

        public Gig Gig { get; set; }

        [Key]
        [Column(Order = 0)]
        public int GigId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string AttendieId { get; set; }
    }
}