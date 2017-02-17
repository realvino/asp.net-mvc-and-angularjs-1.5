using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using AdminLTE.Models;

namespace AdminLTE.Controllers
{
    public class AngularController : Controller
    {
        // GET: Angular
        ApplicationDbContext Db = new ApplicationDbContext();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetProducts()
        {
            var products = Db.Products.ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

        public UserManager<ApplicationUser> UserManager { get; private set; }
        public ActionResult Register(RegisterViewModel model)
        {
            var user = UserManager.FindById(User.Identity.GetUserId());
            return View(user);
        }


        [HttpPost]
        public JsonResult addProduct(ProductModels input)
        {

            Db.Products.Add(input);
            Db.SaveChanges();
            var products = Db.Products.ToList();
            return Json(products, JsonRequestBehavior.AllowGet);
        }

    }
}