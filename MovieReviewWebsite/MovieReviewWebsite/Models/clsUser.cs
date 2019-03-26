using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MovieReviewWebsite.Models
{
    [Table("Users")]
    public class clsUser
    {
        [Key]
        public virtual int UserID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string UserSurname { get; set; }
        public virtual DateTime dateOfBirth { get; set; }
        public virtual string UserRole { get; set; }
        public virtual List<clsFilm> Films { get; set; }
        public virtual List<Comment> Comment { get; set; }
    }
}