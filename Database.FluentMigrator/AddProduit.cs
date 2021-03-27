using FluentMigrator;
using FluentMigrator.SqlServer;

namespace Database.FluentMigrator
{
    [Migration(202103272036)]
    public class AddProduit : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Produit")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Nom").AsString()
                .WithColumn("Fabricant").AsString();

            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 1, Fabricant = "GIBAUD", Nom = "Lombogib double Action" });

        }
    }
}
