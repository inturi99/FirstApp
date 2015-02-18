namespace TaskManagment.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TaskManagment.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<TaskManagment.Data.TaskManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TaskManagment.Data.TaskManagerContext context)
        {
            var countries = new List<Country>
            {
                new Country
                {
                    CountryName = "India",
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = DateTime.Now,
                    CreatedUserId=Guid.Empty,
                    UpdatedUserId=Guid.Empty,
                   
                    RowStatus = RowStatus.Active
                },
            };
             countries.ForEach(coutry => context.Countries.Add(coutry));
            context.SaveChanges();


            var states = new List<State>
            {
                new State
                {
                    StateName = "Andhrapradesh",
                    CountryId = countries.First(it => it.CountryName == "India").CountryId,
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = DateTime.Now,
                    CreatedUserId=Guid.Empty,
                    UpdatedUserId=Guid.Empty,
                    RowStatus = RowStatus.Active
                },
                new State
                {
                    StateName = "Tamilanadu",
                    CountryId = countries.First(it => it.CountryName == "India").CountryId,
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = DateTime.Now,
                    CreatedUserId=Guid.Empty,
                    UpdatedUserId=Guid.Empty,
                    RowStatus = RowStatus.Active
                },
            };
            context.States.AddRange(states);
            context.SaveChanges();
        }
    }
}
