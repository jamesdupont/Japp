using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diamond
{
    public class Diamond
    {  
      
        public int DiamondID { get; set; }

        [Display(Name = "Birthstone Month")]
        public string BirthstoneMonth = "April";

        [Display(Name = "Mos Hardness")]
        public int MosHardnessRange = 10;

        [Display(Name = "Crystl Structure")]
        public string CrystlStructure = "Cubic";

        [Display(Name = "Chemical Formula")]
        public string ChemicalFormula = "C";

        [Display(Name = "Gem Mineral")]
        // Exmple: Quartz
        public string GemMineral = "Diamond";

        [Display(Name = "Refractive Index")]
        public decimal RefractiveIndex = 2.41M;

        [Display(Name = "Specific Gravity")]
        public decimal SpecificGravityLowRange = 3.52M;

    }
}
