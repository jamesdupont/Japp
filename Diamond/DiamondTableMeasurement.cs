using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Diamond
{
    public class DiamondTableMeasurement
    {
        [Key]
        public int DiamondTableMeasurementsID { get; set; }

        //This is the parent
        public int DiamondMesurementID { get; set; }

        public decimal TableMeasurement { get; set; }

    }
}
