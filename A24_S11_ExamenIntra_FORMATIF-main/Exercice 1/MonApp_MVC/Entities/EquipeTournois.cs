using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonApp_MVC.Entities
{
    public class EquipeTournois
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Equipe")]
        public int Equipe_Id { get; set; }
        [ValidateNever]
        public ICollection<Equipe> Equipe { get; set; }
        [ForeignKey("Tournois")]
        public int Tournois_Id { get; set; }
        [ValidateNever]
        public ICollection<Tournois> Tournois { get; set; }
    }
}
