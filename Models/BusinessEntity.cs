using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Models
{
    [Table("Person.BusinessEntity")]
    public class BusinessEntity : BaseEntity
    {

        public virtual ICollection<BusinessEnitityAddress> BusinessEntityAddresses { get; set; }

        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }

        public virtual Person Person { get; set; }

        public virtual Store Store { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
