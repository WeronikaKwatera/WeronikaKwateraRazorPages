using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WeronikaKwateraRazorPagesFINAL.Pages.Spikes
{
    public class IndexModel : PageModel
    {
        public String mySampleModelData;

        public void OnGet()
        {
            mySampleModelData = "MyNewWebsite";
        }
    }
}