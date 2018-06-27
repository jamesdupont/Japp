
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metals;

namespace Metals
{
    public class List
    {
       
        public static ICollection<string> GetMetalNames(ICollection<MetalType> myList)
        {
            ICollection<MetalType> metalType = myList;
            return metalType
                .Select(Item => Item.Name)
                .Distinct()
                .ToList();
        }

        /// <summary>
        /// Metal type for a Metal Name.
        /// </summary>
        /// <example>
        /// 14k Yellow, 10K White, Silver
        /// </example>
        /// <param name="metalType"></param>
        /// <returns>List of Qualities for a MetalType</returns>
        public static ICollection<string> QualitiesForMetalType(ICollection<MetalType> myList, string metalName)
        {

            var returnValue = from m in myList
                              where metalName == m.Name
                              select m.Qualtity;

            return returnValue.ToList();

        }
        /// <summary>
        /// This procedure may not be used
        /// </summary>
        /// <param name="metalType"></param>
        /// <returns></returns>
        public static ICollection<string> ColorForMetalType(ICollection<MetalType> myList, string metalName)
        {

            var returnValue = from m in myList
                              where metalName == m.Name
                              select m.Color;

            return returnValue.ToList();

        }

        public static ICollection<MetalFinish> GetMetalFinishs()
        {
            List<MetalFinish> returnValue = new List<MetalFinish>();

            returnValue.Add(new MetalFinish { Finish = "Polished",  Description="Polished" });
            returnValue.Add(new MetalFinish { Finish = "Florentine", Description = "Lightly scratched surface" });
            returnValue.Add(new MetalFinish { Finish = "Matted", Description = "Lightly scratched surface" });
            returnValue.Add(new MetalFinish { Finish = "Distressed", Description = "Lightly scratched surface" });
            returnValue.Add(new MetalFinish { Finish = "Engraved", Description = "A design pattern engraved into the metal" });

            return returnValue;
        }
       
            
    }
}

