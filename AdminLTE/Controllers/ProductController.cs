using AdminLTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace AdminLTE.Controllers
{
    public class ProductController : Controller
    {

        ApplicationDbContext Db = new ApplicationDbContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(Db.Products.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            ProductModels pro = Db.Products.Find(id);
            if (pro == null)
                return HttpNotFound();
            return View(pro);
        }

        // GET: Product/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModels product)
        {
            try
            {
                // TODO: Add insert logic here
                Db.Products.Add(product);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            ProductModels pro = Db.Products.Find(id);
            if (pro == null)
                return HttpNotFound();
            return View(pro);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductModels product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                    Db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            ProductModels pro = Db.Products.Find(id);
            if (pro == null)
                return HttpNotFound();
            return View(pro);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, ProductModels product)
        {
            try
            {
                ProductModels pro = Db.Products.Find(id);
                Db.Products.Remove(pro);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
