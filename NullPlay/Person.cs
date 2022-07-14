using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPlay
{
    public class Person
    {
        public Guid EmployeeId { get => EmployeeId; set => Guid.NewGuid(); }  //Expression-bodied Member

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
