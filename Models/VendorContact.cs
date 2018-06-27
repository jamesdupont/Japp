using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class VendorContact : baseEntity
    {
        public VendorContact()
        {
            SetDefaults();
            Vendor = new Vendor();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int VendorContactID { get; set; }

        [ScaffoldColumn(false)][Required]
        public int VendorID { get; set; }
        public Vendor Vendor { get; set; }

        [ScaffoldColumn(false)]
        public string VendorContactType { get; set; }

        [ScaffoldColumn(false)] [Required]
        public int PersonID { get; set; }

        public Person Person { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();
        }

    }
}
