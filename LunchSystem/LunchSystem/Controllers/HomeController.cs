using System.Web.Mvc;
using LunchSystem.Models;
using LunchSystem.Models.Interfaces;

namespace LunchSystem.Controllers
{
    public class HomeController : Controller
    {
        public IOrderManager OrderManager { get; set; }

        // GET: Home
        public ActionResult Index()
        {
            return View(OrderManager.Orders);
        }

        [HttpPost]
        public ActionResult Order(OrderRequest request)
        {
            OrderManager.Order(request);

            return RedirectToAction("Index");
        }
    }
}