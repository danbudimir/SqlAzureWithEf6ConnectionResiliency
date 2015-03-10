using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlAzureWithEf6ConnectionResiliency.Model;
namespace SqlAzureWithEf6ConnectionResiliency
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ModelContext())
            {
                var item = new Item { Field1 = "Some text", Field2 = new Random().Next(), Field3 = DateTime.Now};
                db.Items.Add(item);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from x in db.Items select x;

                foreach (var myItem in query)
                {
                    Console.WriteLine("Field 1: " + myItem.Field1);
                    Console.WriteLine("Field 2: " + myItem.Field2);
                    Console.WriteLine("Field 3: " + myItem.Field3);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
