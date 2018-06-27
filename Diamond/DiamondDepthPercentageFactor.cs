using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Diamond
{
    public class DiamondDepthFactorInterpolater
    {
        public int DiamondShapeID { get; set; }

        public int Order { get; set; }

        public decimal Ratio { get; set; }

        public decimal Factor { get; set; }

    }
}
