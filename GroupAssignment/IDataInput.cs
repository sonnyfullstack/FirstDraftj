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
        Person ChangeName(Person person);
        Person ChangeEmail(Person person);
        Person HomeAdress(Person person);
        Person PrivatePhoneNumber(Person person);
        Person WorkPhoneNumber(Person person);
    }
}
