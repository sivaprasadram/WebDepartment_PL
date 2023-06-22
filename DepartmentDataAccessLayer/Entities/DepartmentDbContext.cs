using Microsoft.EntityFrameworkCore;

namespace DepartmentDataAccessLayer.Entities
{
    public class DepartmentDbContext:DbContext
    {
        public DepartmentDbContext(DbContextOptions<DepartmentDbContext> options):base( options)    
        { 
        }
        public DbSet<Department> Departments{ get; set; }         
        
    }

}
