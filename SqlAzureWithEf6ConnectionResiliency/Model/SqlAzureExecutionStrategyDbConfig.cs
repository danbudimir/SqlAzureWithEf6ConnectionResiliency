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
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy()); 
        } 
    }
}
