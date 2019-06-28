using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class AddressType : BaseEntity
    {
        public AddressType()
        {
            SetDefaults();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int LaborTypeID { get; set; }

        public string Name { get; set; }
     
        public void SetDefaults()
        {
            SetBaseDefaults();

        }

    }
}
