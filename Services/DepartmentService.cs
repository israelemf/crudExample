using CRUD.Data;
using CRUD.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Services
{
    public class DepartmentService
    {
        private readonly CRUDContext _context;

        public DepartmentService(CRUDContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
