using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Data
{
    public class EmployeeDetails
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Qualification { get; set; }
        public string Position { get; set; }
        public Double Salary { get; set; }
        public Double Tax { get; set; }
        public Double NetPay { get; set; }

    }
}
