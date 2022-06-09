using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21635618HW03.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
            

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file, string Option) 
        {

            if (file != null && file.ContentLength > 0)
            {
                string filename = Path.GetFileName(file.FileName);
                string filepath = Path.Combine(Server.MapPath("/Media/" + Option), filename);
                file.SaveAs(filepath);


                //ViewBag message becomes null because of redirection
                //ViewBag.message = "File Uploaded Successfully! " + Option;
            }
            else
            {
                return HttpNotFound("You have not chosen a file.");

                
            }
                return RedirectToAction("Index");
            
        }
        public ActionResult About()
        {


            return View();
        }
    }
}

