using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;


namespace Models
{
    public class ItemRepair : BaseEntity, iItem
    {
        public ItemRepair()
        {       
           // Repair = new Repair();
          //  Item = new Item();
            SetDefaults();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int ItemRepairID { get; set; }

        [Display(Name ="Completion Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime CompletionDate { get; set; }

        [Display(Name = "Estimated Value")]
        [Column(TypeName ="money")]
        public decimal EstimatedValue { get; set; }

        [MaxLength(30, ErrorMessage = "{0} can have a max of {1} characters")]
        public string ItemType { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "{0} can have a max of {1} characters")]
        [DataType(DataType.MultilineText)]
        public string Instruction { get; set; }

        [Display(Name = "Pickup Date")]
        public DateTime PickupDate { get; set; }

        [Required (ErrorMessage = "{0} is Required.")]
        [ScaffoldColumn(false)]
        public int RepairID { get; set; }
        virtual public Repair Repair { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int ItemID { get; set; }
        virtual public Item Item { get; set; }
        public void SetDefaults()
        {
            SetBaseDefaults();
            ItemType = "Repair";
        }

        public void SetDescription()
        {
            throw new NotImplementedException();
        }

        public void SetCost()
        {
            throw new NotImplementedException();
        }
    }
}
