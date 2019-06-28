using Diamond;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PartSingleDiamond : BaseEntity, iPart
    {
        public PartSingleDiamond()
        {
            Part = new Part();
            SetDefaults();
        }
        [Key][ScaffoldColumn(false)]
        public int SingleDiamondPartID { get; set; }

        public int PartID { get; set; }
        public Part Part { get; set; }

        public string DiamondColor { get; set; }

        public bool IsFancy { get; set; }

        public string Shape { get; set; }

        public decimal Length { get; set; }

        public virtual ICollection<RoundGemWidth> RoundGemWidths{ get; set; }

        public decimal Depth { get; set; }

        public virtual ICollection<DiamondTableMeasurement> DiamondTableMesurements { get; set; }

        public string GirdleThickness { get; set; }

        public string GirdleFinish { get; set; }

        public string CulitSize { get; set; }

        public string Polish { get; set; }

        public string ClarityGrade { get; set; }

        public string ColorGrade { get; set; }

        public string Floresence { get; set; }

        public bool IsEnhanced { get; set; }
        public string HowEnhanced { get; set; }

        public byte[] PlotImage { get; set; }

        public string SymmetryGrade { get; set; }

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
