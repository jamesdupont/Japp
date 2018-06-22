using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Models;


namespace GemStones
{
     abstract public class baseEntity
    {
        //baseEntity()
        //{
        //    SetDefaults();
        //}
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
      
       // virtual public ICollection<Note> Notes { get; set; }

         //SetDefaults()
         //   {
         //       if(RecordGuid == Guid.Empty)
         //       {
         //           RecordGuid = Guid.NewGuid();
         //       }
           
           
         //   }
    }



    public class baseEntityConfiguration : EntityTypeConfiguration<baseEntity>
    {
        public baseEntityConfiguration()
        {
            Property(b => b.RecordGuid).IsRequired();
        }
    }
}
