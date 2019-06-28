
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;

namespace Models
{
   public class Appraisal : BaseEntity
    {
        public Appraisal()
        {

        }
        [Key]
        [ScaffoldColumn(false)]
        public int AppraisalID { get; set; }

        [ScaffoldColumn(false)] [Required]
        public int CustomerID { get; set; }

        public Customer Customer { get; set; }

        [Required]
        public string AppraisalType { get; set; }

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

        public ICollection<ItemAppraisal> ItemAppraisals { get; set; }

        public void SetDefault()
        {
            SetBaseDefaults();
        }
    }
}
