
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GemStones
{
    public class GemStoneType
    {
        public GemStoneType()
        {
            GemStoneLocations = new List<GemStoneLocation>();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int GemStoneTypeID { get; set; }

        [Display(Name = "Gemstone Name")]
        public string GemName { get; set; }

        [Display(Name = "Birthstone Month")]
        public string BirthstoneMonth { get; set; }

        [Display(Name = "Mos Hardness")]
        public string MosHardnessRange { get; set; }

        [Display(Name = "Crystl Structure")]
        public string CrystlStructure { get; set; }

        [Display(Name = "Chemical Formula")]
        public string ChemicalFormula { get; set; }

        [Display(Name = "Gem Mineral")]
        // Exmple: Quartz
        public string GemMineral { get; set; }

        [Display(Name = "RI Low")]
        public decimal RefractiveIndexLowRange { get; set; }

        [Display(Name = "RI High")]
        public decimal RefractiveIndexHighRange { get; set; }

        [NotMapped]
        [Display(Name = "Refractive Index")]
        public string RefractiveIndexRange
        {
            get
            {
                return RefractiveIndexLowRange.ToString() + "-" + RefractiveIndexHighRange.ToString();
            }
        }

        public string Birefringence { get; set; }

        [Display(Name = "SG Low")]
        public decimal SpecificGravityLowRange { get; set; }

        [Display(Name = "SG High")]
        public decimal SpecificGravityHighRange { get; set; }

        [NotMapped]
        [Display(Name = "Specific Gravity")]
        public string SpecificGravityRange
        {
            get
            {
                return SpecificGravityLowRange.ToString() + "-" + SpecificGravityHighRange.ToString();
            }
        }


        [NotMapped]
        [Display(Name = "Average SG")]
        public decimal AverageSpecificGravity
        {
            get
            {
                return decimal.Add(SpecificGravityHighRange, SpecificGravityLowRange) / 2;
            }
        }

        public virtual ICollection<GemStoneLocation> GemStoneLocations { get; set; }


    }

    public class GemStoneLocation
    {
        public GemStoneLocation()
        {
            //GemStone = new GemStoneType();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int GemStoneLocationID { get; set; }

       // [ForeignKey("GemStoneTypeID")]
        [ScaffoldColumn(false)]
        public int GemStoneTypeID { get; set; }

        public string Country { get; set; }

        public string CityRegion { get; set; }

        // public GemStoneType GemStone { get; set; }
    }
}


