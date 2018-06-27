using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ConsolApp
{
   public class Repairs
    {
        List<Repair> r = new List<Repair>();

        public Repair CreateRepair(Customer cust)
        {

            //r.Add{new Repair { Customer = cust,
            //                    RepairItems = new List<ItemRepair> {new ItemRepair {
            //                                        Description = "This is a ring.",
            //                                         Instruction= "Fix Ring!"
            //                                        , ItemType = "Ring",
            //                                         EstimatedValue = 300.00m,
            //                                         Parts = new List<Part> {
            //                                             new PartMetal {
            //                                                 MetalType = } } } 
            //foreach (Repair val in r)
            //{
            //    foreach (ItemRepair ri in val.RepairItems)
            //    {
            //       // Repair Items
            //    }
            //}

            return new Repair();
        }

    }
}
