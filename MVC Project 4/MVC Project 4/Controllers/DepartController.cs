using Microsoft.AspNetCore.Mvc;
using MVC_Project_4.Models;

namespace MVC_Project_4.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var departmanlar = c.departmanlar.ToList();  

            return View(departmanlar);
        }

        [HttpGet]
        public IActionResult YeniDepartman() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(Departman d)
        {
            var departman = d;
            c.departmanlar.Add(departman);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var departman = c.departmanlar.Find(id);
            c.departmanlar.Remove(departman);
            c.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult DepartmanGetir(int id)
        {
            var departman = c.departmanlar.Find(id);

            return View("DepartmanGetir", departman);
        }

        public IActionResult DepartmanGuncelle(Departman d)
        {
            var depart = c.departmanlar.Find(d.DepartmanID);
            depart.DepartmanAd = d.DepartmanAd;
            c.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
