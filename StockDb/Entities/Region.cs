
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StockDb.Entities
{
    public partial class Region
    {

        public Region()
        {
            this.Territories = new List<Territory>();
        }

       
        public Guid RegionId { get; set; }
       
        public string RegionDescription { get; set; }
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
