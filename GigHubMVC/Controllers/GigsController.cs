using GigHubMVC.Models;
using GigHubMVC.ViewModels;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;

namespace GigHubMVC.Controllers
{


    public class GigsController : Controller
    {
        private readonly ApplicationDbContext context;

        public GigsController()
        {
            context = new ApplicationDbContext();

        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFromViewModels
            {
                Genres = context.Genres.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GigFromViewModels viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Genres = context.Genres.ToList();
                return View("Create", viewModel);
            }

            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                GenreId = viewModel.Genre,
                DateTime = viewModel.GetDateTime(),
                Venue = viewModel.Venue
            };

            context.Gigs.Add(gig);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}