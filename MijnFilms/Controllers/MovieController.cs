using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MijnFilms.Entities;

namespace MijnFilms.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext db;

        public MovieController(MovieContext context)
        {
            db = context;
        }



        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


    }
}