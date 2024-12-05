using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MVCDbContext _dbcontext;
        public DepartmentRepository(MVCDbContext dbcontext) // CLR Will Inject Obj from (MVCDbContext) When You Create Obj From DepartmentRepsitory
        {
            //_dbcontext = new MVCDbContext();
            _dbcontext = dbcontext;
        }
        public int Add(Department department)
        {
            _dbcontext.Departments.Add(department);
            return _dbcontext.SaveChanges(); // It Will Return Number of Affected Rows
        }

        public int Delete(Department department)
        {
            _dbcontext.Departments.Remove(department);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
            => _dbcontext.Departments.ToList();

        public Department GetById(int id)
            => _dbcontext.Departments.Where(D => D.Id == id).FirstOrDefault();
        
        public int Update(Department department)
        {
            _dbcontext.Departments.Update(department);
            return _dbcontext.SaveChanges();
        }
    }
}
