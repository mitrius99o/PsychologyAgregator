using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PsyAgregator.Data;
using PsyAgregator.Models;
using Microsoft.EntityFrameworkCore;

namespace PsyAgregator.Repositories
{
    public class PsychologistRepository : IPsychologistRepository
    {
        private PsychologistContext _context;
        public PsychologistRepository(PsychologistContext context)
        {
            _context = context;
        }

        public IEnumerable<Psychologist> GetPsychologists()
        {
            return _context.Psychologists.ToList();
        }

        public Psychologist GetPsychologistById(int id)
        {
            return _context.Psychologists.SingleOrDefault(p => p.PsychologistID == id);
        }

        public void CreatePsychologist(Psychologist psychologist)
        {
            _context.Add(psychologist);
            _context.SaveChanges();
        }

        public void DeletePsychologist(int id)
        {
            var psychologist = _context.Psychologists.SingleOrDefault(p => p.PsychologistID == id);
            _context.Psychologists.Remove(psychologist);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
