using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
   public class PartType : baseEntity
    {
        
        public PartType()
        {
            SetDefault();
        }

        [Key]
        public int PartTypeID { get; set; }
       
        [Required][Display(Name ="Part Type")]
        public string PartName { get; set; }

        [Required]
        public decimal Markup { get; set; }
        public void SetDefault()
        {
            SetBaseDefaults();
            Markup = 2m;
        }

    }
}
