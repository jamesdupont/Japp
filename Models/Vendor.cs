using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Vendor : baseEntity
    {
        public Vendor()
        {
            SetDefaults();
            VendorContacts = new HashSet<VendorContact>();
            Addresses = new HashSet<Address>();
            Items = new HashSet<Item>();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int VendorID { get; set; }

        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }

        [DataType(DataType.Url, ErrorMessage = "{0} is not in a valid format")]
        public string WebSite { get; set; }

        public virtual ICollection<VendorContact> VendorContacts { get; set; }
        virtual public ICollection<Address> Addresses { get; set; }
        virtual public ICollection<Item> Items { get; set; }

        public void  SetDefaults()
            {
                SetBaseDefaults();
            }
            
    }
}
