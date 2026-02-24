using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Contracts
{
    public class EmployeeRequest
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
}
