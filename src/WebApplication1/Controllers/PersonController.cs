using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DataProvider;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        private PersonRepository repo = new PersonRepository();

        public ActionResult Person()
        {
            IEnumerable<Person> people = repo.GetAll();
            ViewBag.Test = people;
            return View();
        }

    }
}
