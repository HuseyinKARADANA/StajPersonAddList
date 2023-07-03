using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace StajKisiProjesi.Controllers
{
    public class PersonController1 : Controller
    {
        PersonManager personManager = new PersonManager(new EfPersonDal());
        
        public IActionResult Index()
        {
            var values = personManager.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Persons p)
        {
            personManager.Insert(p);
            return RedirectToAction("Index");
        }
    }
}
