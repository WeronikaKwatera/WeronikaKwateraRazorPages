using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeronikaKwateraRazorPagesFINAL.Pages.Models;
using Microsoft.EntityFrameworkCore;

namespace WeronikaKwateraRazorPagesFINAL.Pages.Animals
{
    public class createModel : PageModel
    {
        AnimalContext AnimalContext = new AnimalContext();
        public Animal animal { get; set; }
        [TempData]
        public String Message { get; set; }

        public void OnGet()

        {

    }

        public IActionResult OnPost(Animal animal)
        {
            AnimalContext.Animals.Add(animal);
            AnimalContext.SaveChanges();
            Message = "Dodano zwierzątko";
            return RedirectToPage("Index");
        }

        

        }
    }
