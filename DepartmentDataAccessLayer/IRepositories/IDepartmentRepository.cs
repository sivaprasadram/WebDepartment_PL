using DepartmentDataAccessLayer.Entities;

namespace DepartmentDataAccessLayer.IRepositories
{
    public interface IDepartmentRepository
    {
        void AddDepartment(Department department);

        List<Department> GetAllDepartments();

        Department GetDepartmentByid(int id);

        bool Updatedepartment(Department department);

       void DeleteDepartment(int id);


    }
}
