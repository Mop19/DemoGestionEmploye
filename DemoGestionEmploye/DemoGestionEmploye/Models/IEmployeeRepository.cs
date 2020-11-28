using System.Collections.Generic;

namespace DemoGestionEmploye.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
    }
}
