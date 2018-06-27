using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;

namespace Models
{
    public class PartChain : baseEntity, iPart
    {
        public PartChain()
        {
           
            Part = new Part();
            MetalType = new Metals.MetalType();
            SetDefaults();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int PartChainID { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public int PartID { get; set; }

        public Part Part { get; set; }

        [Display(Name = "Chain Style")]
        public string ChainStyle { get; set; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        [Display(Name = "Catch Type")]
        public string CatchType { get; set; }

        [ScaffoldColumn(false)]
        public int MetalTypeID { get; set; }

        public Metals.MetalType MetalType { get; set; }

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

        public string GetDescription(string Description)
        {
            throw new NotImplementedException();
        }
    }
}
