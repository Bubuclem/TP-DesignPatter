using System;
using System.Collections.Generic;
using TP_DesignPatter.Models.Adaptateur;

namespace TP_DesignPatter.Models
{
    public class Compte : ICompte
    {
        public Compte(String categorie)
        {
            Categorie = categorie;
        }

        public int ID { get; set; }
        public string Categorie { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public DateTime DateCreation { get; set; }

        public string AfficherCompte()
        {
            return $"{this.Prenom} {this.Nom}";
        }
    }
}