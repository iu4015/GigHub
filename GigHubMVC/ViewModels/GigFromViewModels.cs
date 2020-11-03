using GigHubMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GigHubMVC.ViewModels
{
    public class GigFromViewModels
    {
        [Required]
        public string Venue { get; set; }

        [Required]
        [DateFuture]
        public string Date { get; set; }

        [Required]
        [TimeValid]
        public string Time { get; set; }

        [Required]
        public int Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime GetDateTime()
        { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
    }
}