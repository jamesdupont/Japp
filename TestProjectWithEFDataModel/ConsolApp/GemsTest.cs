using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemStones;
using System.IO;
using Models;

namespace ConsolApp
{
    public class GemsTest
    {
        public static void GemShapeTest()
        {
            try
            {
                ICollection<GemShape> shapes = GemStonesData.GemStoneShapesData();
                foreach (GemShape s in shapes)
                {
                   
                    Console.WriteLine(string.Format("{0}\t\t\t{1}", s.ShapeName, s.ImageLocation));
                  
                }
                Console.Read();
                
            }
            catch (Exception e)
            {

                throw new Exception("Something went Wrong! ", e);
            }
        }

        public static void GemTest()
        {
            try
            {
                string x = string.Empty;
                ICollection<GemStoneType> gems = new List<GemStoneType>();
                ICollection<GemShape> shapes = new List<GemShape>();
                GemShapeMeasurements measure1 = new GemShapeMeasurements
                {
                    GemShapeMesurementsID = 2,
                    Depth = 3.81M,
                    Diameters = { new GemDiameterMeasurement { GemDiameterMeasurementsID  = 1,  GemShapeMesurementsID = 2, Diameter = 6 },
                new GemDiameterMeasurement { GemDiameterMeasurementsID = 2, GemShapeMesurementsID = 2, Diameter = 6.11M },
                new GemDiameterMeasurement { GemDiameterMeasurementsID = 3, GemShapeMesurementsID = 2, Diameter = 6.10M },
                new GemDiameterMeasurement { GemDiameterMeasurementsID = 4, GemShapeMesurementsID = 2, Diameter = 6.32M },
               new GemDiameterMeasurement { GemDiameterMeasurementsID = 5, GemShapeMesurementsID = 2, Diameter = 6.12M } }
                };
                GemShapeMeasurements measure2 = 
               new GemShapeMeasurements
               {
                   GemShapeMesurementsID = 2,
                   Depth = 3.81M,
                   Diameters = {
               new GemDiameterMeasurement { GemDiameterMeasurementsID = 6, GemShapeMesurementsID = 3, Diameter = 8 },
               new GemDiameterMeasurement { GemDiameterMeasurementsID = 6, GemShapeMesurementsID = 3, Diameter = 12 },
               new GemDiameterMeasurement { GemDiameterMeasurementsID = 7, GemShapeMesurementsID = 3, Diameter = 10 } }
               };

                gems = GemStonesData.CreateGemStoneData();
                shapes = GemStonesData.GemStoneShapesData();
                foreach (GemStoneType g in gems)
                {

                    Console.WriteLine(string.Format("{0}\t\t\t{1}", g.GemName, g.AverageSpecificGravity));
                    foreach (GemShape s in shapes)
                    {
                        Console.WriteLine(string.Format("{0}\t\t\t{1}", s.ShapeName, s.WeightFactor));
                           
                        if (s.ShapeName == "Round")
                        {
                            var width = measure1.Diameters.Min(d => d.Diameter);
                            var length = measure1.Diameters.Max(d => d.Diameter);
                            Console.WriteLine(string.Format("\t\t\tWidth{0}Length{1}", width,length));
                            Console.WriteLine(Calculations.Weights.GemWeight(s, g, measure1));
                        }
                        else
                        {
                            var width = measure2.Diameters.Min(d => d.Diameter);
                            var length = measure2
                                .Diameters.Max(d => d.Diameter);
                            Console.WriteLine(string.Format("\t\t\tWidth{0}Length{1}", width, length));
                            Console.WriteLine(Calculations.Weights.GemWeight(s, g, measure2));
                        }
                        Console.ReadLine
                            ();
                    }
                    x = Console.ReadLine();

                    
                }
                Models.PartGem p = new PartGem();
               
               Console.ReadLine();



                
            }
            catch (Exception e)
            {

                throw new Exception("Something went Wrong! ", e);
            }

            
        }
    }
}
