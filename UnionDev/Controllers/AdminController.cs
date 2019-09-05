using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnionDev.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult PainelControleAdmin()
        {
            return View();
        }

        public ActionResult CadastroClienteAdmin()
        {
            return View();
        }
    }
}