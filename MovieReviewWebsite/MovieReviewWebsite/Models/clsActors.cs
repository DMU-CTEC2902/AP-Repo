using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class clsActors
    {
        public int FilmID { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
        public Int32 Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ActorID { get; set; }
    }
}
        