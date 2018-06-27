using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diamond
{
    public class DiamondVisualDepthPercentage
    {

        public int DiamondVisualDepthPercentageID { get; set; }

        public int DiamondShapeID { get; set; }

        public int Order { get; set; } 
        public string DepthOfDiamond { get; set; }

        public decimal DepthPercentatage { get; set; }

        public DiamondShape DiamondShape { get; set; }



    }
}
