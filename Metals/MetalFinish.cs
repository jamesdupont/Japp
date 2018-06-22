using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metals
{
    public class MetalFinish 
    {
        [Key]
        [ScaffoldColumn(false)]
        public int MetalFinishID { get; set; }

        public string Finish { get; set; }
        [MaxLength(100,ErrorMessage = "{0} can have a max of {1} characters") ]
        public string Description { get; set; }
    }
}
