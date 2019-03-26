using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieReviewWebsite.Models
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        public virtual int CommentID { get; set; }
        public virtual int DirectorID { get; set; }
        public virtual int ActorID { get; set; }
        public virtual int FilmID { get; set; }//added this
        public virtual int PostID { get; set; }
        public virtual string Content { get; set; }
        public virtual int UserID { get; set; }
    }
}