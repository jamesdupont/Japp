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

namespace ConsolApp
{
   public class ListTables
    {

    //    using (Models.alphaContext dbContext = new Models.alphaContext())
    //        {
    //            var metadata = ((IObjectContextAdapter)dbContext).ObjectContext.MetadataWorkspace;

    //var tables = metadata.GetItemCollection(DataSpace.SSpace)
    //    .GetItems<EntityContainer>()
    //    .Single()
    //    .BaseEntitySets
    //    .OfType<EntitySet>()
    //    .Where(s => !s.MetadataProperties.Contains("Type")
    //    || s.MetadataProperties["Type"].ToString() == "Tables");

    //            foreach (var table in tables)
    //            {

    //                Console.WriteLine(table.Name.ToString());


                    //var tableName = table.MetadataProperties.Contains("Table")
                    //    && table.MetadataProperties["Table"].Value != null
                    //    ? table.MetadataProperties["Table"].Value.ToString()
                    //    : table.Name;

                    //var tableSchema = table.MetadataProperties["Schema"].Value.ToString();
                    //var sothin = table.MetadataProperties["Schema"].Value.ToString();

                   // Console.WriteLine(tableName);
                    //Console.WriteLine(tableSchema + "." + tableName );
//                }
//Console.Read();
            }
    }

