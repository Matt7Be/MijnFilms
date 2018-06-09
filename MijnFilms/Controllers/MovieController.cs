using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MijnFilms.Entities;
using MijnFilms.Models;

namespace MijnFilms.Controllers
{
    [Route("")]
    [Route("[Controller]")]
    public class MovieController : Controller
    {
        private MovieContext db;

        public MovieController(MovieContext context)
        {
            db = context;
        }

        #region List
        [Route("")]
        [Route("[action]")]
        [Route("Lijst")]
        public ViewResult List()
        {

            return View(db.Movie.ToList());

        }
        #endregion


        #region Details
        [Route("[action]")]
        public ViewResult Details(int? id)
        {
            if (id != null)
            {
                return View(
                     db.Movie
                        .Include(m => m.Director)
                        .Include(m => m.Genre)
                        .Include(m => m.MovieActor)
                            .ThenInclude(ma => ma.Actor)
                       .FirstOrDefault(m => m.MovieId == id));
            }
            return View("Error", new ErrorViewModel());

         }
        #endregion


    }
}
