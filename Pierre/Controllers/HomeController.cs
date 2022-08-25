using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pierre.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pierre.Controllers
{
    public class HomeController : Controller
    {
      private readonly PierreContext _db;

      public HomeController(PierreContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View(_db.FlavorTreat.ToList());
      }

    }
}