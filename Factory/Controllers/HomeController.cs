using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Engineer[] eng = _db.Engineers.ToArray();
      Machine[] mac = _db.Machines.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("engineers", eng);
      model.Add("machines", mac);
      return View(model);
    }

  }
}