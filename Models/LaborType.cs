using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LaborType : baseEntity
    {
       public LaborType()
        {
            SetDefaults();
        }
        [Key] [ScaffoldColumn(false)]
       public int LaborTypeID { get; set; }

       public string Type { get; set; }
        [Column(TypeName = "money")]
        
        public decimal PerHourRate { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();

        }

    }
}
