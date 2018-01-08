using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPRITCore
{
    public class Etudiant : Personne
    {
        public string AnneEntree { get; set; }
        public int Niveau { get; set; }
        public double Frais { get; set; }

        public ICollection<Matière> Matières;

        public Classe Classe;

        public override void InfoPersonne()
        {
            base.InfoPersonne();
            Console.WriteLine("Année d'entrée : " + AnneEntree + " Niveau " + Niveau + " Frais : " + Frais);
        }

    }
}
