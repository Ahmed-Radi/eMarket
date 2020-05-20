using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using emarket.Models;


namespace emarket.Controllers
{
    public class CartsController : Controller
    {
        private emarketEntities db = new emarketEntities();
        // GET: Carts
        public ActionResult Index()
        {
            var cart = db.carts;
            return View(cart.ToList());
        }
        public ActionResult AddToCart(int id)
        {
            var cart1 = new cart();
            DateTime localDate = DateTime.Now;
            cart1.added_at = localDate;
            cart1.product_Id = id;
            var cart2 = db.carts.Find(id);
            if (cart2 != null)
            {
                return RedirectToAction("Filter", "products");
            }
            else
            {
                db.carts.Add(cart1);
                db.SaveChanges();
                return RedirectToAction("Filter", "products");
            }
        }

        public ActionResult Remove(int id)
        {
            var cart = db.carts.Find(id);
            if (cart != null)
            {
                db.carts.Remove(cart);
            }
            db.SaveChanges();
            return RedirectToAction("Filter", "products");
        }
    }
}