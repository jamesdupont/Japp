using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Employee : BaseEntity
     {
        public  Employee()
        {
            Person = new Person();
            SetDefaults();
        }
    
        [Key][ScaffoldColumn(false)]
        public int EmployeeID { get; set; }

        [ScaffoldColumn(false)] [Required]
        public int PersonID { get; set; }

        public Person Person { get; set; }

        public string Position { get; set; }

        [Required]
        [DataType("Date")]
        public DateTime HireDate { get; set; }

        private void SetDefaults()
            {
            base.SetBaseDefaults();
            HireDate = DateTime.Now;
            
            }
    }
}
