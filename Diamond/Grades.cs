using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    public class Grades
    {
        public List<string> GetClarityGrades()
        {
            List<string> returnValue = new List<string>  { "IF", "VVS1", "VVS2", "VS1", "VS2", "SI1", "SI2", "I1", "I2", "I3"};
            return returnValue;
        }

        public List<string> GetColorGrades()
        {
            List<string> returnValue = new List < string > { "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O",
                                                    "Q","R", "S", "T", "U", "V", "W", "X", "Y","Z"};
            return returnValue;
        }
    }
}
