using System.Collections.Generic;
using System.Linq;

namespace AngularCRUD.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentRepository(AppDbContext appDbContext) => _appDbContext = appDbContext;

        public Department GetDepartment(int departmentId)
        {
            return _appDbContext.Departments.FirstOrDefault(e => e.DepartmentID==departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _appDbContext.Departments.ToList();
        }
    }
}