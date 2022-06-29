using restapi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace restapi.Business.Interfaces
{
    public interface IEmployeeService
    {      
        IEnumerable<Employee> GetAll();
        Employee Save(Employee classification);
        Employee Update(string id, Employee classification);
        bool Delete(string id);

    }
}
