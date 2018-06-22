
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace GemStones
{
    public class GemStonesData
    {
        public static ICollection<GemStoneType> CreateGemStoneData()
        {
           

            ICollection<GemStoneType> Gems = new List<GemStoneType>();
            //Amethyst
            Gems.Add(new GemStoneType
            {
                GemStoneTypeID = 1,
                GemName = "Amethyst",
                SpecificGravityLowRange = 2.65m,
                SpecificGravityHighRange = 2.65m,
                Birefringence = "",
                BirthstoneMonth = "February",
                ChemicalFormula = "SiO2",
                CrystlStructure = "Hexagonal",
                GemMineral = "Quartz",
                MosHardnessRange = "7.0",
                RefractiveIndexLowRange = 1.532M,
                RefractiveIndexHighRange = 1.554M,
                GemStoneLocations = { new GemStoneLocation {GemStoneTypeID = 1, CityRegion = "Minas Gerais", Country = "Brazil" },
                    new GemStoneLocation { GemStoneTypeID = 1, CityRegion = "", Country = "Uruguay" } }
            });

            ////Agate
            {
                Gems.Add(new GemStoneType
                {
                    GemStoneTypeID = 2,
                    GemName = "Agate",
                    SpecificGravityLowRange = 2.65m,
                    SpecificGravityHighRange = 2.65m,
                    Birefringence = "",
                    BirthstoneMonth = "",
                    ChemicalFormula = "SiO2",
                    CrystlStructure = "Hexagonal",
                    GemMineral = "Quartz",
                    MosHardnessRange = "7.0",
                    RefractiveIndexLowRange = 1.530M,
                    RefractiveIndexHighRange = 1.550M,
                    GemStoneLocations = { new GemStoneLocation { GemStoneTypeID = 2, CityRegion = "Arizona", Country = "USA" } }

                });
                ////Alexandrite
                Gems.Add(new GemStoneType
                {
                    GemStoneTypeID = 3,
                    GemName = "Alexandrite",
                    SpecificGravityLowRange = 3.68m,
                    SpecificGravityHighRange = 3.78m,
                    Birefringence = "",
                    BirthstoneMonth = "June",
                    ChemicalFormula = "BeAl2O4",
                    CrystlStructure = "Orthorhonbic",
                    GemMineral = "Chrysoberyl",
                    MosHardnessRange = "8.5",
                    RefractiveIndexLowRange = 1.746M,
                    RefractiveIndexHighRange = 1.755M,
                    GemStoneLocations = { new GemStoneLocation {GemStoneTypeID = 3, CityRegion = "", Country = "Sri Lanka (Ceylon)"  },
                    new GemStoneLocation { GemStoneTypeID = 3, CityRegion = "", Country = "Brazil" },
                    new GemStoneLocation { GemStoneTypeID = 3, CityRegion = "", Country = "Zimbabwe"  },
                    new GemStoneLocation { GemStoneTypeID = 3, CityRegion = "", Country = "Tanzania" }
                    }
                });
            }

            //Gems

            return Gems;
        }



        public static ICollection<GemShape> GemStoneShapesData()
        {
            string ImagePath = "\\GemStones\\Images\\";

            List<GemShape> returnValue = new List<GemShape>();

            returnValue.Add(new GemShape { GemShapeID = 1, ShapeName = "Round", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0018M });
            returnValue.Add(new GemShape { GemShapeID = 2, ShapeName = "Marquise", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0016M });
            returnValue.Add(new GemShape { GemShapeID = 3, ShapeName = "Oval", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0020M });
            returnValue.Add(new GemShape { GemShapeID = 4, ShapeName = "Princess", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0023M });
            returnValue.Add(new GemShape { GemShapeID = 5, ShapeName = "Emerald", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0025M });
            returnValue.Add(new GemShape { GemShapeID = 6, ShapeName = "Square Cushion", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0018M });
            returnValue.Add(new GemShape { GemShapeID = 6, ShapeName = "Rectangular Cushion", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0022M });
            returnValue.Add(new GemShape { GemShapeID = 7, ShapeName = "Heart", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .001M });//Fix WeightFactor
            returnValue.Add(new GemShape { GemShapeID = 8, ShapeName = "Baguette", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0025M });
            //Averge the width
            returnValue.Add(new GemShape { GemShapeID = 9, ShapeName = "Tappered Baguette", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0025M });
            returnValue.Add(new GemShape { GemShapeID = 9, ShapeName = "Pear", ImageLocation = ImagePath + "Asset 2", FileExtension = ".png", WeightFactor = .0018M });

            return returnValue;

        }

        public static ICollection<GemShapeMeasurements> GemShapeMeasurementsData()
        {
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
            ICollection<GemShapeMeasurements> returnValue = new List<GemShapeMeasurements>();
            returnValue.Add(measure1);
            returnValue.Add(measure2);
            return returnValue;
        }

    }
}
