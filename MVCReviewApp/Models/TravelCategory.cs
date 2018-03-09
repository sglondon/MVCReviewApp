using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewApp.Models
{
    public class TravelCategory
    {
        [Key]
        public int TravelCatID { get; set; }
        public string Name { get; set; }
        

        //Navigation Property

        public virtual ICollection<Reviews> Reviews { get; set; }



    }
}