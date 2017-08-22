using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var images = new List<Image>
            {
                new Image
                {
                 Url = "/Contents/images/image1.jpg",
                 Alt = "1070"
                },
                new Image
                {
                 Url = "/Contents/images/image2.jpg",
                 Alt = "1068"
                },
            };
            Image foundImage = null;
            foreach (var image in images)
            {
                if (image.Alt == "1068")
                {
                    foundImage = image;
                    break;
                }
            }
            foundImage = images.Where(i => i.Alt == "1068").First();

            return View(images);
        }
        public ActionResult Contact()
        {
            return View();
        }
        }
    }