using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*controllers added for contact form*/
using ACT_Youth_Homelessness_Services_Directory.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;


namespace ACT_Youth_Homelessness_Services_Directory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Services()
        {
            ViewBag.Message = "Services page.";

            return View();
        }
        public ActionResult legalfinancial()
        {
            ViewBag.Message = "Legal and Financial Services.";
                return View();
        }
        public ActionResult shelter()
        {
            ViewBag.Message = "Legal and Financial Services.";
            return View();
        }
        public ActionResult healthwellbeing()
        {
            ViewBag.Message = "Health and Wellbeing Services.";
            return View();
        }
        public ActionResult jobsemployment()
        {
            ViewBag.Message = "Jobs and Employment Services.";
            return View();
        }
        public ActionResult diversityinclusion()
        {
            ViewBag.Message = "Diversity and Inclusion Services.";
            return View();
        }
        public ActionResult familycommunity()
        {
            ViewBag.Message = "Family and Community Services";
            return View();
        }
        public ActionResult mealsandfood()
        {
            ViewBag.Message = "Meals and Food Services.";
            return View();
        }
        public ActionResult editServices()
        {
            ViewBag.Message = "editServices";
            return View();
        }
        public ActionResult belconnen()
        {
            ViewBag.Message = "belconnen";
            return View();
        }
        public ActionResult gungahlin()
        {
            ViewBag.Message = "gungahlin";
            return View();
        }
        public ActionResult woden()
        {
            ViewBag.Message = "woden";
            return View();
        }
        public ActionResult civic()
        {
            ViewBag.Message = "civic";
            return View();
        }
        public ActionResult tuggeranong()
        {
            ViewBag.Message = "tuggeranong";
            return View();
        }


    }

}