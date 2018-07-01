namespace NosSeusPesModel.Migrations
{
        using System;
        using System.Data.Entity;
        using System.Data.Entity.Migrations;
        using System.Linq;

        internal sealed class Configuration: DbMigrationsConfiguration<NosSeusPesModel.ModelPedido>
        {
            public Configuration()
            {
                AutomaticMigrationsEnabled = true;
            }

            protected override void Seed(NosSeusPesModel.ModelPedido context)
            {
                if (false)
                {
                    context.PessoasFisicas.RemoveRange(context.PessoasFisicas);
                    context.PessoasJuridicas.RemoveRange(context.PessoasJuridicas);
                    context.Sapatos.RemoveRange(context.Sapatos);
                    context.Pedidos.RemoveRange(context.Pedidos);
                    context.SaveChanges();
                }
               
                context.SaveChanges();
            }
        }
}

