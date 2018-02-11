using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.Interfaces;
using FizzBuzz.Models;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        IFizzBuzzRepository vars=new FizzBuzzRepository();
        // GET: Home
        public ActionResult Index(string y)
        {
            //var z = y.ToList();
            //FizzBuzzModel digit = TempData["Message"] as FizzBuzzModel;
            return View();
        }

        [HttpGet]
        public ActionResult GetDetails( )
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        //public ActionResult FizzBuzzView(List<FizzBuzzModel> model)
        //{
        //    List<FizzBuzzModel> Obj = new List<FizzBuzzModel>();
        //    Obj.Capacity = model.Capacity;
        //   // int demo = List<model>;
        //    //int demo = Convert.ToInt32(model);
        //    vars.GetDisplay(Obj.Capacity);



        //   return RedirectToAction("GetDetails");
        //}
        public ActionResult FizzBuzzView(FizzBuzzInput model)
        {
            IFizzBuzzRepository repository = new FizzBuzzRepository();
            FizzBuzzOutput output = repository.ComputeResult(model);
            if (output.isSuccess())
            {
                foreach(string s in output.getResult())
                { 
                    TempData["Message"] = s;//  Debug.Print(s+" ");}
                  
                }
            }
            else
            {
                TempData["Message"] = output.getMessage();
                //Console.WriteLine(output.getMessage());
            }

            ViewBag.List = output;
           // TempData["Message"] =;
            //int idigit = Convert.ToInt32(Request["digit"].ToString());
            return RedirectToAction("Index",output.getResult());
        }
    }
}