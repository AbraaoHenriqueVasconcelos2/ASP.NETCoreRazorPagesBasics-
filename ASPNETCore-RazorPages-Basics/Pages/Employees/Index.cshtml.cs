using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCore_RazorPages_Basics.Services;
using ASPNETCore_RazorPages_Basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCore_RazorPages_Basics.Pages.Employees
{
    public class IndexModel : PageModel
    {

        private readonly IEmployeeRepository iEmployeeRepository;

        public IEnumerable<Employee> Employees { get; set; }

        public IndexModel(IEmployeeRepository iEmployeeRepository)
        {
            this.iEmployeeRepository = iEmployeeRepository;
        }

        public void OnGet()
        {
            Employees = iEmployeeRepository.GetAllEmployees();
        }
    }
}
