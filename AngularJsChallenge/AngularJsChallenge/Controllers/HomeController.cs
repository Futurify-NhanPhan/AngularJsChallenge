using AngularJsChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJsChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Search(SearchBindingModel model)
        {
           
            List<Segment> segments = new List<Segment>();
            segments.Add(new Segment()
            {
                Id=0,
                Title = "Control Framework",
                Content = "Acme has robust management processes to ensure that we operate in an effective and efficient manner.  This provides our clients with the assurance that the contract and supporting administrative procedures including contract management, timesheets, and invoices will be well managed.",
                DocumentType = DocumentType.Financial,
                ContentClassification = new List<string>() { "ACME Management and Quality Process", "Corporate Services", "Corporate Organization", "ACME Management and Quality Process", "Corporate Services", "Corporate Organization", "ACME Management and Quality Process, ACME Management and   Quality Process", "ACME Management and Quality Process" },
                State = State.Draft,
                ThumbnailUrl = "/Images/orderedList0.png",
                CreatedOn=DateTime.Today.AddDays(-5),
                LastModifiedOn=DateTime.Today.AddDays(-4),

            });
            segments.Add(new Segment()
            {
                Id = 1,
                Title = "Corporate Introduction",
                Content = "ACME Consulting Inc. is a well-established Canadian-owned management consulting firm.  ACME professionals provide advisory insight and solutions that help clients manage the opportunities and risks inherent in the pursuit of their business objectives.",
                DocumentType =DocumentType.Technical,
                ContentClassification = new List<string>() { "Corporate Services","ACME Management and Quality Process", "Corporate Organization", "ACME Management and Quality Process", "Corporate Services", "Corporate Organization", "ACME Management and Quality Process, ACME Management and   Quality Process", "ACME Management and Quality Process" },
                State =State.Published,
                ThumbnailUrl = "/Images/orderedList2.png",
                CreatedOn = DateTime.Today.AddDays(-6),
                LastModifiedOn = DateTime.Today.AddDays(-5),

            });
            segments.Add(new Segment()
            {
                Id = 2,
                Title = "Corporate Services",
                Content = "Our Corporate Services (CS) vision is to effectively and efficiently support Acme’ operations with a view to enhance its likelihood of achieving its objectives as well as leveraging innovative and emerging practices and tools in the area of corporate services",
                DocumentType = DocumentType.Financial,
                ContentClassification = new List<string>() { "Business Transformation and Change Framework", "ACME Management and Quality Process", "Corporate Services", "Corporate Organization", "ACME Management and Quality Process", "Corporate Services", "Corporate Organization", "ACME Management and Quality Process, ACME Management and   Quality Process", "ACME Management and Quality Process" },
                State = State.Draft,
                ThumbnailUrl = "/Images/orderedList4.png",
                CreatedOn = DateTime.Today.AddDays(-8),
                LastModifiedOn = DateTime.Today.AddDays(-7),

            });
            segments.Add(new Segment()
            {
                Id = 3,
                Title = "General Operations",
                Content = " The governance committee structure and mandates are described below",
                DocumentType = DocumentType.Technical,
                ContentClassification = new List<string>() { "Evaluation Approach and Methodology", "Corporate Services", "ACME Management and Quality Process", "Corporate Organization", "ACME Management and Quality Process", "Corporate Services", "Corporate Organization", "ACME Management and Quality Process, ACME Management and   Quality Process", "ACME Management and Quality Process" },
                State = State.Published,
                ThumbnailUrl = "/Images/orderedList7.png",
                CreatedOn = DateTime.Today.AddDays(-10),
                LastModifiedOn = DateTime.Today.AddDays(-9),

            });
            segments.Add(new Segment()
            {
                Id = 4,
                Title = "Pricing Basis",
                Content = "We have an rate of $Hourly Rate/hour. Please review the following hour allocations over the next year.",
                DocumentType = DocumentType.Financial,
                ContentClassification = new List<string>() { " Risk Assessment",  "Corporate Services", "Corporate Organization", "ACME Management and Quality Process", "Corporate Services", "Corporate Organization", "ACME Management and Quality Process, ACME Management and   Quality Process", "ACME Management and Quality Process" },
                State = State.Draft,
                ThumbnailUrl = "/Images/orderedList8.png",
                CreatedOn = DateTime.Today.AddDays(-12),
                LastModifiedOn = DateTime.Today.AddDays(-11),

            });
            segments.Add(new Segment()
            {
                Id = 5,
                Title = "Risk Management",
                Content = "Acme views enterprise risk management (or simply; risk management) as a set of business practices supported by a risk management culture which assesses, manages, and communicates risk at a level appropriate to the organization’s risk profile and objectives",
                DocumentType = DocumentType.Technical,
                ContentClassification = new List<string>() { "Risk Assessment", "Risk Management and Assessment Experience", "Risk Management Capability", "Corporate Services", "ACME Management and Quality Process", "Corporate Organization", "ACME Management and Quality Process", "Corporate Services", "Corporate Organization", "ACME Management and Quality Process, ACME Management and   Quality Process", "ACME Management and Quality Process" },
                State = State.Published,
                ThumbnailUrl = "/Images/orderedList6.png",
                CreatedOn = DateTime.Today.AddDays(-14),
                LastModifiedOn = DateTime.Today.AddDays(-13),

            });
            segments = segments.Where(s => s.Title.Contains(model.Text)).ToList();
            return Json(new { Segments = segments },JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
