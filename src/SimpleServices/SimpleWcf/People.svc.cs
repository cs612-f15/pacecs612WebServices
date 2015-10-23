using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class People : IPeople
    {
        public Person GetData(int value)
        {
            //return new Person
            //{
            //    Id = 1,
            //    familyName = "foo",
            //    givenName = "bar"
            //};


            var ctx = new pacedpsEntities();

            var person = ctx.People.Where(p => p.Id == value).FirstOrDefault();

            return person;



        }


    }
}
