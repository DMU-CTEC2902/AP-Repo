using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class clsDirectors
    {
        public int DirectorID { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }
        public string Gender { get; set; }
        public string DirectorBio { get; set; }
        public int DirectorAge { get; set; }
        public int FilmID { get; set; }
    }
}