using System.Collections.Generic;

namespace AngularCRUD.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}