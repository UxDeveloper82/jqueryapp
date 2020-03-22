using Jquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jquery.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [Authorize(Roles = RoleName.CanManageEmployees)]
        public ActionResult New()
        {
            var employee = new Employee();

            return View("EmployeeForm", employee);
        }


        // GET: Employees
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageEmployees))
                return View("List");
            else
                return View("ReadOnlyList");
        }

   
        public ActionResult Details(int id)
        {
            var employee = _context.Employees.SingleOrDefault(x => x.Id == id);

            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }

        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(x=>x.Id == id);

            if (employee == null)
                return HttpNotFound();

           
            return View("EmployeeForm", employee);
        }

        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                
                return View("EmployeeForm", employee);
            }

            if (employee.Id == 0)
                _context.Employees.Add(employee);
            else
            {
                var employeeInDb = _context.Employees.Single(c => c.Id == employee.Id);

                employeeInDb.Name = employee.Name;
                employeeInDb.Office = employee.Office;
                employeeInDb.Salary = employee.Salary;
                employeeInDb.Position = employee.Position;
            
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Employees");
        }


    }
}