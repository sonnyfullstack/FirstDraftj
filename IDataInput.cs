using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    interface IDataInput
    {
        Action GetNextAction();
        Person GetPerson();
        string Delete();
        string Edit();
        string Find();
    }
}
