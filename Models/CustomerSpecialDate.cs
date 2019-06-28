using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CustomerSpecialDate : BaseEntity
    {
        public CustomerSpecialDate()
        {
            SetDefaults();
           // Customer = new Customer();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int SpecialDateID { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int CustomerID { get; set; }

        virtual public Customer Customer { get; set; }
        [Required]
        public string SpecialDateDateType { get; set; }

        [DataType("Date")][Required]
        public DateTime TheDate { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();
            SpecialDateDateType = "Birthday";
        }
    }
}
