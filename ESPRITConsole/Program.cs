using ESPRITCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPRITConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Etudiant e1 = new Etudiant
            {
                Id = 1,
                Prenom = "ahmed",
                Nom = "ben ahmed",
                Frais = 5000f,
                Mail = "ahmed@gmail.com",
                Niveau = 1,
                AnneEntree = "2018"
            };

            Etudiant e2 = new Etudiant
            {
                Id = 2,
                Prenom = "ahmed2",
                Nom = "ben ahmed2",
                Frais = 5002f,
                Mail = "ahmed2@gmail.com",
                Niveau = 2,
                AnneEntree = "2017"
            };

            Etudiant e3 = new Etudiant
            {
                Id = 3,
                Prenom = "ahmed3",
                Nom = "ben ahmed3",
                Frais = 5030f,
                Mail = "ahmed3@gmail.com",
                Niveau = 1,
                AnneEntree = "2018"
            };

            Etudiant e4 = new Etudiant
            {
                Id = 4,
                Prenom = "ahmed4",
                Nom = "ben ah4med",
                Frais = 5004f,
                Mail = "ahmed4@gmail.com",
                Niveau = 2,
                AnneEntree = "2017"
            };

            Enseignant ens1 = new Enseignant { Id = 1, Nom = "ammar", Prenom = "ammar", Mail = "ammar@gmail.com", DatePrise = DateTime.Now, Grade = "assistant" };

            Enseignant ens2 = new Enseignant { Id = 2, Nom = "ammar2", Prenom = "ammar2", Mail = "ammar2@gmail.com", DatePrise = DateTime.Parse("19/04/2015"), Grade = "Maitre assistant" };

            Enseignant ens3 = new Enseignant { Id = 3, Nom = "ammar3", Prenom = "ammar3", Mail = "ammar3@gmail.com", DatePrise = DateTime.Now, Grade = "assistant" };

            Enseignant ens4 = new Enseignant { Id = 4, Nom = "ammar4", Prenom = "ammar4", Mail = "ammar4@gmail.com", DatePrise = DateTime.Parse("19/02/2012"), Grade = "Maitre assistant" };


            Matière m1 = new Matière { IdMatière = 1, NomMatière = "proba" };
            Matière m2 = new Matière { IdMatière = 2, NomMatière = "JAva" };
            Matière m3 = new Matière { IdMatière = 3, NomMatière = "UML" };
            Matière m4 = new Matière { IdMatière = 4, NomMatière = "Unix" };

            // Test Question 3
            Département d1 = new Département { NomDépartement = NomDep.TIC, IdDépartement = 1, Enseignants = new List<Enseignant> { ens2, ens3, ens4 } };
            ens1.Départements = new List<Département> { d1 };
            ens2.Départements = new List<Département> { d1 };
            ens3.Départements = new List<Département> { d1 };
            ens4.Départements = new List<Département> { d1 };

            var res = d1.GetNouveauEnseignantsTIC();

            foreach(var r in res)
            {
                r.InfoPersonne();
            }

            // Question 7
            Note n1 = new Note { NoteMatière = 3.5, Observation = "Faible" };
            Note n2 = new Note { NoteMatière = 13.5, Observation = "Assez Bien" };
            Note n3 = new Note { NoteMatière = 15.5, Observation = "Bien" };
            Note n4 = new Note { NoteMatière = 8.5, Observation = "Faible" };
            Note n5 = new Note { NoteMatière = 10.5, Observation = "Faible" };

            List<Note> Notes = new List<Note>
            {
                n1, n2, n3, n4, n5
            };

            //// TEST

            m1.Note = n1;
            m1.Note = n2;
            m1.Note = n3;
            m1.Note = n4;

            m2.Note = n1;
            m2.Note = n2;
            m2.Note = n3;
            m2.Note = n4;

            //// d'autres pour le test
            Note n12 = new Note { NoteMatière = 18.5, Observation = "Faible" };
            Note n22 = new Note { NoteMatière = 19.5, Observation = "Assez Bien" };
            Note n32 = new Note { NoteMatière = 16.5, Observation = "Bien" };
            Note n42 = new Note { NoteMatière = 17.5, Observation = "Faible" };

            m3.Note = n12;
            m3.Note = n22;
            m3.Note = n32;
            m3.Note = n42;

            m4.Note = n12;
            m4.Note = n22;
            m4.Note = n32;
            m4.Note = n42;

            e1.Matières = new List<Matière> { m1, m2 };
            e2.Matières = new List<Matière> { m3, m4 };

            Classe c = new Classe { NbreEtudiant = 2, NomClasse = "asc", Etudiants = new List<Etudiant> { e1, e2 } };



            //// Question 8
            var promo = c.Etudiants.Where(e => e.Matières.Average(m => m.Note.NoteMatière) > 16.0f).ToList();

            Console.WriteLine("Ceux qui ont la promo ");
            foreach (var e in promo)
            {
                e.InfoPersonne();
                double red = e.Frais * 0.3;
                Console.WriteLine("Ancient prix est : " + e.Frais);
                Console.WriteLine("Nouveau prix est : " + (e.Frais - red));
                Console.WriteLine("Le montant de réduction est : " + red);
            }


            //// Test Question 4
            Console.WriteLine("Test Question 4");
            foreach (var e in c.GetEtudiantsLessThanTen(m1))
            {
                e.InfoPersonne();
            }

            Console.Read();
        }
    }
}
