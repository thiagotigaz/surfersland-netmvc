
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SurfersLand.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SurfersLand.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}