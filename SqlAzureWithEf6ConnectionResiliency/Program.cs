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
            using (var ctx = new ModelContext())
            {

                var item = new Item {  Field1 = "some text", Field2 = 2, Field3 = DateTime.Now };
                
                ctx.Items.Add(item);
                ctx.SaveChanges();

                var query = from itm in ctx.Items select itm;

                foreach (var itemRow in query)
                {
                    Console.WriteLine("Field 1: " + itemRow.Field1);
                    Console.WriteLine("Field 2: " + itemRow.Field2);
                    Console.WriteLine("Field 3: " + itemRow.Field3);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            } 



        }
    }
}
