using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeronikaKwateraRazorPagesFINAL.Pages.Models;

namespace WeronikaKwateraRazorPagesFINAL.Pages.Animals
{
    public class IndexModel : PageModel
    {
        AnimalContext animalContext = new AnimalContext();
        public List <Animal> Animals { get; set; }
        [TempData]
        public String Message { get; set; }
        public void OnGet()
        {
            Animals = animalContext.Animals.ToList();
        }
        public IActionResult OnPostDelete(int AnimalID)
        {
            var animal = animalContext.Animals.Find(AnimalID);
            animalContext.Animals.Remove(animal);
            animalContext.SaveChanges();
            Message = "Usnunieto zwierzatko o numerze: " + AnimalID;
            return RedirectToPage();
        }
    }
}