using FluentMigrator;

namespace Database.FluentMigrator
{
    [Migration(202103272103)]
    public class AddProduitSymptomatologie: AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Produit-Symptomatologie")
                .WithColumn("IdProduit").AsInt64()
                .WithColumn("IdSymptomatologie").AsInt64();

            Create.ForeignKey("fk_Symptomatologie-Produit_SymptomatologieId_Symptomatologie_Id")
                .FromTable("Produit-Symptomatologie").ForeignColumn("IdSymptomatologie")
                .ToTable("Symptomatologie").PrimaryColumn("Id");

            Create.ForeignKey("fk_Symptomatologie-Produit_ProduitId_Produit_Id")
                .FromTable("Produit-Symptomatologie").ForeignColumn("IdProduit")
                .ToTable("Produit").PrimaryColumn("Id");

            Create.PrimaryKey().OnTable("Produit-Symptomatologie").Columns("IdSymptomatologie", "IdProduit");            
        }
    }
}
