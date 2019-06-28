using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;
using GemStones.Lists;
using GemStones;


namespace Models
{
    public class PartGem : BaseEntity, iPart
    {
        public PartGem()
            {
                GemShapeMeasurements = new GemShapeMeasurements();
                GemShape = new GemShape();
                GemstoneType = new GemStoneType();
                //Part = new Models.Part();
                SetDefaults();
          
            }

        [Key] [ScaffoldColumn(false)]

        public int PartGemID { get; set; }

        [Required]
        public int PartID { get; set; }
        //This is a stored value
       
        public Part Part { get; set; }

        public string Color { get; set; }

        public decimal Weight { get; set; }
        
        [Display(Name = "Actual Weight")]
        public decimal ActualWeight { get; set; }

        [Display(Name = "Estimated Weight")]
        public decimal EstimatedWeight { get; set; }

        public bool IsEstWeight { get; set; }

        public bool IsSynthetic { get; set; }

        public string Finish { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Per Stone")]
        public decimal PricePerStone { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Per Carat")]
        public decimal PricePerCarat { get; set; } 

        //This is not a look up. It is a storage component
        public GemShapeMeasurements GemShapeMeasurements { get; set; }

        //Lookup Value
        [ScaffoldColumn(false)]
        public int GemStoneTypeID { get; set; }

        public GemStoneType GemstoneType { get; set; }

        //Lookup Value
        [ScaffoldColumn(false)]
        public int GemShapeID { get; set; }

        public GemShape GemShape { get; set; }


        public void SetDefaults()
            {
                SetBaseDefaults();
                IsEstWeight = true;
                IsSynthetic = false;
               
             }

        public void SetCost()
        {
            throw new NotImplementedException();
        }

        public string GetDescription(string Description)
        {
            return Description;
            throw new NotImplementedException();
        }
    }
}
