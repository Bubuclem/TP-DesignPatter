using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_DesignPatter.Models.Adaptateur
{
    public class CompteAdapter : ICompte
    {
        private Compte _compte;

        public CompteAdapter(Compte compte)
        {
            _compte = compte;
        }

        public string AfficherCompte()
        {
            return _compte.AfficherCompte();
        }
    }
}