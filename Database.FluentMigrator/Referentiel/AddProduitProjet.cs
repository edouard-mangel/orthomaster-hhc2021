using FluentMigrator;

namespace Database.FluentMigrator
{
    [Migration(202103272100)]
    public class AddProduitProjet : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Produit-Projet")
                .WithColumn("IdProjet").AsInt64()
                .WithColumn("IdProduit").AsInt64();

            Create.ForeignKey("fk_Projet-Produit_ProjetId_Projet_Id")
                .FromTable("Produit-Projet").ForeignColumn("IdProjet")
                .ToTable("Projet").PrimaryColumn("Id");

            Create.ForeignKey("fk_Projet-Produit_ProduitId_Produit_Id")
                .FromTable("Produit-Projet").ForeignColumn("IdProduit")
                .ToTable("Produit").PrimaryColumn("Id");

            Create.PrimaryKey().OnTable("Produit-Projet").Columns("IdProjet", "IdProduit");
            
        }
    }
}
