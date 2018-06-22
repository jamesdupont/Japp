
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GemStones
{
    public class GemShape
    {
        [Key]
        [ScaffoldColumn(false)]
        public int GemShapeID { get; set; }
        [ScaffoldColumn(false)] //[ForeignKey("GemPartToGemShape")]
        public int GemPartID { get; set; }

        [Display(Name = "Shape Name")]
        public string ShapeName { get; set; }

        [Display(Name = "Image Location")]
        public string ImageLocation { get; set; }

        [Display(Name = "Image")]
        public byte[] Image { get; set; }

        [Display(Name = "File Extension")]
        public string FileExtension { get; set; }

        public decimal WeightFactor { get; set; }


    }
}
