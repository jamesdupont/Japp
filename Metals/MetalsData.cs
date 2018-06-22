using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metals
{
//    To determine the volume of your object based on its shape you can use any of the following formulas 
//        or combination of formulas(for objects with a complex form):
//Rectangle / Square / Cube: Length multiplied by Width multiplied by Height
//Pyramid: Length multiplied by Height divided by three.
//Cylinder: 3.14 (pi(?)) multiplied by the square of the base’s Radius.The result multiplied by the Height of the cylinder.
//Cone: 3.14 (pi (?)) multiplied by the square of the base’s Radius.The result multiplied by the Height of the cone. Divide by 3.
   public class Data
    {
        /// <summary>
        /// Used for populating database table with MetalTypes Initial Data
        /// </summary>
        /// <returns>List of MetalTypes</returns>

        public static ICollection<MetalType> MetalTypesList()
        {
            List<MetalType> returnValue = new List<MetalType>();
            returnValue.Add(new MetalType { MetalTypeID = 1, Name = "White Gold", MetalTypeName = "Gold", Qualtity = "14K", Color = "White", SpecificGravity = 12.6M });
            returnValue.Add(new MetalType { MetalTypeID = 2, Name = "White Gold", MetalTypeName = "Gold", Qualtity = "10K", Color = "White", SpecificGravity = 11.07M });
            returnValue.Add(new MetalType { MetalTypeID = 3, Name = "White Gold", MetalTypeName = "Gold", Qualtity = "18K", Color = "White", SpecificGravity = 14.64M });

            returnValue.Add(new MetalType { MetalTypeID = 4, Name = "Yellow Gold", MetalTypeName = "Gold", Qualtity = "14K", Color = "Yellow", SpecificGravity = 13.07M });
            returnValue.Add(new MetalType { MetalTypeID = 5, Name = "Yellow Gold", MetalTypeName = "Gold", Qualtity = "10K", Color = "Yellow", SpecificGravity = 11.57M });
            returnValue.Add(new MetalType { MetalTypeID = 6, Name = "Yellow Gold", MetalTypeName = "Gold", Qualtity = "18K", Color = "Yellow", SpecificGravity = 15.58M });

            returnValue.Add(new MetalType { MetalTypeID = 7, Name = "Rose Gold", MetalTypeName = "Gold", Qualtity = "14K", Color = "Rose", SpecificGravity = 13.26M });
            returnValue.Add(new MetalType { MetalTypeID = 8, Name = "Rose Gold", MetalTypeName = "Gold", Qualtity = "10K", Color = "Rose", SpecificGravity = 11.59M });
            returnValue.Add(new MetalType { MetalTypeID = 9, Name = "Rose Gold", MetalTypeName = "Gold", Qualtity = "18K", Color = "Rose", SpecificGravity = 15.18M });

            returnValue.Add(new MetalType { MetalTypeID = 10, Name = "Green Gold", MetalTypeName = "Gold", Qualtity = "14K", Color = "Green", SpecificGravity = 14.2M });
            returnValue.Add(new MetalType { MetalTypeID = 11, Name = "Green Gold", MetalTypeName = "Gold", Qualtity = "10K", Color = "Green", SpecificGravity = 11.03M });
            returnValue.Add(new MetalType { MetalTypeID = 12, Name = "Green Gold", MetalTypeName = "Gold", Qualtity = "18K", Color = "Green", SpecificGravity = 15.9M });

            returnValue.Add(new MetalType { MetalTypeID = 13, Name = "Silver", MetalTypeName = "Silver", Qualtity = "Sterling", Color = string.Empty, SpecificGravity = 10.36M });
            returnValue.Add(new MetalType { MetalTypeID = 14, Name = "Silver", MetalTypeName = "Silver", Qualtity = "Continum", Color = string.Empty, SpecificGravity = 10.36M });
            returnValue.Add(new MetalType { MetalTypeID = 15, Name = "Silver", MetalTypeName = "Silver", Qualtity = "Fine", Color = string.Empty, SpecificGravity = 10.49M });
            returnValue.Add(new MetalType { MetalTypeID = 16, Name = "Silver", MetalTypeName = "Silver", Qualtity = "Sterlium", Color = string.Empty, SpecificGravity = 10.36M });

            returnValue.Add(new MetalType { MetalTypeID = 17, Name = "Platinum", MetalTypeName = "Platinum", Qualtity = "585", Color = string.Empty, SpecificGravity = 0.00M });
            returnValue.Add(new MetalType { MetalTypeID = 18, Name = "Platinum", MetalTypeName = "Platinum", Qualtity = "PLIR", Color = string.Empty, SpecificGravity =21.45M });
            returnValue.Add(new MetalType { MetalTypeID = 19, Name = "Platinum", MetalTypeName = "Platinum", Qualtity = "PLCO", Color = string.Empty, SpecificGravity = 21.45M });
            returnValue.Add(new MetalType { MetalTypeID = 20, Name = "Platinum", MetalTypeName = "Platinum", Qualtity = "PLRU", Color = string.Empty, SpecificGravity = 21.45M });

            returnValue.Add(new MetalType { MetalTypeID = 21, Name = "Palladium", MetalTypeName = "Palladium", Qualtity = string.Empty, Color = string.Empty, SpecificGravity = 0.00M });

            return returnValue;
        }
    }
}
