using System.ComponentModel.DataAnnotations;

namespace Diamond
{
	public class DiamondDiameterMeasurement
    {
        [Key]
        public int DiamondDiameterMeasurementID { get; set; }

		//This is the parent
		public int DiamondMeasurementID { get; set; }

        public decimal Diameter { get; set; }

    }
}
