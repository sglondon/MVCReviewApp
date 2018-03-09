using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewApp.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
        [Display(Name = "Date Published")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime PublishedDate { get; set; }
        public int Rating { get; set; }

        //Foreign Key and Navigation Property

        [ForeignKey("TravelCategory"), Display(Name = "TravelCategory")]
        public int TravelCatID { get; set; }
        public virtual TravelCategory TravelCategory { get; set; }


    }
}