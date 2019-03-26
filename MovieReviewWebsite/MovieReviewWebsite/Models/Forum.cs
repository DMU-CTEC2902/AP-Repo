using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieReviewWebsite.Models
{
    public class Forum
    {
        public virtual int PostID { get; set; }
        public virtual int UserID { get; set; }
        public virtual string Title { get; set; }
        public virtual string Content { get; set; }


    }
}