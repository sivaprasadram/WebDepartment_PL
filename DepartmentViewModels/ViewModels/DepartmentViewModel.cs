using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentViewModels.ViewModels
{
    public class DepartmentViewModel
    {
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
        public string DepatmentCode { get; set; }
        public string DepartmentLocaton { get; set; }
        public string DepartmentEmail { get; set; }
        public bool Isactive { get; set; }
    }
}
