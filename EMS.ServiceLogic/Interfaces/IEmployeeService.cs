using EMS.Contracts;
using EMS.Model;
using System.Collections.Generic;

namespace EMS.ServiceLogic.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeResponse GetEmployee();
    }
}