using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace SqlAzureWithEf6ConnectionResiliency.Model
{
    public class SqlAzureExecutionStrategyDbConfig : DbConfiguration
    {
        public SqlAzureExecutionStrategyDbConfig()
        {
            
            
            //int maxRetries = 10;
            //TimeSpan maxDelay = TimeSpan.FromSeconds(30);
            //SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy(maxRetries,maxDelay));

            
            //     The default retry limit is 5, which means that the total amount of time spent
            //     between retries is 26 seconds plus the random factor.
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}
