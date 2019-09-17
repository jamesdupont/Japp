using NUnit.Framework;
using Diamond;
using Models;

using System.Collections.Generic;
using System.Linq;

namespace Tests
{
	public class Tests
	{ 
	[Test]
	public void DiamondDiameterMeasurementsCountTest()
	{
		var d = new Models.PartDiamond();
			d.DiamondMeasurement.DiamondDiameterMeasurements
				= new List<DiamondDiameterMeasurement>
				{
					new DiamondDiameterMeasurement { Diameter = 6m },
					new DiamondDiameterMeasurement { Diameter = 5.1m },
					new DiamondDiameterMeasurement { Diameter = 5.22m } ,
					new DiamondDiameterMeasurement { Diameter = 5.13m }
				};

			d.DiamondMeasurement.DiamondTableMeasurements
				= new List<DiamondTableMeasurement>
				{
					new DiamondTableMeasurement {TableMeasurement = 3m},
					new DiamondTableMeasurement {TableMeasurement = 3.05m}
				};
			d.DiamondMeasurement.Depth = 3m;

			d.DiamondShapeID = 0;//for Round

			//Set Quality
			d.LowerClarityGrade = "VS1";
			d.TopClarityGrade = "VVS1";
			d.TopColorGrade = "D";
			d.LowerColorGrade = "H";
			//Accounting
			d.Part.Cost = 100m;
			d.Part.Quantity = 3;
			d.PricePerCarat = 300;
			
			var count = d.DiamondMeasurement.DiamondDiameterMeasurements.Count();
			
			Assert.AreEqual(count,4);
			Assert.AreEqual(d.DiamondMeasurement.DiamondTableMeasurements.Count(), 2);
			Assert.AreEqual(d.DiamondMeasurement.Depth, 3m);
		}
	}
}