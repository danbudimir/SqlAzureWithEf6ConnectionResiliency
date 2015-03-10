using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace SqlAzureWithEf6ConnectionResiliency.Model
{
    class SqlAzureExecutionStrategyDbConfig :  DbConfiguration 
    {
        public SqlAzureExecutionStrategyDbConfig() 
        {
            //     The default retry limit is 5, which means that the total amount of time spent
            //     between retries is 26 seconds plus the random factor.
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());


            // could choose to configure here
            //int maxRetries = 5;
            //TimeSpan maxWait = TimeSpan.FromSeconds(30);
            //SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy(maxRetries,maxWait)); 

        } 
    }
}
