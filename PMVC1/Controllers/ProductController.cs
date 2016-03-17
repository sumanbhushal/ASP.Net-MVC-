using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMVC1.Models;

namespace PMVC1.Controllers
{
    public class ProductController : Controller
    {
        private IDatabaseLayer db = ProductDB.Instance;
        // GET: Product
        public ActionResult Index()
        {
            var getListdata = db.GetProducts();
            return View(getListdata);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
            
        }

        public ActionResult Create(Product model)
        {
            model.Id = db.GetProducts().Max(p => p.Id) + 1;
            db.AddProduct(model);
            return Redirect("Index");
        }

        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Details(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}