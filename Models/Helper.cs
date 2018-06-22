using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class Helper
    {
        public static void SetBaseEnitityDefaults(ref Guid RecordGuid, ref DateTime LMD, ref DateTime RCD)
        {
            RecordGuid = Guid.NewGuid();
            LMD = DateTime.Now;
            RCD = DateTime.Now;
        }
    }
}
