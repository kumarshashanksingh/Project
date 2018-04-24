using kanban.DA;
using kanban.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kanban.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            Task  vm = new Task();
            return View(vm);    
        }

        public JsonResult About()
        {

            var vm = TaskDa.GetList();

            //List<string> s = new List<String>();


            //for (int i=0;i<vm.Count();i++)
            //{
            //    s.Add(vm[i].ToString())/*.taskId.ToString()+'|'+vm[i].taskName.ToString()*/;   
            //}
            ////var j= Task.taskg(s,vm);
            //ViewBag.d = s;
            return Json(vm,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
          

            return View();
        }

        public ActionResult Add(int id)
        {
            var vm = TaskDa.get(id);

            return View(vm);
        }
        [HttpPost]
        public ActionResult Add1(Task c)
        {
            TaskDa.update(c);
            return RedirectToAction("Contact", "Home");
        }
    }
}