using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_DesignPatter.Models
{
    public class Droit
    {
        public Droit(String categorie)
        {
            Categorie = categorie;
        }

        public int ID { get; set; }
        public string Categorie { get; set; }
        public int IdCompte { get; set; }
    }
}