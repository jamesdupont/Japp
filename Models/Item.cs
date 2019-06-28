using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;

namespace Models
{
     public class Item : BaseEntity
    {
        public Item()
        {
            SetDefaults();
            Parts = new HashSet<Part>();          
        }
        [Key]
        [ScaffoldColumn(false)]
        public int ItemID { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "{0} can have a max of {1} characters")]
        [DataType(DataType.MultilineText)]
        public  string Description { get; set; }

        [Required]
        [Display(Name = "Type")]
        [MaxLength(50, ErrorMessage = "{0} can have a max of {1} characters")]
        public string ItemType { get; set; }

        [Column(TypeName ="money")]
        public decimal TotalCost { get; set; }

        public decimal Markup { get; set; }

        virtual public ICollection<Part> Parts { get; set; }

        private void SetDefaults()
            {
                SetBaseDefaults();
            }

        public void SetDescription()
        {
            throw new NotImplementedException();
        }
    }
}
