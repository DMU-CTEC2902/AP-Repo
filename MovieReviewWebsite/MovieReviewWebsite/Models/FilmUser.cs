using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebsite.Models
{
    public class FilmUser
    {
        public virtual int FilmUserID { get; set; }
        public virtual int FilmID { get; set; }
        public virtual int UserID { get; set; }

        public virtual clsFilm Film
        { get; set; }
        public virtual clsUser User { get; set; }
    }
}