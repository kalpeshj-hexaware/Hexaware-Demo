using NSubstitute;
using netrestapi.Test.Framework;
using netrestapi.Api.Controllers;
using netrestapi.Business.Interfaces;


namespace netrestapi.Test.Api.EmployeeControllerSpec
{
    public abstract class UsingEmployeeControllerSpec : SpecFor<EmployeeController>
    {
        protected IEmployeeService _employeeService;

        public override void Context()
        {
            _employeeService = Substitute.For<IEmployeeService>();
            subject = new EmployeeController(_employeeService);

        }

    }
}
