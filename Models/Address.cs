using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Models
{
    public class Address : baseEntity
    {
        public Address()
        {
            SetDefaults();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int AddressID { get; set; }

        [ScaffoldColumn(false)]
        public int PersonID { get; set; }

        public Person Person { get; set; }

        public int VendorID { get; set; }
        public Vendor Vendor { get; set; }

        
        [Index]
        [Display(Name = "Address Type")]
        [Required(ErrorMessage = "A {0} is required.")]
        [MaxLength(30, ErrorMessage = "{0} can have a max of {1} characters")]
        public string AddressType { get; set; }

       
        [Display(Name = "Address Line 1")]
        [Required(ErrorMessage = "A {0} is required.")]
        [MinLength(1, ErrorMessage = "{0} can have a min of {1} characters")]
        [MaxLength(50, ErrorMessage = "{0} can have a max of {1} characters")]
        public  string Add1 { get; set; }

        [Display(Name = "Address Line 2")]
        [MaxLength(50, ErrorMessage = "{0} can have a max of {1} characters")]
        public string Add2 { get; set; }


        [MinLength(1, ErrorMessage = "{0} can have a min of {1} characters")]
        [MaxLength(30, ErrorMessage = "{0} can have a max of {1} characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "A {0} is required.")]
        [MinLength(1, ErrorMessage = "{0} can have a min of {1} characters")]
        [MaxLength(2, ErrorMessage = "{0} can have a max of {1} characters")]
        public string State { get; set; }

       
        [Display(Name = "Zipcode")][Required(ErrorMessage = "A {0} is required.")]
        [MinLength(5, ErrorMessage = "{0} can have a min of {1} characters")]
        [MaxLength(5, ErrorMessage = "{0} can have a max of {1} characters")]
        public string PostalCode { get; set; }

        public string Country { get; set; }

        public  void SetDefaults()
        {
            SetBaseDefaults();
            Add1 = "";
            Add2 = "";
            City = "Monroe";
            State = "LA";
            Country = "USA";
            AddressType = "Home";
        }
    }
    public class AddressConfiguration : EntityTypeConfiguration<Address>
    {

        public AddressConfiguration()
        {
            HasKey(a => a.AddressID);
            HasOptional(p => p.Person).WithOptionalPrincipal();
            HasOptional(v => v.Vendor).WithOptionalPrincipal();

        }
    }
}
