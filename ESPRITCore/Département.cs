
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPRITCore
{
    public class Département
    {
        public int IdDépartement { get; set; }
        public NomDep NomDépartement { get; set; }

        public ICollection<Enseignant> Enseignants;


        public List<Enseignant> GetNouveauEnseignantsTIC()
        {
            // Just LINQ
            var res = from e in Enseignants
                      where e.Départements.Any(d => d.NomDépartement == NomDep.TIC
                      && e.DatePrise.AddMonths(6) > DateTime.Now)
                      select e;

            return res.OrderBy(e => e.DatePrise).Reverse().ToList();

            // LINQ & LAMBDA

            //return Enseignants.Where(e => e.Départements.Any(d => d.NomDépartement == NomDep.TIC) 
            //&& (DateTime.Now - e.DatePrise).TotalDays < 6 * 31).OrderBy(e => e.DatePrise).Reverse().ToList();

        }

    }

    public enum NomDep
    {
        TIC, GénieCivile, Telecom
    }
}
