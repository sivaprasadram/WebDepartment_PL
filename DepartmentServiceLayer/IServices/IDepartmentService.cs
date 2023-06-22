using DepartmentViewModels.ViewModels;

namespace DepartmentServiceLayer.IServices
{
    public interface IDepartmentService
    {
        void AddDepartment(DepartmentViewModel department);

        List<DepartmentViewModel> GetAllDepartments(); 

         DepartmentViewModel GetDepartmentById(int id);

        bool UpdateDepartment (DepartmentViewModel departmentViewModel); 
        
        void DeleteDepartment(int id);



    }
}
