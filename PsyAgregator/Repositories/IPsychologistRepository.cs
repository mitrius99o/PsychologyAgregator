using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PsyAgregator.Models;

namespace PsyAgregator.Repositories
{
    public interface IPsychologistRepository
    {
        IEnumerable<Psychologist> GetPsychologists();
        Psychologist GetPsychologistById(int id);
        void CreatePsychologist(Psychologist psychologist);
        void DeletePsychologist(int id);
        void SaveChanges();

    }
}
