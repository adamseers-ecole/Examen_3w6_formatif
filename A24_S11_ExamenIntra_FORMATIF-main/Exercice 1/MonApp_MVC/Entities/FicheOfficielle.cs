using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonApp_MVC.Entities
{
    public class FicheOfficielle
    {
        [Key]
        public int Id { get; set; }
        public string Biographie { get; set; }
        public string Photo { get; set; }
        [ForeignKey("Joueur")]
        public int Joueur_Id { get; set; }
        [ValidateNever]
        public Joueur Joueur { get; set; }
        //JUSTE BESOIN DE 11111111 CLÉ FOREIN POUR UNE LIAISON MEME SI C'EST RELIÉ DES DEUX COTÉS

    }
}
