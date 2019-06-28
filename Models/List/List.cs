using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metals;
using GemStones;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Metadata.Edm;

namespace Models.List
{
    public class List
    {

     
       public static ICollection<AddressType> GetAddressTypeList()
        {
            List<AddressType> returnValue = new List<AddressType>();
            returnValue.Add(new AddressType { Name = "Customer"});
            returnValue.Add(new AddressType { Name = "Vendor", });


            return returnValue;

        }
        public static List<string> GetTableNamesInModel()
        {
            using (Models.AlphaContext dbContext = new Models.AlphaContext())
            {
                var metadata = ((IObjectContextAdapter)dbContext).ObjectContext.MetadataWorkspace;

                var tables = metadata.GetItemCollection(DataSpace.SSpace)
                    .GetItems<EntityContainer>()
                    .Single()
                    .BaseEntitySets
                    .OfType<EntitySet>()
                    .Where(s => !s.MetadataProperties.Contains("Type")
                    || s.MetadataProperties["Type"].ToString() == "Tables");

                List<string> returnValue = new List<string>();
                foreach (var table in tables)
                {

                    returnValue.Add(table.Name.ToString());
                    // Console.WriteLine(table.Name.ToString());
                    //var tableName = table.MetadataProperties.Contains("Table")
                    //    && table.MetadataProperties["Table"].Value != null
                    //    ? table.MetadataProperties["Table"].Value.ToString()
                    //    : table.Name;

                    //var tableSchema = table.MetadataProperties["Schema"].Value.ToString();
                    //var sothin = table.MetadataProperties["Schema"].Value.ToString();

                    // Console.WriteLine(tableName);
                    //Console.WriteLine(tableSchema + "." + tableName );
                }
                Console.Read();

                return returnValue;
            }

        }

        public static List<PartType> GetPartTypesList()
        {

            List<PartType> List = new List<PartType>();
            List.Add(new PartType {PartTypeID = 1, PartName = "Metal", Markup = 2m });
            List.Add(new PartType { PartTypeID = 2, PartName = "Gem Stone", Markup = 2m });
            List.Add(new PartType { PartTypeID = 3, PartName = "Single Gem Stone", Markup = 2m });
            List.Add(new PartType { PartTypeID = 4, PartName = "Single Diamond", Markup = 2m });
            List.Add(new PartType { PartTypeID = 5, PartName = "Diamond", Markup = 2m });
            List.Add(new PartType { PartTypeID = 6, PartName = "Labor", Markup = 2m });

            return List;
        }
        public static ICollection<LaborType> GetLaborTypes()
        {
            List < LaborType >  returnValue = new List<LaborType>();
            returnValue.Add(new LaborType { Type = "Stone Setting", PerHourRate = 20.00m});
            returnValue.Add(new LaborType { Type = "Finishing", PerHourRate = 20.00m });
            returnValue.Add(new LaborType { Type = "Soldering", PerHourRate = 20.00m });
            returnValue.Add(new LaborType { Type = "Metal Shaping", PerHourRate = 20.00m });
            returnValue.Add(new LaborType { Type = "Design", PerHourRate = 20.00m });

            return returnValue;

        }

        public static ICollection<ContactType> GetContactTypes()
        {
            List<ContactType> returnValue = new List<ContactType>();
            returnValue.Add(new ContactType { TheName = "Customer", Default = 1, Order = 1 });
            returnValue.Add(new ContactType { TheName = "Vendor", Default = 0, Order = 2 });
         

            return returnValue;

        }
        //public static List<string> PersonTypeValues()
        //{
        //    List<string>



        //    return returnValue;
        //}

    }

}
