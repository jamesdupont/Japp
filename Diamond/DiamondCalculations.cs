using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Diamond
{
    public class DiamondCalculations
    {
        #region Factors
        private static decimal CalcInterpolationFactor(
               decimal LengthToWidthRatio, decimal minRatio, decimal maxRatio, decimal minFactor, decimal maxFactor)
        {
            decimal returnValue = 00m;
                       
            decimal TotalPosibleInterpolationFactor = (maxFactor - minFactor);
            decimal TotalPosibleFracitionalRatio = (maxRatio - minRatio);
            decimal FractionalRatio = LengthToWidthRatio - minRatio;

            decimal InterpolationRatio = (FractionalRatio / TotalPosibleFracitionalRatio);
            returnValue = minFactor + (TotalPosibleInterpolationFactor * InterpolationRatio);
            return returnValue;
        }
        private static decimal MarquiseFactor(decimal Length, decimal Width)
        {
            decimal minRatio;
            decimal maxRatio;
            decimal minFactor;
            decimal maxFactor;

            decimal returnFactor = 00m;
            decimal LengthToWidthRatio = Length / Width;
            LengthToWidthRatio = decimal.Round(LengthToWidthRatio, 2);

            if (LengthToWidthRatio >= 1.50m && LengthToWidthRatio < 2.00m)
            {
                minRatio = 1.50m;
                maxRatio = 2.00m;
                minFactor = 0.00565m;
                maxFactor = 0.00580m;
            }
            else if (LengthToWidthRatio >= 2.00m && LengthToWidthRatio < 2.50m)
            {
                minRatio = 2.00m;
                maxRatio = 2.50m;
                minFactor = 0.00580m;
                maxFactor = 0.00585m;
            }
            else if (LengthToWidthRatio >= 2.50m && LengthToWidthRatio <= 3.00m)
            {
                minRatio = 2.50m;
                maxRatio = 3.00m;
                minFactor = 0.00585m;
                maxFactor = 0.00595m;
            }
            else
            {
                string message = string.Format(
                    "The lenght to width ratio '{0}' is not within an exceptable range."
                                    , LengthToWidthRatio.ToString());
                throw new Exception(message);
            }
            returnFactor = CalcInterpolationFactor(
                  LengthToWidthRatio, minRatio, maxRatio, minFactor, maxFactor);
            return returnFactor;
        }
        private static decimal PearShapeFactor(decimal Length, decimal Width)
        {
            decimal minRatio;
            decimal maxRatio;
            decimal minFactor;
            decimal maxFactor;

            decimal returnFactor = 00m;
            decimal LengthToWidthRatio = Length / Width;
            LengthToWidthRatio = decimal.Round(LengthToWidthRatio, 2);

            if (LengthToWidthRatio >= 1.25m && LengthToWidthRatio < 1.50m)
            {
                minRatio = 1.25m;
                maxRatio = 1.5m;
                minFactor = 0.00615m;
                maxFactor = 0.00600m;
            }
            else if (LengthToWidthRatio >= 1.50m && LengthToWidthRatio < 1.66m)
            {
                minRatio = 1.50m;
                maxRatio = 1.66m;
                minFactor = 0.00600m;
                maxFactor = 0.00590m;
            }
            else if (LengthToWidthRatio >= 1.66m && LengthToWidthRatio <= 2.00m)
            {
                minRatio = 1.66m;
                maxRatio = 2.00m;
                minFactor = 0.00590m;
                maxFactor = 0.00575m;
            }
            else
            {
                string message = string.Format(
                    "The lenght to width ratio '{0}' is not within an exceptable range."
                                    , LengthToWidthRatio.ToString());
                throw new Exception(message);
            }
            returnFactor = CalcInterpolationFactor(
                  LengthToWidthRatio, minRatio, maxRatio, minFactor, maxFactor);
            return returnFactor;
        }
        private static decimal EmeraldCutFactor(decimal Length, decimal Width)
        {
            decimal minRatio;
            decimal maxRatio;
            decimal minFactor;
            decimal maxFactor;

            decimal returnValue = 00m;
            decimal LengthToWidthRatio = Length / Width;
            LengthToWidthRatio = decimal.Round(LengthToWidthRatio, 2);

            if (LengthToWidthRatio >= 1.00m && LengthToWidthRatio < 1.50m)
            {
                minRatio = 1.00m;
                maxRatio = 1.50m;
                minFactor = 0.0080m;
                maxFactor = 0.0092m;
            }
            else if (LengthToWidthRatio >= 1.50m && LengthToWidthRatio < 2.00m)
            {
                minRatio = 1.50m;
                maxRatio = 2.00m;
                minFactor = 0.0092m;
                maxFactor = 0.0100m;
            }
            else if (LengthToWidthRatio >= 2.00m && LengthToWidthRatio < 2.50m)
            {
                minRatio = 2.00m;
                maxRatio = 2.50m;
                minFactor = 0.00100m;
                maxFactor = 0.00106m;
            }
            else
            {
                string message = string.Format(
                    "The lenght to width ratio '{0}' is not within an exceptable range."
                                    , LengthToWidthRatio.ToString());
                throw new Exception(message);
            }
            returnValue = CalcInterpolationFactor(
                  LengthToWidthRatio, minRatio, maxRatio, minFactor, maxFactor);
            return returnValue;
        }     
        private static decimal PrincessCutFactor(decimal Length, decimal Width)
        {
            /*
           Ratio closest to 1.25: Coefficient = 0.0080
           Ratio closest to 1.50: Coefficient = 0.0090
           Ratio closest to 2.00: Coefficient = 0.0100
           Ratio closest to 2.50: Coefficient = 0.0105
            */
            decimal minRatio;
            decimal maxRatio;
            decimal minFactor;
            decimal maxFactor;

            decimal returnValue = 00m;
            decimal LengthToWidthRatio = Length / Width;
            LengthToWidthRatio = decimal.Round(LengthToWidthRatio, 2);

            if (LengthToWidthRatio >= 1.00m && LengthToWidthRatio < 1.25m)
            {
                minRatio = 1.25m;
                maxRatio = 1.50m;
                minFactor = 0.0075m;
                maxFactor = 0.0080m;
            }
            else if (LengthToWidthRatio >= 1.250m && LengthToWidthRatio < 1.50m)
            {
                minRatio = 1.25m;
                maxRatio = 1.50m;
                minFactor = 0.0080m;
                maxFactor = 0.0090m;
            }
            else if (LengthToWidthRatio >= 1.50m && LengthToWidthRatio < 2.00m)
            {
                minRatio = 1.50m;
                maxRatio = 2.00m;
                minFactor = 0.0090m;
                maxFactor = 0.0100m;
            }
            else if (LengthToWidthRatio >= 2.00m && LengthToWidthRatio < 2.50m)
            {
                minRatio = 2.00m;
                maxRatio = 2.50m;
                minFactor = 0.00100m;
                maxFactor = 0.00105m;
            }
            else
            {
                string message = string.Format(
                    "The lenght to width ratio '{0}' is not within an exceptable range."
                                    , LengthToWidthRatio.ToString());
                throw new Exception(message);
            }
            returnValue = CalcInterpolationFactor(
                  LengthToWidthRatio, minRatio, maxRatio, minFactor, maxFactor);
            return returnValue;
        }

        #endregion Factors
        public class CalculateWeight
        {
            public decimal CalculateDiamondWeight(string ShapeName, 
                DiamondMeasurement diamondMeasurement)
            {
                decimal weight = 0.00m;
                if (ShapeName == string.Empty)
                    { throw new Exception("The ShapeName can't left blank."); }
                
                if (diamondMeasurement == null)
                    { throw new Exception("The Diamond Measurement object must be set."); }
                if (diamondMeasurement.Depth == 0.00m)
                    { throw new Exception("Depth can't be set to 0.00."); }
                try {
                    weight = CalculateDiamondWeight(
                    ShapeName,
                    diamondMeasurement.DiamondDiameterMeasurements.ToList(),
                    diamondMeasurement.Depth);
                     } 
                catch (Exception e)
                {
                    throw new Exception("An error happened while calculating the Diamond Weight.",
                       new Exception(e.Message + " Call: public decimal CalculateDiamondWeight(string ShapeName DiamondMeasurement diamondMeasurement)")); 
                }
                    return weight;
            }

            public decimal CalculateDiamondWeight(
                    string ShapeName, List<DiamondDiameterMeasurement> Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                    { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                    { throw new Exception("The list of diameters must contain at least one value."); }

                if (ShapeName == string.Empty)
                    { throw new Exception("The ShapeName can't left blank."); }

                decimal weight = 0.00m;

                switch (ShapeName)
                {
                    case "Round Brilliant":
                        weight = RoundBriliantWeightCalc(Diameters, Depth);
                        break;
                    case "Oval Shape":
                        weight = OvalShapeWeightCalc(Diameters, Depth);
                        break;
                    case "Heart Shape":
                        weight = HeartShapeWeightCalc(Diameters, Depth);
                        break;
                    case "Asure Cut": // same as Emerald Cut
                        weight = EmeraldCutWeightCalc(Diameters, Depth);
                        break;
                    case "Marquise Shape":
                        weight = MarquiseShapeWeightCalc(Diameters, Depth);
                        break;
                    case "Pear Shape":
                        weight =  PearShapeWeightCalc(Diameters, Depth);
                        break;
                    case "Emerald Cut":
                        weight = EmeraldCutWeightCalc(Diameters, Depth);
                        break;
                    case "Princess Shape":
                        weight = PrincessCutWeightCalc(Diameters, Depth);
                        break;
                    case "Triangular Shape":
                        weight = TriangularShapeWeightCalc(Diameters, Depth);
                        break;
                }

                return Math.Round(weight, 2);
            }

            public decimal CalculateDiamondWeight(
                    string ShapeName, List<DiamondDiameterMeasurement> Diameters, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't left blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                if (ShapeName == string.Empty)
                { throw new Exception("The ShapeName can't left blank."); }
                decimal weight = 0.00m;

                switch (ShapeName)
                {
                    case "Round Brilliant":
                        weight = RoundBriliantWeightCalc(Diameters, Depth);
                        break;

                    case "Oval Shape":
                        weight = OvalShapeWeightCalc(Diameters, Depth);
                        break;
                    case "Heart Shape":
                        weight = HeartShapeWeightCalc(Diameters, Depth);
                        break;
                    case "Asure Cut": // same as Emerald Cut
                        weight = EmeraldCutWeightCalc(Diameters, Depth);
                        break;
                    case "Marquise Shape":
                        weight = MarquiseShapeWeightCalc(Diameters, Depth);
                        break;
                    case "Pear Shape":
                        weight = PearShapeWeightCalc(Diameters, Depth);
                        break;
                    case "Emerald Cut":
                        weight = EmeraldCutWeightCalc(Diameters, Depth);
                        break;
                    case "Princess Shape":
                        weight = PrincessCutWeightCalc(Diameters, Depth);
                        break;
                    case "Triangular Shape":
                        weight = TriangularShapeWeightCalc(Diameters, Depth);
                        break;
                }

                return Math.Round(weight, 2);
            }

            #region Round
            public decimal RoundBriliantWeightCalc(List<DiamondDiameterMeasurement> Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }
         
                var AverageDiameter = Diameters.Average(d => d.Diameter);
                decimal Weight = AverageDiameter * AverageDiameter * Depth * .0061m;
                return Weight;
            }

            public decimal RoundBriliantWeightCalc(List<DiamondDiameterMeasurement> Diameters, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal DepthMeasurement = 0.00m;
                decimal Width = Diameters.Min(d => d.Diameter);

                DepthMeasurement = RoundBriliantEstimateDepth(Width, Depth);

                return RoundBriliantWeightCalc(Diameters, DepthMeasurement);
            }
            public decimal RoundBriliantEstimateDepth(decimal Width, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be left blank."); }

                if (Width == 0.00m)
                { throw new Exception("Width must be greater than 0.00"); }

                decimal DepthMeasurement = 0.00m;
                switch (Depth)
                {
                    case "Shallow":
                        DepthMeasurement = Width * .57m;
                        break;
                    case "Ideal":
                        DepthMeasurement = Width * .60m;
                        break;
                    case "Deep":
                        DepthMeasurement = Width * .63m;
                        break;
                }
                return DepthMeasurement;
            }
            
            #endregion Round

            #region Oval Shape
            public decimal OvalShapeWeightCalc(List<DiamondDiameterMeasurement> Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal Length = Diameters.Max(d => d.Diameter);
                decimal Width = Diameters.Min(d => d.Diameter);

                decimal AverageDiameter = (Length + Width) / 2;
                decimal Weight = AverageDiameter * AverageDiameter * Depth * .0062m;
                return Weight;
            }

            public decimal OvalShapeWeightCalc(List<DiamondDiameterMeasurement> Diameters, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal DepthMeasurement = 0.00m;
                decimal Width = Diameters.Min(d => d.Diameter);

                DepthMeasurement = OvalShapeEstimateDepth(Width, Depth);

                return OvalShapeWeightCalc(Diameters, DepthMeasurement);
            }

            public decimal OvalShapeEstimateDepth(decimal Width, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be left blank."); }

                if (Width == 0.00m)
                { throw new Exception("Width must be greater than 0.00"); }

                decimal DepthMeasurement = 0.00m;
               
                switch (Depth)
                {
                    case "Shallow":
                        DepthMeasurement = Width * .56m;
                        break;
                    case "Ideal":
                        DepthMeasurement = Width * .63m;
                        break;
                    case "Deep":
                        DepthMeasurement = Width * .70m;
                        break;
                }
                return DepthMeasurement;
            }
            #endregion Oval Shape

            #region HeartShaped
            public decimal HeartShapeWeightCalc(List<DiamondDiameterMeasurement> Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal Length = Diameters.Max(d => d.Diameter);
                decimal Width = Diameters.Min(d => d.Diameter);

                decimal Weight = Length * Width * Depth * .0059m;
                return Weight;
            }

            public decimal HeartShapeWeightCalc(List<DiamondDiameterMeasurement> Diameters, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal DepthMeasurement = 0.00m;
                decimal Width = Diameters.Min(d => d.Diameter);
                
                DepthMeasurement = HeartShapeEstimateDepth(Width, Depth);
                return HeartShapeWeightCalc(Diameters, DepthMeasurement);
            }

            public decimal HeartShapeEstimateDepth(decimal Width, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be left blank."); }

                if (Width == 0.00m)
                { throw new Exception("Width must be greater than 0.00"); }

                decimal DepthMeasurement = 0.00m;
                switch (Depth)
                {
                    case "Shallow":
                        DepthMeasurement = Width * .55m;
                        break;
                    case "Ideal":
                        DepthMeasurement = Width * .60m;
                        break;
                    case "Deep":
                        DepthMeasurement = Width * .67m;
                        break;
                }
                return DepthMeasurement;
            }
            #endregion HeartShaped

            #region Triangular
            public decimal TriangularShapeWeightCalc(List<DiamondDiameterMeasurement> Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal Length = Diameters.Max(d => d.Diameter);
                decimal Width = Diameters.Min(d => d.Diameter);

                decimal Weight = Length * Width * Depth * .0057m;
                return Weight;
            }
           
            public decimal TriangularShapeWeightCalc(List<DiamondDiameterMeasurement> Diameters, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal DepthMeasurement = 0.00m;
                decimal Width = Diameters.Min(d => d.Diameter);
                DepthMeasurement = TriangularShapeEstimateDepth(Width, Depth);

                return TriangularShapeWeightCalc(Diameters, DepthMeasurement);
            }
            public decimal TriangularShapeEstimateDepth(decimal Width, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be left blank."); }

                if (Width == 0.00m)
                { throw new Exception("Width must be greater than 0.00"); }

                decimal DepthMeasurement = 0.00m;
                switch (Depth)
                {
                    case "Shallow":
                        DepthMeasurement = Width * .30m;
                        break;
                    case "Ideal":
                        DepthMeasurement = Width * .40m;
                        break;
                    case "Deep":
                        DepthMeasurement = Width * .50m;
                        break;
                }
                return DepthMeasurement;
            }

            #endregion Triangular

            #region MarquiseShape
            /* Source http://www.diamondregistry.com/diamond-prices/list-marquise-cut-diamond.htm
            For Marquise ONLY
            Table – The ideal table length of the stone has to be between 
            53 and 63 percent. Do not opt for stones that have table length 
            greater than 70 percent or lower than 50 percent. Depth – The ideal 
            depth for a high quality marquise cut diamond is between 59 and 63 percent. 
            Stones that have a depth greater than 70 percent and less than 50 percent 
            have to be avoided. Crown height – Ideal crown height for the stone is between 
            12 to 15 percent. Diamonds with crown height less than 8 percent and greater 
            than 20 percent is not a good stone. Girdle – Avoid stones that have extremely 
            thin or extremely thick girdle thickness. You can opt for stones that have a 
            thin to thick girdle thickness range. Length to width ratio – Ideally, the length 
            of a high quality marquise cut diamond has to be 1.75 to 2.25 of its width. 
            In simple words, the length of the diamond has to be about twice its width. 
            */

            public decimal MarquiseShapeWeightCalc(List<DiamondDiameterMeasurement> 
                Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal Length = Diameters.Max(d => d.Diameter);
                decimal Width = Diameters.Min(d => d.Diameter);

                decimal LengthToWidthRatio = Length / Width;
                LengthToWidthRatio = decimal.Round(LengthToWidthRatio, 2);
                //Call the Marquise Factor to interpolate the factor
                decimal Factor = MarquiseFactor(Length, Width);

                decimal Weight = Length * Width * Depth * Factor;
                return Weight;
            }
            public decimal MarquiseShapeWeightCalc(List<DiamondDiameterMeasurement> 
                Diameters, String Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal DepthMeasurement = 0.00m;
                decimal Width = Diameters.Min(d => d.Diameter);
                DepthMeasurement = MarquiseShapeEstimateDepth(Width, Depth);

                return MarquiseShapeWeightCalc(Diameters, DepthMeasurement);
            }
            public decimal MarquiseShapeEstimateDepth(decimal Width, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be left blank."); }

                if (Width == 0.00m)
                { throw new Exception("Width must be greater than 0.00"); }

                decimal DepthMeasurement = 0.00m;
                switch (Depth)
                {
                    case "Shallow":
                        DepthMeasurement = Width * .54m;
                        break;
                    case "Ideal":
                        DepthMeasurement = Width * .60m;
                        break;
                    case "Deep":
                        DepthMeasurement = Width * .66m;
                        break;
                }
                return DepthMeasurement;
            }

            #endregion MarquiseShape

            #region PearShape

            public decimal PearShapeWeightCalc(List<DiamondDiameterMeasurement> Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal Length = Diameters.Max(d => d.Diameter);
                decimal Width = Diameters.Min(d => d.Diameter);

                decimal LengthToWidthRatio = Length / Width;
                LengthToWidthRatio = decimal.Round(LengthToWidthRatio, 2);
                decimal Factor = PearShapeFactor(Length, Width);

                decimal Weight = Length * Width * Depth * Factor;
                return Weight;
            }
            public decimal PearShapeWeightCalc(List<DiamondDiameterMeasurement> Diameters, String Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal DepthMeasurement = 0.00m;
                decimal Width = Diameters.Min(d => d.Diameter);
                DepthMeasurement = PearShapeEstimateDepth(Width, Depth);

                return PearShapeWeightCalc(Diameters, DepthMeasurement);
            }
            public decimal PearShapeEstimateDepth(decimal Width, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be left blank."); }

                if (Width == 0.00m)
                { throw new Exception("Width must be greater than 0.00"); }

                decimal DepthMeasurement = 0.00m;
                switch (Depth)
                {
                    case "Shallow":
                        DepthMeasurement = Width * .54m;
                        break;
                    case "Ideal":
                        DepthMeasurement = Width * .60m;
                        break;
                    case "Deep":
                        DepthMeasurement = Width * .69m;
                        break;
                }
                return DepthMeasurement;
            }

            #endregion OvalShape

            #region EmeraldCut

            public decimal EmeraldCutWeightCalc(List<DiamondDiameterMeasurement> Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal Length = Diameters.Max(d => d.Diameter);
                decimal Width = Diameters.Min(d => d.Diameter);

                decimal LengthToWidthRatio = Length / Width;
                LengthToWidthRatio = decimal.Round(LengthToWidthRatio, 2);
                //Call the Marquise Factor to interpolate the factor
                decimal Factor = EmeraldCutFactor(Length, Width);

                decimal Weight = Length * Width * Depth * Factor;
                return Weight;
            }
            public decimal EmeraldCutWeightCalc(List<DiamondDiameterMeasurement> Diameters, String Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal DepthMeasurement = 0.00m;
                decimal Width = Diameters.Min(d => d.Diameter);
                DepthMeasurement = EmeraldCutEstimateDepth(Width, Depth);

                return EmeraldCutWeightCalc(Diameters, DepthMeasurement);
            }
            public decimal EmeraldCutEstimateDepth(decimal Width, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be left blank."); }

                if (Width == 0.00m)
                { throw new Exception("Width must be greater than 0.00"); }

                decimal DepthMeasurement = 0.00m;
                switch (Depth)
                {
                    case "Shallow":
                        DepthMeasurement = Width * .54m;
                        break;
                    case "Ideal":
                        DepthMeasurement = Width * .60m;
                        break;
                    case "Deep":
                        DepthMeasurement = Width * .66m;
                        break;
                }
                return DepthMeasurement;
            }

            #endregion EmeraldCut

            #region PrincessCut
            /*
            Ratio closest to 1.25: Coefficient = 0.0080
            Ratio closest to 1.50: Coefficient = 0.0090
            Ratio closest to 2.00: Coefficient = 0.0100
            Ratio closest to 2.50: Coefficient = 0.0105
             */

            public decimal PrincessCutWeightCalc(List<DiamondDiameterMeasurement> Diameters, decimal Depth)
            {
                if (Depth == 0.00m)
                { throw new Exception("Depth can't be set to 0.00."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal Length = Diameters.Max(d => d.Diameter);
                decimal Width = Diameters.Min(d => d.Diameter);

                decimal LengthToWidthRatio = Length / Width;
                LengthToWidthRatio = decimal.Round(LengthToWidthRatio, 2);
                //Call the Princess Factor to interpolate the factor
                decimal Factor = PrincessCutFactor(Length, Width);

                decimal Weight = Length * Width * Depth * Factor;
                return Weight;
            }
            public decimal PrincessCutWeightCalc(List<DiamondDiameterMeasurement> Diameters, String Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be blank."); }

                if (Diameters.Count == 0)
                { throw new Exception("The list of diameters must contain at least one value."); }

                decimal DepthMeasurement = 0.00m;
                decimal Width = Diameters.Min(d => d.Diameter);
                DepthMeasurement = PrincessCutEstimateDepth(Width, Depth);

                return PrincessCutWeightCalc(Diameters, DepthMeasurement);
            }

            public decimal PrincessCutEstimateDepth(decimal Width, string Depth)
            {
                if (Depth == string.Empty)
                { throw new Exception("Depth can't be left blank."); }

                if (Width == 0.00m)
                { throw new Exception("Width must be greater than 0.00"); }

                decimal DepthMeasurement = 0.00m;
                switch (Depth)
                {
                    case "Shallow":
                        DepthMeasurement = Width * .65m;
                        break;
                    case "Ideal":
                        DepthMeasurement = Width * .70m;
                        break;
                    case "Deep":
                        DepthMeasurement = Width * .78m;
                        break;
                }
                return DepthMeasurement;
            }

            #endregion PrincessCut
        }
        
    }
}  


