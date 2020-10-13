using ecom.Entity;
using ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ecom.Controllers
{
    public class HomeController : Controller
    {

        DataContext db = new DataContext();

        // GET: Home
        public ActionResult Index()
        {
            var urun = db.Products.Where(i => i.IsHome && i.IsApproved).Select(i => new ProductModel()
            {
                Id = i.Id,
                CategoryID = i.CategoryID,
                Name = i.Name,
                Description = i.Description.Length > 7 ? i.Description.Substring(0,7)+"..." : i.Description,
                Price = i.Price,
                Stock = i.Stock,
                Image = i.Image
            }).ToList();
            return View(urun);
        }
        public PartialViewResult _Slider()
        {
            return PartialView(db.Products.Where(x => x.Slider && x.IsApproved).ToList());
        }
        public ActionResult ProductDetails(int id)
        {
            return View(db.Products.Where(i =>i.Id==id).FirstOrDefault());
        }
        public ActionResult Product()
        {
            return View(db.Products.Where(i => i.IsApproved).ToList());
        }
        public ActionResult Search(string q)
        {
            var p = db.Products.Where(i => i.IsApproved == true);
            if (!string.IsNullOrEmpty(q))
            {
                p = p.Where(i => i.Name.Contains(q) || i.Description.Contains(q));
            }
            return View(p.ToList());
        }
    }
}