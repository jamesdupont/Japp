using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Repair : baseEntity
    {
        public Repair()
        {         
            ItemRepairs = new List<ItemRepair>();
            Customer = new Customer();
            SetDefaults();
        }
        [Key]
        [ScaffoldColumn(false)]

        public int RepairID { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Take in Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Required(ErrorMessage = "A {0} is required.")]
        public DateTime TakeInDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A {0} is required.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Promise Date")]
        public DateTime PromiseDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Pickup Date")]
        public DateTime PickupDate { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int CustomerID { get; set; }
       
        public Customer Customer { get;}

        public ICollection<ItemRepair> ItemRepairs { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();

            TakeInDate = DateTime.Now;
            PromiseDate = DateTime.Now.AddDays(3);
            PickupDate = DateTime.Now;

        }
    }
}
