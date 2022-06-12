using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HRDataController : Controller
    {
        private readonly TaskContext context;
        public HRDataController(TaskContext context)
        {
            this.context = context;
        }

        public IActionResult All()
        {
            ViewBag.hrdata = context.Hrdatas;
            return View();
        }


        [HttpGet]
        public  IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(HRDataget h)
        {
            if (ModelState.IsValid)
            {
                context.Hrdatas.Add(h);
                context.SaveChanges();
                return Redirect("/hrdata/all");
            }

            return View(h);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            HRDataget hrdata = context.Hrdatas.Find(id);

            if (hrdata == null)
            {
                return NotFound();
            }

            return View(hrdata);
        }

        [HttpPost]
        public IActionResult Edit(HRDataget h)
        {
            if (ModelState.IsValid)
            {
                context.Hrdatas.Update(h);
                context.SaveChanges();
                return Redirect("/hrdata/all");
            }

            return View(h);
        }


        public IActionResult Delete(int id)
        {
            HRDataget hrdata = context.Hrdatas.FirstOrDefault(h => h.Id == id);
            if(hrdata != null)
            {
                context.Remove(hrdata);
                context.SaveChanges();
                return Redirect("/HRData/all");
            }
            return View();
        }
    }
}
