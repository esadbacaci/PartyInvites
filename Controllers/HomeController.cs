using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System.Linq;

namespace PartyInvites.Controllers {
    public class HomeController : Controller {
        private baglanti_context db;
        public HomeController(baglanti_context baglanti)
        {
            db = baglanti;
        }
        public IActionResult Index() {
            return View();
        }
        public IActionResult İletisim()
        {
            return View();
        }

        public IActionResult meb()
        {
            return View();
        }
        public IActionResult sek()
        {
            return View();
        }

        public IActionResult mc()
        {
            return View();
        }
        public IActionResult proje()
        {
            return View();
        }





        [HttpGet]
        public ViewResult RsvpForm() {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (ModelState.IsValid) {
                db.guestResponses.Add(guestResponse);
                db.SaveChanges();
                return View("Thanks", guestResponse);
            } else {
                return View();
            }
        }

        public ViewResult ListResponses() {
            return View(db.guestResponses.Where(r => r.WillAttend == true));
        }
    }
}
