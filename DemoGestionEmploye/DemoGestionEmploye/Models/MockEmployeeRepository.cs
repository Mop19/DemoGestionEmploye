using System.Collections.Generic;
using System.Linq;

namespace DemoGestionEmploye.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>() 
            {
                new Employee(){ Id = 1, Name = "Mary", Departement = Dept.HR, Email = "mary@mouha.com"},
                new Employee(){ Id = 2, Name = "John", Departement = Dept.IT, Email = "john@mouha.com"},
                new Employee(){ Id = 3, Name = "Sam", Departement = Dept.IT, Email = "sam@mouha.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
