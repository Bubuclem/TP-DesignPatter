using System.Web.Mvc;
using TP_DesignPatter.Models;
using TP_DesignPatter.Models.Adaptateur;

namespace TP_DesignPatter.Controllers
{
    public class CompteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TableComptes()
        {
            /*ListComptes list = new ListComptes();
            var Comptes = list._comptes.Where(c => c.Equals("Admin")).OrderBy(c => c.AfficherCompte()).ToList();*/

            return View();
        }
        public ActionResult Create()
        {
        /* Banque banque = new Banque();
            CompteUserBuilder = new CompteUserBuilder();

            banque.Construct(CompteUserBuilder); */

            return View();
        }

        public ActionResult Edit(int? id)
        {
            return View();
        }

        public ActionResult Delete(int? id)
        {
            return View();
        }
    }
}