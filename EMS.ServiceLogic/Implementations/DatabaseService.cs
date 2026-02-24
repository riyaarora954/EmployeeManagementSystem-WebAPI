using EMS.Model;
using EMS.ServiceLogic.Interfaces;

namespace EMS.ServiceLogic.Implementations
{
    public class DatabaseService : IDatabaseService
    {
        public EmployeeEntity GetEmployee()
        {
            return new EmployeeEntity
            {
                EmployeeId = 1,
                FullName = "Riya Arora",
                Age = 22,
                Department = "IT"
            };
        }
    }
}