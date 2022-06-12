using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public TaskContext context;

        public EmployeeController(TaskContext context)
        {
            this.context = context;
        }

        public IActionResult All()
        {
            ViewBag.employees = context.employees;
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee e)
        {
            if (ModelState.IsValid)
            {
                context.employees.Add(e);
                context.SaveChanges();
                return Redirect("/employee/all");
            }

            return View(e);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }

            Employee employee = context.employees.Find(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee e)
        {
            if (ModelState.IsValid)
            {
                context.employees.Update(e);
                context.SaveChanges();
                return Redirect("/employee/all");
            }
            return View(e);
        }


        public IActionResult Delete(int id)
        {
            Employee employee = context.employees.FirstOrDefault(e => e.Id == id);

            if(employee != null)
            {
                context.Remove(employee);
                context.SaveChanges();
                return Redirect("/employee/all");
            }
            return View();
        }
    }
}
