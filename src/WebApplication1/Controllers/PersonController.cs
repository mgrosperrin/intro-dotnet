using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        private repo = new PersonRepository();
        
        public ActionResult Person()
        {
            ViewBag.Test = "toto";
            return View();
        }

    }
}
