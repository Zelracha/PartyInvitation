using Microsoft.AspNetCore.Mvc;
using PartyInvite.Models;
namespace PartyInvite.Controllers
{
    public class InviteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO: to store response of the guests
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            } else
            {
                return View();
            }
           
        }

        public IActionResult GuestList()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

    }
}
