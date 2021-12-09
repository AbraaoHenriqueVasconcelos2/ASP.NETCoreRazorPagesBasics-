using ASPNETCore_RazorPages_Basics.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ASPNETCore_RazorPages_Basics.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
    }
}
