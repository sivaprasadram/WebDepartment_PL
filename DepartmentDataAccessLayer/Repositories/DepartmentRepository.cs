using DepartmentDataAccessLayer.Entities;
using DepartmentDataAccessLayer.IRepositories;
using System.ComponentModel.Design;

namespace DepartmentDataAccessLayer.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DepartmentDbContext departmentDbContext;

        public DepartmentRepository(DepartmentDbContext _departmentDbContext)
        {
            departmentDbContext = _departmentDbContext;
        }

        public void AddDepartment(Department department)
        {
            departmentDbContext.Add(department); 
            departmentDbContext.SaveChanges();
        }


        public List<Department> GetAllDepartments()
        {
          return departmentDbContext.Departments.ToList();
        }

        public Department GetDepartmentByid(int id)
        {
           return departmentDbContext.Departments.FirstOrDefault(e=> e.DeptId == id);
        }
        public bool Updatedepartment(Department department)
        {
            var isUpdated = false;

            var dep= departmentDbContext.Departments.FirstOrDefault(e => e.DeptId == department.DeptId);
       
            if (dep != null) 
            {
                dep.DepatmentCode = department.DepatmentCode; 
                dep.DepartmentName = department.DepartmentName; 
                dep.DepartmentEmail = department.DepartmentEmail;
                dep.DepartmentLocaton = department.DepartmentLocaton;
                dep.Isactive = department.Isactive;
                departmentDbContext.Departments.Update(dep);
                departmentDbContext.SaveChanges();
                isUpdated = true;
            }
            return isUpdated;   
        
        }
        public void DeleteDepartment(int id)
        {
            Department department = departmentDbContext.Departments.FirstOrDefault(e => e.DeptId == id);

            departmentDbContext.Remove(department);
            departmentDbContext.SaveChanges();
        }
    }
}
