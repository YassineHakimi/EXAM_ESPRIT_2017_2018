using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPRITCore
{
    public class Matière
    {
        public int IdMatière { get; set; }
        public string NomMatière { get; set; }

        public ICollection<Enseignant> Enseignants;
        public Note Note;

    }
}
