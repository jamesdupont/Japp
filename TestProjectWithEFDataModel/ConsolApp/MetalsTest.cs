using Metals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolApp
{
    public class MetalsTest
    {
        //test Retrieving list data from Metals
        public static void MetalsListDataTest()
            {
            try
            {
                ICollection<Metals.MetalType> MetalTypesList = Data.MetalTypesList();
                foreach (string l in List.GetMetalNames(MetalTypesList))
                {
                    Console.WriteLine(l);

                    foreach (string c in List.QualitiesForMetalType(MetalTypesList, l))
                    {
                        Console.WriteLine("     " + c);
                    }
                    Console.WriteLine();

                }
                Console.Read();
            }
            catch (Exception e)
            {

                throw new Exception("Something went Wrong! ", e);
            }

        }
    
    }
}
