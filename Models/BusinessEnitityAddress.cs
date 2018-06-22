using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BusinessEnitityAddress
    {

            public int BusinessEntityID { get; set; }
            public int AddressID { get; set; }
            public int AddressTypeID { get; set; }
            public System.Guid rowguid { get; set; }
            public System.DateTime ModifiedDate { get; set; }

            public virtual Address Address { get; set; }
            public virtual AddressType AddressType { get; set; }
            public virtual BusinessEntity BusinessEntity { get; set; }

    }
}
