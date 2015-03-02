namespace Cinema5D.Migrations
{
    using Cinema5D.Models;
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
            context.Films.AddOrUpdate(f => f.FilmID,
                new Film { Title = "Film1", RunningTime = 1200, CommandLink = "start command1" },
                new Film { Title = "Film2", RunningTime = 1300, CommandLink = "start command2" }
                );
        }
    }
}
