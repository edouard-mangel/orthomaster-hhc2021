using FluentMigrator;

namespace Database.FluentMigrator
{
    [Migration(202103272104)]
    public class AddProduitAttentesPersonnelles : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Produit-AttentesPersonnelles")
                .WithColumn("IdProduit").AsInt64()
                .WithColumn("IdAttentesPersonnelles").AsInt64();

            Create.ForeignKey("fk_AttentesPersonnelles-Produit_AttentesPersonnellesId_AttentesPersonnelles_Id")
                .FromTable("Produit-AttentesPersonnelles").ForeignColumn("IdAttentesPersonnelles")
                .ToTable("AttentesPersonnelles").PrimaryColumn("Id");

            Create.ForeignKey("fk_AttentesPersonnelles-Produit_ProduitId_Produit_Id")
                .FromTable("Produit-AttentesPersonnelles").ForeignColumn("IdProduit")
                .ToTable("Produit").PrimaryColumn("Id");

            Create.PrimaryKey().OnTable("Produit-AttentesPersonnelles").Columns("IdAttentesPersonnelles", "IdProduit");
            
        }
    }
}
