using DNT.NorthWind.Models;
using System.Collections.Generic;

namespace DNT.NorthWind.DataAccess.Interface
{
    public interface IEmployeesRepository
    {
        IList<Employees> GetEmployeesByQuery();
        Employees GetEmployeesById(int employeeId);
        int AddEmployee(Employees employees);
        bool UpdateEmployee(int employeeId, Employees employees);
        bool DeleteEmployee(int employeeId); 
    }
}
