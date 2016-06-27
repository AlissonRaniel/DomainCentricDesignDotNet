namespace ProjetoDDD.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoDDD.Infra.Data.Entity.BancoDeDados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjetoDDD.Infra.Data.Entity.BancoDeDados context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Fornecedores.AddOrUpdate(
                f => p.Name,
                new Fornecedor { Name = "Rio do Peixe"},
                new Fornecedor { Name = "Safra de ouro"},
                new Fornecedor { Name = "São Braz"}
            );

        }
    }
}
