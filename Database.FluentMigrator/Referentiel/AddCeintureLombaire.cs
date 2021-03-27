using FluentMigrator;

namespace Database.FluentMigrator
{
    [Migration(202103272230)]
    public class AddCeintureLombaire : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("CeintureLombaire")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("IdProduit").AsInt64()
                .WithColumn("Reference").AsString()
                .WithColumn("Couleur").AsString().Nullable()
                .WithColumn("Taille").AsString().Nullable()
                .WithColumn("MesureMin").AsInt32().Nullable()
                .WithColumn("MesureMax").AsInt32().Nullable()
                .WithColumn("HauteurDorsale").AsDecimal().Nullable()
                .WithColumn("HauteurVentrale").AsDecimal().Nullable()
                .WithColumn("CompatiblePetiteTaille").AsBoolean().Nullable();

            Create.ForeignKey("fk_CeintureLombaire_IdProduit_Produit_Id")
                .FromTable("CeintureLombaire").ForeignColumn("IdProduit")
                .ToTable("Produit").PrimaryColumn("Id");
        }
    }
}
