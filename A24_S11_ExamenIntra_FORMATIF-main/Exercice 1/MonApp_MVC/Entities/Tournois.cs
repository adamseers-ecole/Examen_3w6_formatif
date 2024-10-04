using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonApp_MVC.Entities
{
    public class Tournois
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15, MinimumLength = 5)]
        public string Titre { get; set; }
        public DateTime DateDebut { get; set; }
        [ValidateNever]
        public ICollection<Equipe>? Equipes { get; set; }

  }
}
