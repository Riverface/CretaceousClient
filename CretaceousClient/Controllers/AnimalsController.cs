using CretaceousClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CretaceousClient.Controllers
{
    public class AnimalsController : Controller
    {
        public IActionResult Index()
        {
            List<Animal> allAnimals = Animal.GetAnimals();
            return View(allAnimals);
        }
        public IActionResult Details(int id)
        {
        Animal animal = Animal.GetDetails(id);
        return View(animal);
        }
    }
}