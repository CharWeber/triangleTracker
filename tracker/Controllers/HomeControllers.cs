using Microsoft.AspNetCore.Mvc;
using Tracker.Models;
using System;

namespace Tracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() 
    {
      return View();
    }

    [Route("/index")]
    public ActionResult Index(string sideA, string sideB, string sideC)
    {

      Triangle newTri = new Triangle();
      int A = int.Parse(sideA);
      int B = int.Parse(sideB);
      int C = int.Parse(sideC);
      
      if (newTri.IsTriangle(A, B, C))
      {
        if (newTri.IsEqui(A, B, C))
        {
          newTri.Type = "Equilateral";
        }
        else if (newTri.IsIso(A, B, C))
        {
          newTri.Type = "Iscosceles";
        }
        else
        {
          newTri.Type = "Scalene";
        }
      }
      else
        {
          newTri.Type = "this is not a triangle";
        }
      return View(newTri);
    }
  }
}