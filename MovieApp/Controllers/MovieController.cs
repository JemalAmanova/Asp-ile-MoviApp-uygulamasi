using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MovieController: Controller
{
    public IActionResult Index(){
           
            return View( Repositary.Movies);
         }


       public IActionResult List(){
           
            return View("MovieList", Repositary.Movies);
         }
   }

}