namespace SqlAzureWithEf6ConnectionResiliency.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    
    [DbConfigurationType(typeof(SqlAzureExecutionStrategyDbConfig))]
    public partial class ModelContext : DbContext
    {
        
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.Field1)
                .IsUnicode(false);
        }
    }
}
