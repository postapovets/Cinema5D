namespace Cinema5D.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cinema5D.Models.Cinema5DContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cinema5D.Models.Cinema5DContext context)
        {
            //  TODO: Додати тестове наповнення до табличок
        }
    }
}
