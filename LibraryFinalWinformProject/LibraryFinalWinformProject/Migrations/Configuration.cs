namespace LibraryFinalWinformProject.Migrations
{
    using LibraryFinalWinformProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LibraryFinalWinformProject.Classes;

    internal sealed class Configuration : DbMigrationsConfiguration<LibraryFinalWinformProject.Data.LMSdbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibraryFinalWinformProject.Data.LMSdbContext context)
        {
            //  This method will be called after migrating to the latest version.
            User user = new User()
            {
                id = 1,
                Fullname = "Kanan Valizada",
                Username = "admin",
                Password = Encryption.Encrypt("admin"),
                Status = true,
                Level = userLevel.Admin,
                Email = "kenan.veli@yahoo.com",

            };

            context.Users.Add(user);
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
