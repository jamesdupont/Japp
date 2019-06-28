using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Models
{
   public class EmailAddress : BaseEntity
    {
        public EmailAddress()
        {
            SetDefaults();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int EmailAddressID { get; set; }

        [ScaffoldColumn(false)][Required]
        public int PersonID { get; set; }

        public Person Person { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} is invalid")]
        [Display(Name = "Address Type")]
        public string Addresstype { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "{0} is not in a valid format")]
        public string ThAddress { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();

        }
    }
}
