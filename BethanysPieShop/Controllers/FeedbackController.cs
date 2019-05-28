using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedBackRepository _feedbackRepository;

        public FeedbackController(IFeedBackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback model)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(model);
                return RedirectToAction("FeedbackComplete");
            }
            return View(model);
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }

    }
}