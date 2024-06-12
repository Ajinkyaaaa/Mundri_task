using Microsoft.AspNetCore.Mvc;
using Mundri_task.Data;
using Mundri_task.Models;

namespace Mundri_task.Controllers
{


    
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
            List<Employee> EmployeeList = _db.Employees.ToList();
            return View(EmployeeList);
        }

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee) { 
        
          _db.Employees.Add(employee);
            _db.SaveChanges();
            return View();
            return RedirectToAction("Index");
        
        }

        public IActionResult Edit(int id)
        {
            if(id == 0 || id == null)
            
            {
                return NotFound(); ;
            
            }
            Employee employeefromdb = _db.Employees.Find(id);
            if(employeefromdb == null)
            {
                return NotFound();
            }
            return View(employeefromdb);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if(ModelState.IsValid)
            {
                _db.Employees.Update(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");   
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            if (id == 0 || id == null)

            {
                return NotFound(); ;

            }
            Employee employeefromdb = _db.Employees.Find(id);
            if (employeefromdb == null)
            {
                return NotFound();
            }
            return View(employeefromdb);
        }

        [HttpPost , ActionName("Delete")]
        public IActionResult DeletePOST (int? id)
        {
            Employee employeefromdb = _db.Employees.Find(id);
            if(employeefromdb == null)
            {
                return NotFound() ; 
            }
            _db.Employees.Remove(employeefromdb);
            _db.SaveChanges();
            return RedirectToAction("Index");
           
            
        }
    }
}
