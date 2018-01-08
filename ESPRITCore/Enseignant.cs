using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPRITCore
{
    public class Enseignant : Personne
    {
        public DateTime DatePrise { get; set; }
        public string Grade { get; set; }

        public ICollection<Département> Départements;


        public override void InfoPersonne()
        {
            base.InfoPersonne();
            Console.WriteLine("Date de prise de poste : " + DatePrise + " Grade " + Grade);
        }

    }
}
