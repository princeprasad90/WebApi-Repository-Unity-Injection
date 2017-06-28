using System;
using System.Collections.Generic;
using System.Linq;
using WebApi_Repository_Unity_Injection.Models;
namespace WebApi_Repository_Unity_Injection
{
    public interface IEmployeeRepository:IDisposable
    {
        IList<Employee> GetEmployees();
        Employee GetEmployeeByID(int EmployeeId);
        void InsertEmployee(Employee employee);
        void DeleteEmployee(int EmployeeId);
        void UpdateEmployee(Employee employee);
        void Save();
    }
}
