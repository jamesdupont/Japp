using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Models
{
    public class PartLabor : baseEntity, iPart
    {
        public PartLabor()
        {
            SetDefaults();
            Part = new Part();
            Employee = new Employee();
        }
        [Key]
        [ScaffoldColumn(false)]
        public int PartLaborID { get; set; }

        [ScaffoldColumn(false)]
        public int PartID { get; set; }

        [Required]
        [Display(Name = "Billable Minutes")]
        public decimal BillableMinutes { get; set; }

        public Part Part { get; set; }

        [ScaffoldColumn(false)]
        public int LaborTypeID { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Hourly Rate")]
        [Required]
        public decimal HourlyRate { get; set; }

        [ScaffoldColumn(false)]
        public int EmployeeID { get; set; }
        virtual public Employee Employee { get; set; }

        public void SetDescription()
        {
            throw new NotImplementedException();
        }
        public void SetDefaults()
        {
            base.SetBaseDefaults();
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
