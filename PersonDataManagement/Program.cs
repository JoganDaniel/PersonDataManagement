namespace PersonDataManagement
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person()
            {
                SN = 1,
                Name = "a",
                Address = "a",
                Age = 15
            });

            persons.Add(new Person()
            {
                SN = 2,
                Name = "b",
                Address = "b",
                Age = 18
            });

            persons.Add(new Person()
            {
                SN = 3,
                Name = "c",
                Address = "c",
                Age = 21
            });

            persons.Add(new Person()
            {
                SN = 4,
                Name = "d",
                Address = "d",
                Age = 17
            });

            persons.Add(new Person()
            {
                SN = 5,
                Name = "e",
                Address = "e",
                Age = 25
            });

            persons.Add(new Person()
            {
                SN =6,
                Name = "f",
                Address = "f",
                Age = 24
            });

            persons.Add(new Person()
            {
                SN = 7,
                Name = "g",
                Address = "g",
                Age = 40
            });

            persons.Add(new Person()
            {
                SN = 8,
                Name = "h",
                Address = "h",
                Age = 36
            });

            persons.Add(new Person()
            {
                SN = 9,
                Name = "i",
                Address = "i",
                Age = 72
            });

            persons.Add(new Person()
            {
                SN = 10,
                Name = "j",
                Address = "j",
                Age = 22
            });
            Operations operation = new Operations();
            operation.Display(persons);
            Console.WriteLine();
            operation.RetrieveTopTwoRecords(persons);
            Console.WriteLine();
            operation.RetrieveRecordsInBetweenAge(persons);
            Console.WriteLine();
            operation.RetrieveAverageAge(persons);
        }
    }
}