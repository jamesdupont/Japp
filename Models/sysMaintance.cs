using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace Models
{
    public class sysMaintance
    {
        public static void SeedDatabase(Models.AlphaContext context)
        {
            AddAllStaticData(context);
           // AddTestData(context);
        }
        /// <summary>
        /// Loads Test Data into the database
        /// </summary>
        /// <param name="context"></param>

        public static void AddTestData(Models.AlphaContext context)
        {
            var People = TestData.GetPerson();
            if (context.People.Count() == 0)

            {                
                context.People.AddRange(People);
                context.SaveChanges();
            }

            

            if (context.Customers.Count() == 0)
            {
                context.Customers.AddRange(TestData.GetCustomers(People));
            }
            context.SaveChanges();

            if (context.Vendors.Count() == 0)
            {
                context.Vendors.AddRange(TestData.GetVendor());
            }
            context.SaveChanges();

            if (context.VendorContacts.Count() == 0)
            {
                context.VendorContacts.AddRange(TestData.GetVendorContact());
            }
            context.SaveChanges();

            if (context.CustomerSpecialDates.Count() == 0)
            {
                context.CustomerSpecialDates.AddRange(TestData.GetCustomerSpecialDates());
            }
            context.SaveChanges();

            if (context.Addresses.Count() == 0)
            {
                context.Addresses.AddRange(TestData.GetAddressList());
            }
            context.SaveChanges();

            if (context.EmailAddressess.Count() == 0)
            {
                context.EmailAddressess.AddRange(TestData.GetEmailAddressList());
            }
            context.SaveChanges();

            if (context.Repairs.Count() == 0)
            {
                context.Repairs.AddRange(TestData.GetRepairsList());
            }
            context.SaveChanges();

           if (context.Items.Count() == 0)
                    {
                        context.Items.AddRange(TestData.GetItems());
                    }

            context.SaveChanges();

             if (context.ItemRepairs.Count() == 0)
            {
                context.ItemRepairs.AddRange(TestData.GetRepairItems());
            }
            context.SaveChanges();

            if (context.Parts.Count() == 0)
            {            
                context.Parts.AddRange(TestData.GetParts());
                List<DbEntityValidationResult> errors = context.GetValidationErrors().ToList();
            }
            context.SaveChanges();

            if (context.PartMetals.Count() == 0)
            {
                context.PartMetals.AddRange(TestData.GetMetalParts());
            }
            context.SaveChanges();

            if (context.PartGems.Count() == 0)
            {
              TestData.GetGemParts(context);
            }
          //  context.SaveChanges();

        }
          

        /// <summary>
        /// List lookup data and data that will not change while the program is running
        /// </summary>
        /// <param name="context"></param>
        public static void AddAllStaticData(Models.AlphaContext context)
        {
           
            sysMaintance.AddMetalData(context);
            sysMaintance.AddGemstoneData(context);
            sysMaintance.AddPartTypes(context);
            sysMaintance.AddMetalFinish(context);
            sysMaintance.AddDiamondData(context);
        }

        #region Static data

        public static void AddDiamondData(AlphaContext context)
        {
            int count = context.DiamondShapes.Count();
            if (count == 0)
            {
                context.DiamondShapes.AddRange(Diamond.DiamondData.CreateDiamondShapeList());             
            }

            context.SaveChanges();
        }
        public static void AddGemstoneData(Models.AlphaContext context)
        {
            int count = context.Gemstones.Count();
            if (count == 0)
            {
                context.Gemstones.AddRange(GemStones.GemStonesData.CreateGemStoneData());

                context.GemShapes.AddRange(GemStones.GemStonesData.GemStoneShapesData());
            }
            context.SaveChanges();
        }
        public static void AddMetalData(Models.AlphaContext context)
        {
            int count = context.MetalTypes.Count();
            if (count == 0)
            {
                context.MetalTypes.AddRange(Metals.Data.MetalTypesList());
            }
            context.SaveChanges();
        }
        public static void AddPartTypes (Models.AlphaContext context)
        {
            int count = context.PartTypes.Count();
            if (count == 0)

            {
                context.PartTypes.AddRange(List.List.GetPartTypesList());
            }
            else

            {
                List<PartType> localList = List.List.GetPartTypesList();
                foreach (var item in context.PartTypes)
                {
                    item.PartName = localList.Single(i => i.PartTypeID == item.PartTypeID).PartName;
                    
                }
                //context.People.Single(i => i.LastName == "Beaver").PersonID,
            }

            context.SaveChanges();
        }
        public static void AddMetalFinish(Models.AlphaContext context)
        {
            int count = context.MetalFinish.Count();
            if (count == 0)
            {
                context.MetalFinish.AddRange(Metals.List.GetMetalFinishs());
            }
            context.SaveChanges();
        }

        #endregion End Static Data
    }
}
