
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;


namespace Diamond
{
    /// <summary>
    /// This is a transactional table used to store Data about the
    /// </summary>
    public class DiamondMeasurement : baseEntity
    {
            public DiamondMeasurement()
            {
            SetDefaults();
            DiamondDiameterMeasurements = new List<DiamondDiameterMeasurement>();
            DiamondTableMeasurements = new List<DiamondTableMeasurement>();
            }
            [Key] 
            public int DiamondMesurementsID { get; set; }

            //This is the parentID
            public int PartDiamondID { get; set; }
            public decimal Depth { get; set; }
            public bool isEstimatedDepth { get; set; }
        
            public ICollection<DiamondDiameterMeasurement> DiamondDiameterMeasurements { get; set; }
            public ICollection<DiamondTableMeasurement> DiamondTableMeasurements { get; set; }
            public void  SetDefaults()
                {
                    base.SetBaseDefaults();
                    isEstimatedDepth = false;
                }
        public decimal AverageDiameter()
        {
            if (DiamondDiameterMeasurements.Count > 0)
            {
                decimal returnValue = DiamondDiameterMeasurements.Average(d => d.Diameter);
                return returnValue;
            }
            else
            { return 0; }
        }
        public decimal AverageTableMeasurment()
        {
            if (DiamondTableMeasurements.Count() > 0)
            {
                decimal returnValue = DiamondTableMeasurements.Average(d => d.TableMeasurement);
                return returnValue;
            }
            else
            { return 0; }
        }
    }
}

