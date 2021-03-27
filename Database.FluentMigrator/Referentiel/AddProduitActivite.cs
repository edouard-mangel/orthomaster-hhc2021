using FluentMigrator;

namespace Database.FluentMigrator
{
    [Migration(202103272101)]
    public class AddProduitActivite : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Produit-Activite")
                .WithColumn("IdProduit").AsInt64()
                .WithColumn("IdActivite").AsInt64();

            Create.ForeignKey("fk_Activite-Produit_ActiviteId_Activite_Id")
                .FromTable("Produit-Activite").ForeignColumn("IdActivite")
                .ToTable("Activite").PrimaryColumn("Id");

            Create.ForeignKey("fk_Activite-Produit_ProduitId_Produit_Id")
                .FromTable("Produit-Activite").ForeignColumn("IdProduit")
                .ToTable("Produit").PrimaryColumn("Id");

            Create.PrimaryKey().OnTable("Produit-Activite").Columns("IdActivite", "IdProduit");
            
        }
    }
}
