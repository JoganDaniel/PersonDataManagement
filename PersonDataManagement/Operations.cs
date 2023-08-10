using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Operations
    {
        public void RetrieveTopTwoRecords(List<Person> list)
        {
            var result = list.Where(x => x.Age < 60).Take(2);
            Display(result.ToList());
        }

        public void RetrieveRecordsInBetweenAge(List<Person> list)
        {
            var resullt = list.Where(x => x.Age > 13 && x.Age < 18);
            Display(resullt.ToList());
        }
        public void Display(List<Person> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine(data.SN+" "+data.Name+" "+data.Address+" "+data.Age);
            }
        }
    }
}
