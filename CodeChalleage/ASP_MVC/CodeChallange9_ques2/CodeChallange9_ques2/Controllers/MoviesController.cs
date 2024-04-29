using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeChallange9_ques2.Models;
using CodeChallange9_ques2;
using CodeChallange9_ques2.Models.Repository;

namespace CodeChallange9_ques2.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository<Movie> _movieRepository;

        public MoviesController()
        {
            _movieRepository = new MovieRepository<Movie>();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movie= _movieRepository.GetAll();
            return View(movie);
            
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie p)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Insert(p);
                _movieRepository.Save();
                return RedirectToAction("Index");
            }
            return View(p);
        }
        public ActionResult Edit(int Id)
        {
            var movie = _movieRepository.GetById(Id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie p)
        {
            if (ModelState.IsValid)
            {
                _movieRepository.Update(p);
                _movieRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(p);
            }
        }
        public ActionResult Details(int id)
        {
            var movie = _movieRepository.GetById(id);
            return View(movie);
        }

        public ActionResult Delete(int Id)
        {
            var movie = _movieRepository.GetById(Id);
            return View(movie);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeletePost(int Id)
        {
            var movie = _movieRepository.GetById(Id);
            _movieRepository.Delete(Id);
            _movieRepository.Save();
            return RedirectToAction("Index");
        }
    }
}