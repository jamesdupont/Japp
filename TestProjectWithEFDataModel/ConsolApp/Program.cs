using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metals;
using GemStones;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Metadata.Edm;
using Microsoft.Azure; // Namespace for CloudConfigurationManager
using Microsoft.WindowsAzure.Storage; // Namespace for CloudStorageAccount
using Microsoft.WindowsAzure.Storage.Blob; // Namespace for Blob storage types
using Diamond;

namespace ConsolApp
{
    class Program
    {
        static void Main(string[] args)

        {
           DiamondData d =  new DiamondData();
            //byte[] x =  d.imageToByteArray(RoundBrilliant.bmp");

            // var x = Diamond.Calculations.MarquiseLengthToWidthRatio(8.79m, 4.5m);

            using (Models.alphaContext context = new Models.alphaContext())
            {
                //try
                //{ Models.sysMaintance.SeedDatabase(context); }
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //    Console.Read();
                //}

                //List<DiamondShape> ds = DiamondData.CreateDiamondShapeList();
                //var HeartShaped = ds.First<DiamondShape>(dr => dr.ShapeName == "Heart Shape");
                //context.DiamondShapes.Add(HeartShaped);
                //context.SaveChanges();

                var Shape = new DiamondShape();
                Shape = context.DiamondShapes.FirstOrDefault(s => s.ShapeName == "Triangular Shape");

                DiamondMeasurement diaMeasure
                    = new DiamondMeasurement
                    {
                        Depth = 3,
                        DiamondDiameterMeasurements = new List<DiamondDiameterMeasurement>
                            { new DiamondDiameterMeasurement { Diameter = 6m },
                            new DiamondDiameterMeasurement {Diameter = 5.1m},
                            new DiamondDiameterMeasurement {Diameter = 5.22m},
                            new DiamondDiameterMeasurement {Diameter = 5.13m}
                            },
                        DiamondTableMeasurements = new List<DiamondTableMeasurement>
                        { new DiamondTableMeasurement {TableMeasurement = 3m },
                     new DiamondTableMeasurement {TableMeasurement = 3m } }
                    };

                List<string> xr = new List<string>();
                xr.Add("Shallow");
                xr.Add("Ideal");
                xr.Add("Deep");

                try
                {
                   
                        DiamondCalculations.CalculateWeight dc = new DiamondCalculations.CalculateWeight();
                        decimal weight = dc.CalculateDiamondWeight(Shape.ShapeName, diaMeasure.DiamondDiameterMeasurements.ToList(), 3);
                        Console.WriteLine(weight.ToString());
                    
                    Console.Read();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Read();
                }
                bool x = true;

                if (x == true)
                {
                    DiamondCalculations.CalculateWeight dc = new DiamondCalculations.CalculateWeight();
                    try
                    {
                        foreach (string depth in xr)
                        {
                            decimal weight = dc.CalculateDiamondWeight(Shape.ShapeName, diaMeasure.DiamondDiameterMeasurements.ToList(),depth);
                            Console.WriteLine(weight.ToString());
                            Console.Read();
                        }
                        
                    }
                    catch (Exception ex)
                    { Console.WriteLine(ex.Message);
                        Console.Read();
                    }
                }
            } 
              
                          

                        
            //    //context.SaveChanges();

            //foreach (var s in Shapes)
            // {
            //     Console.WriteLine(s.ShapeName);
            // }
            // Console.Read();

            //context.DiamondShapes.AddRange(Shapes);
            //context.SaveChanges();

            // }



            //////// Parse the connection string and return a reference to the storage account.
            //////CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
            //////    CloudConfigurationManager.GetSetting("StorageConnectionString"));

            //////CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            //////// Retrieve a reference to a container.
            //////CloudBlobContainer container = blobClient.GetContainerReference("appimages");

            ////////// Create the container if it doesn't already exist.
            //////container.CreateIfNotExists();



            //  Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Models.alphaContext>());

            // MetalsTest.MetalsListDataTest();

            //GemsTest.GemShapeTest();

            // GemsTest.GemTest();

            // CustomerTest.getCustomerSeedData();

            // Models.alphaContext cont = new Models.alphaContext();

            //CustomerTest.getCustomerSeedData();

            //using (Models.alphaContext context = new Models.alphaContext())
            //{
            //    Models.sysMaintance.AddAllStaticData(context);
            //    Models.sysMaintance.AddTestData(context);

            //    //context.ItemRepairs.AddRange(Models.TestData.GetRepairItems(1));
            //    //context.PartMetals.AddRange(Models.TestData.GetMetalParts(1));
            //    //context.PartGems.AddRange(Models.TestData.GetGemParts(1));

            //    context.SaveChanges();
            //}
        } 
        
          
    }
}
