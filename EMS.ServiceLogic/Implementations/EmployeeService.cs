using EMS.Contracts;
using EMS.ServiceLogic.Interfaces;

namespace EMS.ServiceLogic.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDatabaseService _databaseService;

        public EmployeeService(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public EmployeeResponse GetEmployee()   
        {
            var employee = _databaseService.GetEmployee();

            return new EmployeeResponse
            {
                EmployeeId = employee.EmployeeId,
                FullName = employee.FullName,
                Department = employee.Department
            };
        }
    }
}