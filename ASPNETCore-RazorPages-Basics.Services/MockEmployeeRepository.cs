using ASPNETCore_RazorPages_Basics.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ASPNETCore_RazorPages_Basics.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ID=1, Name="Test1", Department = Dept.IT, Email="test1@email.com", PhotoPath="img1.jpg" },
                new Employee(){ID=2, Name="Test2", Department = Dept.IT, Email="test2@email.com", PhotoPath="img2.jpg" },
                new Employee(){ID=3, Name="Test3", Department = Dept.IT, Email="test3@email.com" }
            };
        }


        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.ID == id);
        }


    }
}
