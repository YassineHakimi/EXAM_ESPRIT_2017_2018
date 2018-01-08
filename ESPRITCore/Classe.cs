using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPRITCore
{
    public class Classe
    {
        public string NomClasse { get; set; }
        public int NbreEtudiant { get; set; }

        public ICollection<Etudiant> Etudiants;


        public List<Etudiant> GetEtudiantsLessThanTen(Matière matière)
        {
            return Etudiants.Where(e => e.Matières.Contains(matière) && matière.Note.NoteMatière < 10).ToList();
        }

    }
}
