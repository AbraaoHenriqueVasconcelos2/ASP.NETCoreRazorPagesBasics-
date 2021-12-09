using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ASPNETCore_RazorPages_Basics.Services;
using ASPNETCore_RazorPages_Basics.Models;

namespace ASPNETCore_RazorPages_Basics.Pages.Employees
{
    public class DetailsModel : PageModel
    {

        private readonly IEmployeeRepository iEmployeeRepository;

        public Employee Employee { get; private set; }

        public DetailsModel(IEmployeeRepository iEmployeeRepository)
        {
            this.iEmployeeRepository = iEmployeeRepository;
        }

        public void OnGet(int IDEmp)
        {
            Employee = iEmployeeRepository.GetEmployee(IDEmp);
        }
    }
}
