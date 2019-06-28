using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Diamond
{
    abstract public class BaseEntity
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
}
