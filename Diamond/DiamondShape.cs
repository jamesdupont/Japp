using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diamond
{
    /// <summary>
    /// This is a look up table and should
    /// be populated with static Data
    /// </summary>
    public class DiamondShape
    {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            [ScaffoldColumn(false)]
            public int DiamondShapeID { get; set; }

            [Display(Name = "Shape Name")]
            public string ShapeName { get; set; }

            [Display(Name = "Plot Diagram")]
            public byte[] PlotDiagram { get; set; }     
        
         
        
        }
    }

