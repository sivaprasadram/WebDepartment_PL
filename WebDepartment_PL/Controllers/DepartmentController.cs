using DepartmentServiceLayer.IServices;
using DepartmentViewModels.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebDepartment_PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService _departmentService)
        {
            departmentService = _departmentService;
        }

        public IActionResult Index()
        {
            List<DepartmentViewModel> departmentViewModels = departmentService.GetAllDepartments();
            return View(departmentViewModels);
        }

        [HttpGet]
        public IActionResult CreateDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDepartment(DepartmentViewModel departmentViewModel)
        {

            departmentService.AddDepartment(departmentViewModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditDepartment(int Id)
        {
             var departementViewModel = departmentService.GetDepartmentById(Id);   

            return View(departementViewModel);
        }

        [HttpPost]
        public IActionResult UpdateDepartment(DepartmentViewModel departmentViewModel)
        {
            var isUpdate = departmentService.UpdateDepartment(departmentViewModel);

            if (isUpdate) 
            {
                return RedirectToAction("Index");
            }
              
             return View("EditDepartment " , departmentViewModel);
        }

        public IActionResult DeleteDepartment(int Id)
        {
            departmentService.DeleteDepartment(Id);

            return RedirectToAction("Index"); 
        }

    }
}
