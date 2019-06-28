using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Models
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            //Addresses = new HashSet<Address>();
            SetDefaults();
           // Person = new Person();
            CustomerSpecialDates = new HashSet<CustomerSpecialDate>();
            Items = new HashSet<Item>();
        }

        [Key][ScaffoldColumn(false)]
        public int CustomerID { get; set; }

        [ScaffoldColumn(false)][Required]
        public int PersonID { get; set; }

        public Person Person { get; set; }

        virtual public ICollection<CustomerSpecialDate> CustomerSpecialDates { get; set; }

        public bool IsActive { get; set; }

        virtual public  ICollection<Item> Items { get; set; }


       
        public void SetDefaults()
        {
            base.SetBaseDefaults();
            IsActive = true;
        }

        public static List<string> PersonTypeValues()
        {
            List<string> returnValue = new List<string>{ "Customer" };
           
            return returnValue;
        }

        public class CustomercConfiguration : EntityTypeConfiguration<Customer>
        {

            public CustomercConfiguration()
            {
                HasMany(sd => sd.CustomerSpecialDates).WithRequired(c => c.Customer );
                HasRequired(p => p.Person);
                HasMany(i => i.Items);


                //HasMany(ea => ea.EmailAddresses).WithOptional(p => p.Person);
                //HasMany(pn => pn.PhoneNumbers).WithOptional(p => p.Person);
                //HasMany(i => i.Images).WithOptional(p => p.Person);
            }
        }
    }
}
