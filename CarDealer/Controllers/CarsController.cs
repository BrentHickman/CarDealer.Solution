using Microsoft.AspNetCore.Mvc;
using CarDealer.Models;
using System.Collections.Generic;


namespace CarDealer.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string nickName, string make, string model, string color, string condition, int year)
    {
      Car myCar = new Car(nickName, make, model, color, condition, year);
      return RedirectToAction("Index");
    }

  }
}