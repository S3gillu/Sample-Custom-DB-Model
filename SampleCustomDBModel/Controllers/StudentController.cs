using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleCustomDBModel.Models;

namespace SampleCustomDBModel.Controllers
{
    public class StudentController : Controller
    {
        StudentContext context;
        // private StudentContext db = new StudentContext();

        // GET: / Student /
        public StudentController()
        {

            context = new StudentContext();
        }
        public ActionResult Index()
        {
            return View(context.Students.ToList());
        }
      
        
        //GET: /Student/Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include= "Id,Name,Age,Qualification,EmailId,MaritalStatus")] Student student)
        {
            if (ModelState.IsValid)
            {
                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
           
        }

     }
  }
    