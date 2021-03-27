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
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 2, Fabricant = "GIBAUD", Nom = "Lombogib évolution" });
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 3, Fabricant = "GIBAUD", Nom = "Lombogib underwear" });
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 4, Fabricant = "GIBAUD", Nom = "Lombogib maternity" });
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 5, Fabricant = "DONJOY", Nom = "Porostrap" });
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 6, Fabricant = "DONJOY", Nom = "Immostrap" });
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 7, Fabricant = "DONJOY", Nom = "MyBabystrap" });
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 8, Fabricant = "THUASNE", Nom = "Lombamum" });
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 9, Fabricant = "THUASNE", Nom = "Lombatech" });
            Insert.IntoTable("Produit").WithIdentityInsert().Row(new { Id = 10, Fabricant = "THUASNE", Nom = "Lombacross activity" });
        }
    }
}
