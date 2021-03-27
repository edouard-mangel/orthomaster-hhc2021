using FluentMigrator;

namespace Database.FluentMigrator
{
    [Migration(202103272102)]
    public class AddProduitMorphologie: AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Produit-Morphologie")
                .WithColumn("IdProduit").AsInt64()
                .WithColumn("IdMorphologie").AsInt64();

            Create.ForeignKey("fk_Morphologie-Produit_MorphologieId_Morphologie_Id")
                .FromTable("Produit-Morphologie").ForeignColumn("IdMorphologie")
                .ToTable("Morphologie").PrimaryColumn("Id");

            Create.ForeignKey("fk_Morphologie-Produit_ProduitId_Produit_Id")
                .FromTable("Produit-Morphologie").ForeignColumn("IdProduit")
                .ToTable("Produit").PrimaryColumn("Id");

            Create.PrimaryKey().OnTable("Produit-Morphologie").Columns("IdMorphologie", "IdProduit");
            
        }
    }
}
