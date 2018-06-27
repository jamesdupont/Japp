using System;
using System.Collections.Generic;

namespace Models
{
    interface IBaseEntity
    {
        DateTime LMD { get; set; }
        ICollection<Note> Notes { get; set; }
        DateTime RCD { get; set; }
        Guid RecordGuid { get; set; }
        byte[] RowVersion { get; set; }
    }
}