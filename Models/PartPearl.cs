using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Interfaces;

namespace Models
{
    public class PartPearl : baseEntity, iPart
    {
        public PartPearl()
        {
            Part = new Models.Part();
            SetDefaults();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int PartPearlID { get; set; }
        [Required]
        [ScaffoldColumn(false)]
        public int PartID { get; set; }
        public Part Part { get; set; }
        public void SetDefaults()
        {
            SetBaseDefaults();
        }

        public void SetDescription()
        {
            throw new NotImplementedException();
        }

        public void SetCost()
        {
            throw new NotImplementedException();
        }

        public string GetDescription(string Description)
        {
            throw new NotImplementedException();
        }
    }
}
