using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NSubstitute;
using Shouldly;
using Microsoft.AspNetCore.Mvc;
using restapi.Entities.Entities;

namespace restapi.Test.Api.EmployeeControllerSpec
{
    public class When_saving_employee : UsingEmployeeControllerSpec
    {
        private ActionResult<Employee> _result;

        private Employee _employee;

        public override void Context()
        {
            base.Context();

            _employee = new Employee
            {
                id = 20,
                name = "name"
            };

            _employeeService.Save(_employee).Returns(_employee);
        }
        public override void Because()
        {
            _result = subject.Save(_employee);
        }

        [Test]
        public void Request_is_routed_through_service()
        {
            _employeeService.Received(1).Save(_employee);

        }

        [Test]
        public void Appropriate_result_is_returned()
        {
            _result.Result.ShouldBeOfType<OkObjectResult>();

            var resultListObject = (_result.Result as OkObjectResult).Value;

            resultListObject.ShouldBeOfType<Employee>();

            var resultList = (Employee)resultListObject;

            resultList.ShouldBe(_employee);
        }
    }
}
