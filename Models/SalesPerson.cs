using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    [Table("Sales.SalesPerson")]
    public  class SalesPerson
    {
       
        public SalesPerson()
        {
            //this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            //this.SalesPersonQuotaHistories = new HashSet<SalesPersonQuotaHistory>();
            //this.SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
            this.Stores = new HashSet<Store>();
        }

        public int BusinessEntityID { get; set; }
        public Nullable<int> TerritoryID { get; set; }
        public Nullable<decimal> SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
      
        //public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        //public virtual SalesTerritory SalesTerritory { get; set; }
       
        //public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
     
        //public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
      
        public virtual ICollection<Store> Stores { get; set; }
    }
}
