using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    class c
    {
        public int ID { set; get; }
        public string Name { set; get; }
    }

    class product
    {
          public int ID { set; get; }
          public string productName { set; get; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var obj =new List<c>{new c{ID=10, Name="ali"},new c{ID=20,Name="Mona"}};

           
         return Json(obj,JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetProductByID(int ID) 
        {
            product p = new product { ID = ID, productName = "MyProduct" };
            return Json(p, JsonRequestBehavior.AllowGet);
        }
    }
}
