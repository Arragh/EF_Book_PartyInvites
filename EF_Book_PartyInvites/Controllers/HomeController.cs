using EF_Book_PartyInvites.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EF_Book_PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext context) => this.context = context;

        public IActionResult Index() => View();
        public IActionResult Respond() => View();

        [HttpPost]
        public IActionResult Respond(GuestResponse response)
        {
            context.Responses.Add(response);
            context.SaveChanges();

            return RedirectToAction(nameof(Thanks), new { Name = response.Name, WillAttend = response.WillAttend });
        }

        public IActionResult Thanks(GuestResponse response) => View(response);
        public IActionResult ListResponses() => View(context.Responses.OrderByDescending(r => r.WillAttend));
    }
}
