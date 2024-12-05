using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
    // Inheritance: FullTimeEmployee Is an Employee
    // Composition: Room             Has a Chair
    public class DepartmentController : Controller // Automatically CLR Will Creat Obj Because DI Is Allowed by This Function [AddControllersWithViews()]
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            //_departmentRepository = new DepartmentRepository();
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var department = _departmentRepository.GetAll();
            return View(department);
        }

        //[HttpGet] "Default"
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if(ModelState.IsValid) // Server Side Validation
            {
                _departmentRepository.Add(department);
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }
    }
}
