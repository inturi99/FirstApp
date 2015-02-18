using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    public class InsertData : System.Data.Entity.MigrateDatabaseToLatestVersion<BreakAwayContext,BreakAwayContext>
    {
       protected override void Seed(BreakAwayContext context)
       {
           context.Destinations.Add(new SecondProject.SecondProjectModel.Destination
           {

               DestionationName = "INDIA",
               Country="INDIA",
               Description="Small Lodging"
              
               
              
           });
           context.SaveChanges();
           context.Lodging.Add(new SecondProject.SecondProjectModel.Lodging { 
               LodgingName="lodgingin in india",
               Owner="Suman",
               DestinationId=1
           });
           context.SaveChanges();
       }
    }
}
