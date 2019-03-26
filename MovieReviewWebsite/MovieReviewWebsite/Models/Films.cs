using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MovieReviewWebsite.Models
{
    [Table("films")]
    public class Films
    {
        [Key]
        public virtual int FilmID { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual string FilmName { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual float Rating { get; set; }
        public virtual List<clsUser> Users { get; set; }
        public virtual List<Comment> Comment { get; set; }




    }
}