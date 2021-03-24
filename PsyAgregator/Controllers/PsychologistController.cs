using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using PsyAgregator.Models;
using PsyAgregator.Data;
using PsyAgregator.Repositories;

namespace PsyAgregator.Controllers
{
    public class PsychologistController : Controller
    {
        private PsychologistContext _context;
        private IPsychologistRepository _repository;
        private IHostingEnvironment _environment;

        public PsychologistController(IPsychologistRepository repository, PsychologistContext context, IHostingEnvironment environment)
        {
            _context = context;
            _repository = repository;
            _environment = environment;
        }

        public IActionResult GetPsychologistList()
        {
            _context.SaveChanges();
            return View(_context.Psychologists.ToList());
        }

        public IActionResult AboutPsychologist(int id)
        {
            var psychologist = _repository.GetPsychologistById(id);
            if (psychologist == null)
            {
                return NotFound();
            }
            return View(psychologist);
        }


    }
}
