using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class DiamondData
    {
        private static byte[] imageToByteArray(string ImageName)
        {
            string p =  "C:/Users/James/OneDrive/LaptopFiles/Documents/Visual Studio 2015/Projects/Diamond/Images/";
            // Create image.
            Image newImage = Image.FromFile(p + ImageName);

            MemoryStream ms = new MemoryStream();
            newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
      
        public static List<DiamondShape> CreateDiamondShapeList()
        {
           // byte[] x = imageToByteArray("/RoundBrilliant.bmp");
            ICollection<DiamondShape> Shapes = new List<DiamondShape>();
            //Shapes
            Shapes.Add(
                new DiamondShape
                {
                    DiamondShapeID = 1,
                    ShapeName = "Round Brilliant",
                    PlotDiagram = imageToByteArray("RoundBrilliant.bmp")
                });
            Shapes.Add(
               new DiamondShape
               {
                   DiamondShapeID = 2,
                   ShapeName = "Oval Shape",
                   PlotDiagram = imageToByteArray("OvalShape.bmp")
               });
            Shapes.Add(
               new DiamondShape
               {
                   DiamondShapeID = 3,
                   ShapeName = "Emerald Cut",
                   PlotDiagram = imageToByteArray("EmeraldCut.bmp")
               });
            Shapes.Add(
               new DiamondShape
               {
                   DiamondShapeID = 5,
                   ShapeName = "Marquise Shape",
                   PlotDiagram = imageToByteArray("MarquiseShape.bmp")
               });
            Shapes.Add(
               new DiamondShape
               {
                   DiamondShapeID = 6,
                   ShapeName = "Princess Shape",
                   PlotDiagram = imageToByteArray("PrincessShape.bmp")
               });

            Shapes.Add(
               new DiamondShape
               {
                   DiamondShapeID = 7,
                   ShapeName = "Triangular Shape",
                   PlotDiagram = imageToByteArray("TriangularShape.bmp")
               });
            Shapes.Add(
               new DiamondShape
               {
                   DiamondShapeID = 8,
                   ShapeName = "Pear Shape",
                   PlotDiagram = imageToByteArray("PearShape.bmp")
               });
            Shapes.Add(
              new DiamondShape
              {
                  DiamondShapeID = 9,
                  ShapeName = "Asure Cut",
                  PlotDiagram = imageToByteArray("AsureCut.bmp")
              });
            Shapes.Add(
               new DiamondShape
               {
                   DiamondShapeID = 10,
                   ShapeName = "Heart Shape",
                   PlotDiagram = imageToByteArray("HeartShape.bmp")
               });

            return Shapes.ToList();
        }
    } }
