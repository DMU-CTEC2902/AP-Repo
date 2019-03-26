using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieReviewWebsite.Models
{
    public class FilmDataInitialiser : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            //------------------------------------- USERS
            clsUser cat1 = new clsUser();
            cat1.UserID = 1;
            cat1.UserName = "MoMo";
            cat1.UserSurname = "kiki";
            cat1.dateOfBirth = new DateTime(2004, 2, 9, 4, 02, 99);
            cat1.UserRole = "Actor";
            context.Actor.Add(cat1);

            clsUser cat2 = new clsUser();
            cat1.UserID = 1;
            cat1.UserName = "Humo";
            cat1.UserSurname = "Ratsiki";
            cat1.dateOfBirth = new DateTime(2006, 6, 7, 7, 09, 98);
            cat1.UserRole = "Actor";
            context.Actor.Add(cat2);
            cat2.UserRole = "Director";
            context.Director.Add(cat2);


            clsUser cat3 = new clsUser();
            cat3.UserID = 3;
            cat3.UserName = "Bob";
            cat3.UserSurname = "Marley";
            cat3.dateOfBirth = new DateTime(2008, 5, 1, 8, 30, 52);

            cat3.UserRole = "Actor";
            context.Director.Add(cat3);

            clsActor a1 = new clsActor();// a1 = Actor 1
            a1.ActorAge = 4;
            a1.ActorFirstName = "Ben";
            a1.ActorLastName = "Afflick";
            a1.DateOfBirth = new DateTime(2028, 3, 4, 8, 30, 52);
            a1.ActorGender = "Male";
            context.Actor.Add(a1);


            //------------------------------------------------- MOVIES
            clsFilm prod1 = new clsFilm();
            prod1.FilmID = 1;
            prod1.FilmName = "Shaun of the Dead";
            prod1.FilmDescription = "Comedy";
            prod1.Rating = 18.0f;
            context.Films.Add(prod1);

            clsFilm prod3 = new clsFilm();
            prod3.FilmID = 3;
            prod3.FilmName = "Neighbours";
            prod3.FilmDescription = "Comedy";
            prod3.Rating = 16.0f;
            prod3.clsUser = new List<clsUser>();
            context.Films.Add(prod3);

            clsFilm prod4 = new clsFilm();
            prod4.FilmID = 3;
            prod4.FilmName = "The Exorcist ";
            prod4.FilmDescription = "Horror";
            prod4.Rating = 15.0f;
            prod4.clsUser = new List<clsUser>();
            context.Films.Add(prod3);



            //----------------------------------------- FilmUser
            FilmUser fu = new FilmUser();
            fu.FilmUserID = 1;
            fu.FilmID = 1;
            fu.UserID = 3;
            context.FilmUser.Add(fu);


            FilmUser fu1 = new FilmUser();
            fu1.FilmUserID = 2;
            fu1.FilmID = 4;
            fu1.UserID = 5;
            context.FilmUser.Add(fu);

            FilmUser fu3 = new FilmUser();
            fu3.FilmUserID = 2;
            fu3.FilmID = 4;
            fu3.UserID = 5;
            context.FilmUser.Add(fu);

            FilmUser fu4 = new FilmUser();
            fu4.FilmUserID = 2;
            fu4.FilmID = 4;
            fu4.UserID = 5;
            context.FilmUser.Add(fu);

            FilmUser fu5 = new FilmUser();
            fu5.FilmUserID = 2;
            fu5.FilmID = 4;
            fu5.UserID = 5;
            context.FilmUser.Add(fu);
/////////////////////////////////////////////////////////// COMMENTS

            Comment com1 = new Comment();
            com1.CommentID = 2;
            com1.DirectorID = 1;
            com1.Content = "Very Funny Movie! great actor, always knew the director would make the difference ";
            com1.FilmID = 1;
            com1.PostID = 1;
            com1.UserID = 1;
            context.Comment.Add(com2);

            Comment com2 = new Comment();
            com2.CommentID = 2;
            com2.DirectorID = 1;
            com2.Content = "Very Impressed with the entire film, would recommend! ";
            com2.FilmID = 1;
            com2.PostID = 1;
            com2.UserID = 1;
            context.Comment.Add(com2);
            base.Seed(context);


        }

    }
}