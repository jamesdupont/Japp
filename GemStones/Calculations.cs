using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemStones
{
    public class Calculations
    {
        /*            
            Hereunder the standard formula 
            Round faceted stones: 
            Diameter squared x depth x S.G. x .0018 = ct
            Oval faceted stones:
            Length x width x depth x S.G. x .0020 = ct
            Emerald cut faceted stones: 
            Length x width x depth x S.G. x .0025 = ct
            Rectangular faceted stones: 
            Length x width x depth x S.G. x .0026 = ct
            Square cut faceted stones: 
            Length x width x depth x S.G. x .0023 = ct
            Marquise cut stones, (navette): 
            Length x width x depth x S.G. x .0016 = ct
            Pear cut stones: 
            Length x width x depth x S.G. x .0018 = ct
            Square cushions: 
            Diameter squared x depth x S.G. x .0018 = ct
            Rectangular Cushions: 
            Diameter squared x depth x S.G. x .0022 = ct
            Square step cut stones: 
            Diameter squared x depth x S.G. x .0023 = ct
            Rectangular step cut stones: 
            Length x width x depth x S.G. x .0025 = ct
            Cabochon cut stones: 
            Length x width x depth x S.G. x .0027 = ct 
            Average corner meas & belly meas for cushions,
            L&W for rectangles, etc..
       
             *  */

        public class Weights
        {
            /// <summary>
            /// All weight Calculations use this formula
            /// </summary>
            private static decimal CalculateGemWeight(decimal Length, decimal Width, decimal Depth, decimal AverageSpecificGravity, decimal Factor)
            {
                decimal StoneWeight = 0.00M;

                decimal LengthWidth = Length * Width;

                StoneWeight = (((Length * Width) * Depth) * AverageSpecificGravity) *Factor;

                return StoneWeight;
            }

            public static decimal GemWeight(GemShape shape, GemStoneType gem, decimal Depth, decimal Length, decimal Width)
            {
                return CalculateGemWeight(Length, Width, Depth, gem.AverageSpecificGravity,shape.WeightFactor);
            }

            public static decimal GemWeight(GemShape shape, GemStoneType gem, GemShapeMeasurements measurements)
            {
                var m = measurements.Diameters.GroupBy(d => d.GemShapeMesurementsID)
                    .Select(n => new
                    {
                        Count = n.Count(),
                        Average = n.Average(d => d.Diameter),
                        Max = n.Max(d => d.Diameter),
                        Min = n.Min(d => d.Diameter)
                    });
                                  
                int c = measurements.Diameters.Count();
                if (c >= 2)
                {
                    var a = measurements.Diameters.Average(s => s.Diameter);
                }

                var width = measurements.Diameters.Min(s => s.Diameter);
                var length = measurements.Diameters.Max(s => s.Diameter);

                return GemWeight(shape, gem, measurements.Depth, length, width);
            }

           



            /// <summary>
            /// Calculates the weight of a Round Colored Stone.
            /// </summary>
            /// <formula>
            ///  Round faceted stones: Diameter squared x depth x S.G.x .0018 = ct
            /// </formula>
            /// <param name="AverageDiameter"></param>
            /// <param name="Depth"></param>
            /// <param name="SG"></param>
            /// <returns></returns>
            //public static decimal round(decimal AverageDiameter, decimal Depth, decimal SG)
            //{
            //    if (AverageDiameter == decimal.Zero)
            //    {
            //        throw new Exception("Average Diameter value must be provided.");                   
            //    }

            //    decimal factor = .0018M;
                
            //    //is Depth Null)
            //    if (Depth == 0M)
            //    {
            //        Depth = (decimal.Multiply(AverageDiameter, 0.60M));
            //    }
            //    decimal returnValue = 0.00M;
            //    returnValue =  AverageDiameter * AverageDiameter * Depth * SG * factor;

            //    return returnValue;
            //}
            /// <summary>
            /// 
            /// </summary>
            /// <param name="AverageDiameter"></param>
            /// <param name="SG"></param>
            /// <returns></returns>
          
        }
    }
  

    
}
