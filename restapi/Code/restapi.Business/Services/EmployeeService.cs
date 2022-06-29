using restapi.Business.Interfaces;
using restapi.Data.Interfaces;
using restapi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace restapi.Business.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _EmployeeRepository;

        public EmployeeService(IEmployeeRepository EmployeeRepository)
        {
           this._EmployeeRepository = EmployeeRepository;
        }
        public IEnumerable<Employee> GetAll()
        {
            return _EmployeeRepository.GetAll();
        }

        public Employee Save(Employee Employee)
        {
            _EmployeeRepository.Save(Employee);
            return Employee;
        }

        public Employee Update(string id, Employee Employee)
        {
            return _EmployeeRepository.Update(id, Employee);
        }

        public bool Delete(string id)
        {
            return _EmployeeRepository.Delete(id);
        }

    }
}
