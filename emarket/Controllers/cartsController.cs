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
            var AddProduct = db.products.Single(product => product.Id == id);
            cart Cart = new cart
            {
                product_Id = id,
                product = db.products.SingleOrDefault(p => p.Id == id),
                added_at = DateTime.Now
            };
            if (Cart != null)
            {
                return RedirectToAction("Filter", "products");
            }
            else
            {
                db.carts.Add(Cart);
                db.SaveChanges();
                return RedirectToAction("Filter", "products");
            }
        }

        public ActionResult Remove(int id)
        {
            var Remove = db.carts.Single(cart => cart.product_Id == id);
            db.carts.Remove(Remove);
            db.SaveChanges();
            return RedirectToAction("Filter", "products");
        }
    }
}