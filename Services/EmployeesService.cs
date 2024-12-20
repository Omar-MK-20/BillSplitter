
namespace BillSplitter.Services
{
    public class EmployeesService
    {
        private ApplicationDbContext _context;

        public EmployeesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            return _context.Employees
                .ToList();
        }

        public Employee? GetById(int id)
        {
            return _context.Employees
                .SingleOrDefault(e => e.Id == id);
        }

        public void Add(string name)
        {
            Employee employee = new()
            {
                Name = name
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public string Update(string oldName, string newName)
        {
            var employee = _context.Employees
                .SingleOrDefault(e => e.Name == oldName);

            if (employee is null)
                return "User not found";

            employee.Name = newName;

            var effectedRows = _context.SaveChanges();

            return effectedRows > 0 ? "Update Successful" : "Error in Updating user";
        }

        public string Delete(string name)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Name == name);

            if (employee is null)
                return "User no found";

            _context.Remove(employee);
            var effectedRows = _context.SaveChanges();

            return effectedRows > 0 ? "Delete Successful" : "Error in Deleting user";
        }


    }
}
