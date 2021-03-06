using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETCore_RazorPages_Basics.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public Dept? Department { get; set; }
    }
}
