using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MijnFilms.Entities;

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


    }
}
