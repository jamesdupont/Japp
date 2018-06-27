using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Models;


namespace Models
{
     abstract  public class baseEntity 
    {        
        [Required]
        [ScaffoldColumn(false)]
        public Guid RecordGuid { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public DateTime RCD { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public DateTime LMD { get; set; }

        [Timestamp]
        [ScaffoldColumn(false)]
        public byte[] RowVersion { get; set; }

        public void SetBaseDefaults()
        {
            LMD = DateTime.Now;
            RCD = DateTime.Now;
            RecordGuid = Guid.NewGuid();
        }
    }



    //public class baseEntityConfiguration : EntityTypeConfiguration<baseEntity>
    //{
    //    public baseEntityConfiguration()
    //    {
    //        Property(b => b.RecordGuid).IsRequired();
    //        Property(rcd =>rcd.RCD).IsRequired();
    //        Property(lmd => lmd.LMD).IsRequired();

    //    }
    //}
}
