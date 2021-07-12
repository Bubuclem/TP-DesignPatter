using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_DesignPatter.Models.Adaptateur
{
    public class ListComptes
    {
        public List<ICompte> _comptes;

        public ListComptes()
        {
            _comptes = new List<ICompte>() {
                new Compte("Admin")
            };
            /*Compte compte = new Compte("Admin");
            _comptes = new List<ICompte>()
            {
                new CompteAdapter(compte)
            };*/
        }
    }
}