using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBMI.Controllers
{
    public class BmiController : Controller
    {
        // GET: Bmi
        public ActionResult Index()
        {
            return View();
        }  
        
        [HttpPost]
        public ActionResult Calculate(FormCollection data)
        {
            //get Data From UI
            int fieldHeight = int.Parse(data["fieldHeight"]);
            int fieldWeight = int.Parse(data["fieldWeight"]);

            //BO
            HealthMgr.BmiCalculator bc = new HealthMgr.BmiCalculator();
            bc.Height = fieldHeight;
            bc.Weight = fieldWeight;
            //get BMI 
            ViewBag.Result = bc.Calculate();
             
            ViewBag.fieldHeight = fieldHeight;
            ViewBag.fieldWeight = fieldWeight;
            //show Page Index
            return View("Index");
        }
    }
}