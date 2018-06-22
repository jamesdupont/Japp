using Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Metals;

namespace Models
{
    public class PartMetal : baseEntity, iPart 
    {
        public PartMetal()
        {
            MetalType = new MetalType();
            MetalFinish = new MetalFinish();
            SetDefaults();
         //   Part = new Part();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int PartMetalID { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int PartID { get; set; }
        public Part Part { get; set; }

        [ScaffoldColumn(false)]
        public int MetalTypeID { get; set; }
        public  MetalType MetalType { get; set; }

        public bool IsStamped { get; set; }
        public decimal Weight { get; set; }

        [ScaffoldColumn(false)]
        public int MetalFinishID { get; set; }
        public MetalFinish MetalFinish { get; set; }      
       
        public void SetDefaults()
            {
            IsStamped = true;
            //MetalFinish.Finish = "Polished";
            SetBaseDefaults();
        }

        public string GetDescription(string Description)
        {
            return Description;
            throw new NotImplementedException();
        }

        public void SetCost()
        {
            throw new NotImplementedException();
        }
    }
}
