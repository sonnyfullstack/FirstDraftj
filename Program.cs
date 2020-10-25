using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment
{
    class Program
    {
        
       

        static void Main(string[] args)
        {
            IAdressBook adressbook = new Adressbook();
            IDataInput dataInput = new DataInput();
            Service service = new Service(dataInput, adressbook);
            bool programIsRunning = true;

           while (programIsRunning)
           {
                service.UserChoice();
               

           }
            Console.ReadLine();

        }
    }
}
