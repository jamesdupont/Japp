using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class ContactType : BaseEntity
    {
        public ContactType()
        {
            SetDefaults();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int ContactTypeID { get; set; }

        public string TheName { get; set; }
       
        public byte Default { get; set; }

        public int Order { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();
            Default = 0;

        }
    }
}
