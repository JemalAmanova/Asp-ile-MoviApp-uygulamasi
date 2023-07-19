using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(){
            
            return View(Repositary.Movies);
         }

  public IActionResult Details(int id){
   var film=Repositary.GetById(id);
      return View(film);
  }

   
}
