using DepartmentDataAccessLayer.Entities;
using DepartmentDataAccessLayer.IRepositories;
using DepartmentServiceLayer.IServices;
using DepartmentViewModels.ViewModels;

namespace DepartmentServiceLayer.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentService(IDepartmentRepository _departmentRepository)
        {
            departmentRepository = _departmentRepository;
        }

        public void AddDepartment(Department department)
        {
            departmentRepository.AddDepartment(department);
        }

        public void AddDepartment(DepartmentViewModel departmentViewModel)
        {
            Department department = new Department();

            department.DepartmentName = departmentViewModel.DepartmentName;
            department.DepatmentCode = departmentViewModel.DepatmentCode;
            department.DepartmentEmail = departmentViewModel.DepartmentEmail;
            department.DepartmentLocaton = departmentViewModel.DepartmentLocaton;
            department.Isactive = true;

            departmentRepository.AddDepartment(department);

        }


        public List<DepartmentViewModel> GetAllDepartments()
        {
            List<Department> dplist = departmentRepository.GetAllDepartments();
            List<DepartmentViewModel> dpvmlist = new List<DepartmentViewModel>();
            foreach (Department department in dplist)
            {
                DepartmentViewModel dpvm = new DepartmentViewModel();
                dpvm.DeptId = department.DeptId;
                dpvm.DepartmentName = department.DepartmentName;
                dpvm.DepartmentEmail = department.DepartmentEmail;
                dpvm.DepartmentLocaton = department.DepartmentLocaton;
                dpvm.DepatmentCode = department.DepatmentCode;
                dpvm.Isactive = department.Isactive;
                dpvmlist.Add(dpvm);
            }
            return dpvmlist;
        }
        public DepartmentViewModel GetDepartmentById(int id)
        {
            Department department = departmentRepository.GetDepartmentByid(id);
            DepartmentViewModel dpvm = new DepartmentViewModel();
            dpvm.DeptId = department.DeptId;
            dpvm.DepartmentName = department.DepartmentName;
            dpvm.DepartmentEmail = department.DepartmentEmail;
            dpvm.DepartmentLocaton = department.DepartmentLocaton;
            dpvm.DepatmentCode = department.DepatmentCode;
            dpvm.Isactive = department.Isactive;
            return dpvm;

        }

        public bool UpdateDepartment(DepartmentViewModel departmentViewModel)
        {
            Department department = new Department();
            department.DeptId = departmentViewModel.DeptId;
            department.DepartmentName = departmentViewModel.DepartmentName;
            department.DepatmentCode = departmentViewModel.DepatmentCode;
            department.DepartmentLocaton = departmentViewModel.DepartmentLocaton;
            department.DepartmentEmail = departmentViewModel.DepartmentEmail;
            department.Isactive = departmentViewModel.Isactive;

            return departmentRepository.Updatedepartment(department);


        }

        public void DeleteDepartment(int id)
        {
            departmentRepository.DeleteDepartment(id);
        }
  
    }
}
