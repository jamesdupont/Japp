using Diamond;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Models;

namespace ConsolApp
{
	public class DiamondPartTest
	{
		public PartDiamond TestDiamondPart()
		{
			using (Models.AlphaContext context = new Models.AlphaContext())
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
				d.DiamondShape = new DiamondShape { DiamondShapeID = 0, ShapeName = "Round Brilliant" };

				var dc = new DiamondCalculations.CalculateWeight();
				d.Weight = DiamondWeightEstimator(d.DiamondShape, d.DiamondMeasurement);
				return d;
			}
		}

		public double DiamondWeightEstimator(DiamondShape diamondShape, DiamondMeasurement dm)
		{

			

			DiamondCalculations.CalculateWeight dc = new DiamondCalculations.CalculateWeight();

			var weight = dc.CalculateDiamondWeight(diamondShape.ShapeName, dm);
			return (double) weight;
		}
		public List<decimal> DiamondWeightEstimator()
		{

			var d = TestDiamondPart();
			List<string> EstimatedDepth = new List<string>() { "Shallow", "Ideal", "Deep" };

			var ListOfWeights = new List<decimal>();

			DiamondCalculations.CalculateWeight dc = new DiamondCalculations.CalculateWeight();

			foreach (string depth in EstimatedDepth)
			{
				ListOfWeights.Add(dc.CalculateDiamondWeight(d.DiamondShape.ShapeName, d.DiamondMeasurement.DiamondDiameterMeasurements.ToList(), depth));

			}

			return ListOfWeights;
		}


		public List<decimal> DiamondVisualWeightEstimator()
			{

				var d = TestDiamondPart();
				List<string> EstimatedDepth = new List<string>() { "Shallow", "Ideal", "Deep" };

				var ListOfWeights = new List<decimal>();
				
				DiamondCalculations.CalculateWeight dc = new DiamondCalculations.CalculateWeight();

						foreach (string depth in EstimatedDepth)
						{
							ListOfWeights.Add(dc.CalculateDiamondWeight(d.DiamondShape.ShapeName, d.DiamondMeasurement.DiamondDiameterMeasurements.ToList(), depth));

						}

			return ListOfWeights;
		}
	}
}
