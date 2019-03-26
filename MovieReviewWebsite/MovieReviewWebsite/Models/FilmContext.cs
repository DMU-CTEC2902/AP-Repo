using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MovieReviewWebsite.Models;

namespace MovieReviewWebsite.Models
{
    public class FilmContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public FilmContext() : base("name=FilmContext")
        {
        }

        public System.Data.Entity.DbSet<MovieReviewWebsite.Models.Films> Films { get; set; }
        public System.Data.Entity.DbSet<MovieReviewWebsite.Models.Comment> Comment { get; set; }

        public System.Data.Entity.DbSet<MovieReviewWebsite.Models.clsActor> Actor { get; set; }

        public System.Data.Entity.DbSet<MovieReviewWebsite.Models.clsDirectors> Director { get; set; }

    }
}
