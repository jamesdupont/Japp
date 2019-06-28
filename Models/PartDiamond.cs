using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;
using Diamond;

namespace Models
{
    public class PartDiamond : BaseEntity, iPart
    {
        public PartDiamond()
        {
            DiamondMeasurement = new DiamondMeasurement();
            DiamondShape = new DiamondShape();
            Part = new Part();
            SetDefaults();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int PartDiamondID { get; set; }

        [ScaffoldColumn(false)]
        public int PartID { get; set; }
        public Part Part { get; set; }

        [Column(TypeName = "money")]
        public decimal PricePerCarat { get; set; }

        [ScaffoldColumn(false)]
        public int DiamondShapeID {get;set;}
        public DiamondShape DiamondShape { get; set; }

        [Display(Name = "Top Clarity")]
        public string TopClarityGrade { get; set; }

        [Display(Name = "Lower Clarity")]
        public string LowerClarityGrade { get; set; }

        [Display(Name = "Top Color")]
        public string TopColorGrade { get; set; }

        [Display(Name = "Lower Color")]
        public string LowerColorGrade { get; set; }

        public DiamondMeasurement DiamondMeasurement { get; set; }

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
