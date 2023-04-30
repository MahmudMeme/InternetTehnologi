using Lab2A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2A.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public static List<EventModel> evetList = new List<EventModel>()
        {
            new EventModel(){ Name="Mahmud",id=1,Location="Debar"},
            new EventModel(){ Name="Aleksandar",id=2,Location="Skopje"}
        };

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowAllEvents()
        {

            return View(evetList);
        }
        public ActionResult EditEvent(int id)
        {

            EventModel model = evetList.ElementAt(id - 1);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEvent(EventModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("EditEvent", model);
            }
            else
            {
                int index = evetList.FindIndex(e => e.id == model.id);
                if (index == -1)
                {
                    return HttpNotFound();
                }
                evetList[index] = model;
                return View("ShowAllEvents", evetList);
            }
        }
        public ActionResult DeleteEvent(int id)
        {
            var ev = evetList.Find(e => e.id == id);
            if (evetList.Count != 0)
            {
                evetList.Remove(ev);
            }
            return View("ShowAllEvents", evetList);
        }
        public ActionResult AddNewEvent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEvent(EventModel model)
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }
            else
            {
                model.id = evetList.Count + 1;
                evetList.Add(model);
                return View("ShowAllEvents", evetList);
            }
        }
    }
}