using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TVStore.Repositories;
using PagedList;
using TVStore.Helpers;

namespace TVStore.Controllers
{
    public class TVStoreController : Controller
    {
        private ProductsRepository _productRepo;
        public TVStoreController()
        {
            _productRepo = new ProductsRepository();
        }
        public  ActionResult Index(string Search_Data, int? Page_No = null)
        {
            int Size_Of_Page = 4;
            int No_Of_Page = (Page_No ?? 1);

            var products = _productRepo.GetProducts();
            if (!String.IsNullOrEmpty(Search_Data))
            {
                var searchProduct = products.Where(stu => stu.NameTV.ToUpper().Contains(Search_Data.ToUpper()));
                return View(searchProduct.ToPagedList(No_Of_Page, Size_Of_Page));
            }
            return View(products.ToPagedList(No_Of_Page, Size_Of_Page));  
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}