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
            var e = _databaseService.GetEmployee();

            return new EmployeeResponse
            {
                EmployeeId = e.EmployeeId,
                FullName = e.FullName,
                Department = e.Department
            };
        }
    }
}