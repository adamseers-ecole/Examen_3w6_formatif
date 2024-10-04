using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonApp_MVC.Entities
{
    public class Joueur
    {
        [Key]
        public int Id { get; set; }
        [StringLength(15, MinimumLength = 5)]
        public string Prenom { get; set; }
        [StringLength(15, MinimumLength = 5)]
        public string Nom { get; set; }
        [StringLength(10, MinimumLength = 5)]
        public string Position { get; set; }
        [ValidateNever]
        public FicheOfficielle? FicheOfficielle { get; set; }
        [ForeignKey("Equipe")]
        public int Equipe_Id { get; set; }
        [ValidateNever]
        public Equipe Equipe { get; set; }

    }
}
