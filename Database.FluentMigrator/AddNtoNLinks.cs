using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.FluentMigrator
{
    [Migration(202103272100)]
    public class AddNtoNLinks : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Projet-Produit")
                .WithColumn("IdProjet").AsInt64()
                .WithColumn("IdProduit").AsInt64();

            Create.ForeignKey("fk_Projet-Produit_ProjetId_Projet_Id")
                .FromTable("Projet-Produit").ForeignColumn("IdProjet")
                .ToTable("Projet").PrimaryColumn("Id");

            Create.ForeignKey("fk_Projet-Produit_ProduitId_Produit_Id")
                .FromTable("Projet-Produit").ForeignColumn("IdProduit")
                .ToTable("Produit").PrimaryColumn("Id");

            Create.PrimaryKey().OnTable("Projet-Produit").Columns("IdProjet", "IdProduit");
        }
    }
}
