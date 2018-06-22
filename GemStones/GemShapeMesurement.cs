using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace GemStones
{
    public class GemShapeMeasurements
    {
        public GemShapeMeasurements()
        {
            Diameters = new List<GemDiameterMeasurement>();
        }
        [Key]
        public int GemShapeMesurementsID { get; set; }

        [Required]      [ScaffoldColumn(false)] //[ForeignKey("PartGemID")]
        public int PartGemID { get; set; }
       
        public decimal Depth { get; set; }

        public ICollection<GemDiameterMeasurement> Diameters { get; set; }
    }
    public class GemDiameterMeasurement
    {
        [Key]
        [ScaffoldColumn(false)]
        public int GemDiameterMeasurementsID { get; set; }

        //   [ForeignKey("GemShapeMesurements")]
        [ScaffoldColumn(false)]
        public int GemShapeMesurementsID { get; set; }
      
        public decimal Diameter { get; set; }

    }
}
