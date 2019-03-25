using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class clsFIlm
    {
        public int FilmID{ get; set; }
        public string FilmName { get; set; }
        public string FilmDescription { get; set; }
        public int FilmRating { get; set; }
        public int ActorID { get; set; }
        public int GenreID { get; set; }
        public int DirectorID { get; set; }
    }
}