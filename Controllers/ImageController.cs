using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21635618HW03.Models;

namespace u21635618HW03.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {

            string[] filePaths = Directory.GetFiles(Server.MapPath("/Media/Images"));


            List<FileModel> files = new List<FileModel>();

            foreach (string filePath in filePaths)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(filePath)});
            }

            return View(files);
           
        }
        public FileResult DownloadImage(string fileName)
        {



            string path = Server.MapPath("~/Media/Images/") +  fileName;


            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult DeleteImage(string fileName)
        {

            string path = Server.MapPath("~/Media/Images/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            System.IO.File.Delete(path);

            return RedirectToAction("Index");
        }
    }
}