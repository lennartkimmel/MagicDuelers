﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MagicDuelers.Controllers
{
    public class DecksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}