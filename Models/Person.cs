using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Models
{
    public class Person : BaseEntity
    {
        public Person()
        {
            SetDefaults();
            //Addresses = new HashSet<Address>();
            //EmailAddresses = new HashSet<EmailAddress>();
            //PhoneNumbers = new HashSet<PhoneNumber>();
            //Images = new HashSet<Image>();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int PersonID { get; set; }
        [Required]
        public string PersonType { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [MaxLength(30, ErrorMessage = "{0} can have a max of {1} characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MaxLength(30, ErrorMessage = "{0} can have a max of {1} characters")]
        public string LastName { get; set; }

        //[NotMapped] [Display(Name ="Name")]
        //public virtual string FullName
        //{
        //    get { return FirstName.Trim() + " " + LastName.Trim();}
        //}

        public virtual ICollection<Address> Addresses { get; set; }
        
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        //public static List<string> PersonTypeValues()
        //{
        //    List<string> returnValue = new List<string>();
        //    returnValue.Add("Customer");
        //    return returnValue;
        //}


        public void SetDefaults()
        {
            SetBaseDefaults();
            PersonType = "Customer";
        }   
    }

    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        
        public PersonConfiguration()
        {
           HasKey(p => p.PersonID);
           HasMany(a => a.Addresses);
           HasMany(ea => ea.EmailAddresses);
           HasMany(pn => pn.PhoneNumbers);
           HasMany(i => i.Images).WithRequired (p => p.Person);         
        }
    }
}
