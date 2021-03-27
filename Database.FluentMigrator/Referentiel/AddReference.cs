using FluentMigrator;

namespace Database.FluentMigrator
{
    [Migration(2021032722230)]
    public class AddReference : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("CeintureLombaire")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("IdProduit").AsInt64()
                .WithColumn("Reference").AsString()
                .WithColumn("Couleur").AsString()
                .WithColumn("Taille").AsString()
                .WithColumn("Mesure Min").AsInt32()
                .WithColumn("Mesure Max").AsInt32()
                .WithColumn("HauteurDorsale").AsInt32()
                .WithColumn("HauteurVentrale").AsInt32()
                .WithColumn("CompatiblePetiteTaille").AsBoolean();

            Create.ForeignKey("fk_CeintureLombaire_IdProduit_Produit_Id")
                .FromTable("CeintureLombaire").ForeignColumn("IdProduit")
                .ToTable("Produit").PrimaryColumn("Id");


        }
    }
}
