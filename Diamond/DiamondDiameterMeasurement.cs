using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Diamond
{
    public class DiamondDiameterMeasurement
    {
        [Key]
        public int DiamondDiameterMeasurementsID { get; set; }

        //This is the parent
        public int DiamondShapeMesurementsID { get; set; }

        public decimal Diameter { get; set; }

    }
}
