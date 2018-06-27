using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Part :  baseEntity
    {
        public Part()
        {
          //  Item = new Item();
           // PartType = new PartType();
            SetDefaults();
        }
        [ScaffoldColumn(false)][Key]
        public int PartID { get; set; }

        [ScaffoldColumn(false)] [Required]
        public int ItemID { get; set; }

        virtual public Item Item { get; set; }

        public int Quantity { get; set; }

        [MaxLength(500, ErrorMessage = "{0} can have a max of {1} characters")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is Required")]
        public int PartTypeID { get; set; }
        virtual public PartType PartType { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }
        public void SetDefaults()
        {
            SetBaseDefaults();
            Quantity = 1;
            Cost = 0.00m;
        }



    }
}
