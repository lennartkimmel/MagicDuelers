using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDLproject.Data;
using MDLproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace MDLproject.Controllers
{
    public class SetupController : Controller
    {

        private readonly ApplicationDbContext context;

        public SetupController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult CreateFormats()
        {
            context.Formats.Add(new Format() { Label = "Standard" });
            context.Formats.Add(new Format() { Label = "Commander" });

            context.SaveChanges();


            return Content("klaar");

        }
    }
}