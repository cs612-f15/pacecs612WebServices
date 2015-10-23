using ConsoleApplication1.PeopleService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("press enter to go...");

            Console.ReadLine();

            var client = new PeopleClient("HostedPeople");

            //var client = new PeopleClient("local");

            var rv = client.GetDataAsync(1).Result;

            Console.WriteLine("{0} - {1} - {2}", rv.Id, rv.familyName, rv.givenName);

            Console.WriteLine("press enter to go...");

            Console.ReadLine();

        }
    }
}
