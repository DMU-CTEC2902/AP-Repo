using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class clsActor
    {
        public int ActorID { get; set; }
        public string ActorFirstName { get; set; }
        public string ActorLastName { get; set; }
        public int ActorAge { get; set; }
        public string ActorGender{ get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FilmID { get; set; }

    }
}