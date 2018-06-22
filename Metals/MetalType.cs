using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metals
{
    /// <summary>
    /// Look up table for Metal Types
    /// </summary>
    public class MetalType 
    {
        [Key][ScaffoldColumn(false)]
        public int MetalTypeID { get; set; }
             
        public string Name { get; set; }

        public string MetalTypeName { get; set; }

        public string Qualtity { get; set; }

        public string Color { get; set; }

        public decimal SpecificGravity { get; set; }

     }


}
