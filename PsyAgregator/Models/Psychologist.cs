using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PsyAgregator.Models
{
    public class Psychologist
    {
        public int PsychologistID { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public long TelNumber { get; set; }
        public string Email { get; set; }

        public int PhotoID { get; set; }
        public string ImageMimeType { get; set; }
        public string PhotoFileName { get; set; }
    }
}
