using CretaceousClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CretaceousClient.Controllers
{
    public class AnimalsController : Controller
    {
        // /animals
        public IActionResult Index()
        {
            List<Animal> allAnimals = Animal.GetAnimals();
            return View(allAnimals);
        }

        // /animals/details/id
        public IActionResult Details(int id)
        {
            Animal animal = Animal.GetDetails(id);
            return View(animal);
        }

        public IActionResult Edit(int id)
        {
            Animal animal = Animal.GetDetails(id);
            return View(animal);
        }

        [HttpPost]
        public IActionResult Edit(Animal animal)
        {
            Animal.Put(animal);
            return RedirectToAction("Details", "Animals", new { id = animal.AnimalId });
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Animal animal)
        {
            Animal.Post(animal);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Animal animal = Animal.GetDetails(id);
            return View(animal);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Animal.Delete(id);
            return RedirectToAction("Index", "Animals");
        }
    }
}