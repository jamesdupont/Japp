using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PhoneNumber : baseEntity
    {
        public PhoneNumber()
        {
            SetDefault();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int PhoneNumberID { get; set; }

        [ScaffoldColumn(false)]
        public int PersonID { get; set; }

        public Person Person { get; set; }

        [Required][MaxLength(10)]
        public string PhoneNumberType { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ThePhoneNumber { get; set; }

        public void SetDefault()
        {
            SetBaseDefaults();
            PhoneNumberType = "Cell";
        }
    }
}
