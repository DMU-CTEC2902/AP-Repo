using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieReviewWebsite.Models;

namespace MovieReviewWebsite.Controllers
{
    public class FilmsController : Controller
    {

        public ActionResult FilmsList()
        {
            return View();
        }


        private FilmContext db = new FilmContext();

        // GET: Movies
        public ActionResult Index(string FilmName, string FilmRating)
        {
            List<clsFilm> lstFilms = new List<clsFilm>();
            if (FilmName == "Any" || FilmName == null)
            {
                lstFilms = db.Films.ToList();
                if (FilmRating == "Worst") { lstFilms = lstFilms.OrderBy(i => i.Rating).ToList(); }
                else if (FilmRating == "Best") { lstFilms = lstFilms.OrderByDescending(i => i.Rating).ToList(); }
            }
            else
            { lstFilms = db.Films.Where(i => i.FilmName == FilmName).ToList(); }
            if (FilmRating == "Worst") { lstFilms = lstFilms.OrderBy(i => i.Rating).ToList(); }
            else if (FilmRating == "Best") { lstFilms = lstFilms.OrderByDescending(i => i.Rating).ToList(); }
            return View(lstFilms);
        }
        [HttpGet]
        public ActionResult Details(int? id)
        {
            List<Comment> lstComment = db.Comment.Where(c => c.FilmID == id).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsFilm Film = db.Films.Find(id);//

            int numerFilmu = films.ID;//

            List<clsActor> mp = db.ActorFirstName.Where(i => i.FilmID == numerFilmu).ToList();

            foreach (clsActor movpers in mp)
            {
                Actor p2 = db.People.Find(movpers.ActorID);
                film.People.Add(p2);
            }

            if (film == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        public ActionResult Details()
        {
            int id = Convert.ToInt32(Request.Params["FilmID"]);
            Comment comment = new Comment();
            comment.Content = Request.Params["Comment"];
            comment.DirectorID = 1;
            comment.ActorID = 1;
            comment.FilmID = id;
            db.Comment.Add(comment);
            db.SaveChanges();
            List<Comment> lstComment = db.Comment.Where(c => c.FilmID == id).ToList();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsFilm film = db.Films.Find(id);//

            int numerFilmu = films.filmID;//

            List<clsDirectors> mp = db.clsDirectors.Where(i => i.FilmID == numerFilmu).ToList();

            foreach (clsDirectors movpers in mp)
            {
                Director p2 = db.User.Find(movpers.DirectorID);
                film.People.Add(p2);
            }

            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmID,FilmName,ActorName,Description,Price,Rating")] film film
            )
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(Film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(film);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsFilm film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmID,FilmName,ActorName,Description,Price,Rating")] film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            clsFilm film = db.Movies.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           clsFilm film = db.film.Find(id);
            db.films.Remove(films);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
