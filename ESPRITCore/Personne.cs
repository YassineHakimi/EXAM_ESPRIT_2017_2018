using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPRITCore
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }

        public virtual void InfoPersonne()
        {
            Console.WriteLine("ID : " + Id + " Nom : " + Nom + " Prenom : " + Prenom + " Mail : " + Mail);
        }

    }
}
