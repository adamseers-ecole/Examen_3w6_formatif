using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Equipe
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15,MinimumLength =5)]
        public string Nom { get; set; }
        public DateTime DateCreation { get; set; }
        [StringLength(25, MinimumLength = 5)]
        public string Proprietaire { get; set; }
        [ValidateNever]
        public ICollection<Joueur>? Joueurs { get; set; }
        [ValidateNever]
        public ICollection<Tournois>? Tournois { get; set; }

     }
}
