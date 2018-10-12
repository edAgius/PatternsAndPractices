using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        //[Route("api/TechTest/1.0/Home/{id}")]
        //public async Task<string> GetItem(int id)
        //{
        //    var id = await this./// add servicve business logic layer
        //}
    }
}
