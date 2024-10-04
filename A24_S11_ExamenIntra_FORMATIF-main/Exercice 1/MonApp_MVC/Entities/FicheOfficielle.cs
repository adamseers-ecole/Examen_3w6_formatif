﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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
        public int JoueurId { get; set; }
        public Joueur Joueur { get; set; }


    }
}
