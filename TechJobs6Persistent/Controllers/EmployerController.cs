﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobs6Persistent.Data;
using TechJobs6Persistent.Models;
using TechJobs6Persistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs6Persistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();

            return View(employers);
        }

        [HttpGet]
        public IActionResult Create()
        {
              AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();
                 return View(addEmployerViewModel);
        }

        [HttpPost]
        public IActionResult ProcessCreateEmployerForm(AddEmployerViewModel addEmployerViewModel )
        {
                  if (ModelState.IsValid)
            {
                Employer TheEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location,
                    
                
                };

                context.Employers.Add(TheEmployer);
                context.SaveChanges();

                return Redirect("/Employer");
            }
              return View("Create", addEmployerViewModel);
            
        }
      

        public IActionResult About (int id)
        {
            Employer? TheEmployer =  context.Employers.Find(id);
            
          
         return View(TheEmployer);
        }
      

    
    
    }
}