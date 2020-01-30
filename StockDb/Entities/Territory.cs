
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StockDb.Entities
{
    public partial class Territory 
    {
        public Territory()
        {
            this.Employees = new List<Employee>();
        }

       
        public Guid TerritoryId { get; set; }
      
        public string TerritoryDescription { get; set; }
        public Guid RegionId { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
