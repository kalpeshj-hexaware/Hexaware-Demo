using NSubstitute;
using netrestapi.Test.Framework;
using netrestapi.Business.Services;
using netrestapi.Data.Interfaces;

namespace netrestapi.Test.Business.EmployeeServiceSpec
{
    public abstract class UsingEmployeeServiceSpec : SpecFor<EmployeeService>
    {
        protected IEmployeeRepository _employeeRepository;

        public override void Context()
        {
            _employeeRepository = Substitute.For<IEmployeeRepository>();
            subject = new EmployeeService(_employeeRepository);

        }

    }
}
