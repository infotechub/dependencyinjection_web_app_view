using DependencyInjection.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class EmployeeService : IEmployeeDetailService
    {

        public IEnumerable<EmployeeDetails> GetAllEmployeeDetails()
        {
            return new List<EmployeeDetails>
        {
            new  EmployeeDetails {EmployeeId = 1, EmployeeName = "Akinbamidele Akin", Department = "Software Development", Qualification="B.Sc", Position="Software Developer",Salary=250000.00, Tax=4, NetPay= 250000 - (250000 * 0.04)},
            new EmployeeDetails {EmployeeId = 2, EmployeeName = "John Mike", Department = "Software Development", Qualification="B.Sc", Position="Software Developer",Salary=250000.00, Tax=4, NetPay= 250000 - (250000 * 0.04)},
            new EmployeeDetails {EmployeeId = 3, EmployeeName = "Beatrix Olamide", Department = "Software Development", Qualification="B.Sc", Position="Software Development",Salary=250000.00,Tax=4, NetPay= 250000 - (250000 * 0.04)},
            new  EmployeeDetails {EmployeeId = 4, EmployeeName = "Slima March", Department = "Sales", Qualification="B.Sc", Position="Sales Manager",Salary=150000.00,Tax=4, NetPay= 150000 - (150000 * 0.04)},
            new  EmployeeDetails {EmployeeId = 5, EmployeeName = "Jide Maku", Department = "Account", Qualification="B.sc", Position="Account Officer",Salary=200000.00,Tax=4, NetPay= 200000 - (200000 * 0.04)}

        };
        }
    }
}
