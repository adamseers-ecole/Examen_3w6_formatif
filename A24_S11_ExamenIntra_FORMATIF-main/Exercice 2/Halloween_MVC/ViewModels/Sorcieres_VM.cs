using Halloween.Models;
using System.Security.Policy;

namespace Halloween.ViewModels
{
    public class Sorcieres_VM
    {
        public Sorciere Sorciere { get; set; }

        public int NombrePotions { get; set; } = 0;
        /*
        public Sorcieres_VM(IEnumerable<Sorcieres_VM> sorciere)
        {
            NombrePotions = Sorciere.Potions.Count();
        }
        */
    }
}
