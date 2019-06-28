using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;

namespace Models
{
    public class ItemInventory : BaseEntity,  iItem
    {
        public ItemInventory()
            {
            SetDefaults();
            }
        [Key]
        [ScaffoldColumn(false)]
        public int ItemInventoryID { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int ItemID { get; set; }
        virtual public Item Item { get; set; }

        [Required]
        [Display(Name = "Type")]
        [MaxLength(50, ErrorMessage = "{0} can have a max of {1} characters")]
        public string ItemType { get; set; }

        public void SetDefaults()
        {
            SetBaseDefaults();
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
