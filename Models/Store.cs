using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Models
{
    public class Store :baseEntity
    {
        public Store()
        {
            this.Customers = new HashSet<Customer>();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int BusinessEntityID { get; set; }
        public string Name { get; set; }
        public Nullable<int> SalesPersonID { get; set; }
        public string Demographics { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }     
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
