namespace SqlAzureWithEf6ConnectionResiliency.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Field1 { get; set; }

        public int? Field2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Field3 { get; set; }
    }
}
