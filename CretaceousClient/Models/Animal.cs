using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CretaceousClient.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public static List<Animal> GetAnimals()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Animal> animalList = JsonConvert.DeserializeObject<List<Animal>>(jsonResponse.ToString());

            return animalList;
        }
        // public static void Post(Animal animal)
        // {
        //     string jsonAnimal = JsonConvert.SerializeObject(animal);
        //     var apiCallTask = ApiHelper.Post(jsonAnimal);
        // }
        // public static void Put(Animal animal)
        // {
        //     string jsonAnimal = JsonConvert.SerializeObject(animal);
        //     var apiCallTask = ApiHelper.Put(animal.AnimalId, jsonAnimal);
        // }
        
    }
}