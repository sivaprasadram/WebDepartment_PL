using System.ComponentModel.DataAnnotations;

namespace DepartmentDataAccessLayer.Entities
{
    public class Department
    {
        [ Key]
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
        public string DepatmentCode { get; set; } 
        public string DepartmentLocaton { get; set;}
        public string DepartmentEmail { get; set;}
        public bool Isactive { get; set; }  
    }
}
