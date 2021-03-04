using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using PsyAgregator.Models;
using PsyAgregator.Data;

namespace PsyAgregator.Controllers
{
    public class PsychologistController : Controller
    {
        private PsychologistContext _context;
        private IHostingEnvironment _environment;

        public PsychologistController(PsychologistContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult GetPsychologistList()
        {
            return View(_context.Psychologists.ToList());
        }

        
    }
}
