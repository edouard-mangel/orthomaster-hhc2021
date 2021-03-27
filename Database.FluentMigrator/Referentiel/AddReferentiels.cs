using FluentMigrator;
using FluentMigrator.SqlServer;

namespace test
{
    [Migration(202103271909)]
    public class AddReferentiels : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Projet")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Label").AsString();                   

            Create.Table("ContreIndications")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Label").AsString();

            Create.Table("Morphologie")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Label").AsString();
            
            Create.Table("Activite")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Label").AsString();
            
            Create.Table("Symptomatologie")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Label").AsString();
            
            Create.Table("AttentesPersonnelles")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Label").AsString();

            InsertData();
        }

        private void InsertData()
        {
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 1, Label = "Antalgie" });
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 2, Label = "Protéger le mouvement" });
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 3, Label = "Eviter une récidive" });
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 4, Label = "Retrouver le mouvement" });
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 5, Label = "Restaurer un tonus musculaire" });

            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 1, Label = "Douleur irradiante dans la jambe" });
            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 2, Label = "Blocage musculaire" });
            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 3, Label = "Périodes de crise" });
            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 4, Label = "Raideur matinale" });
            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 5, Label = "Grossesse" });

            Insert.IntoTable("ContreIndications").WithIdentityInsert().Row(new { Id = 1, Label = "Insuffisance respiratoire" });
            Insert.IntoTable("ContreIndications").WithIdentityInsert().Row(new { Id = 2, Label = "Hernie Hiatale" });
            Insert.IntoTable("ContreIndications").WithIdentityInsert().Row(new { Id = 3, Label = "Hernie Inguinale" });
            Insert.IntoTable("ContreIndications").WithIdentityInsert().Row(new { Id = 4, Label = "Prolapsus" });

            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 1, Label = "Poitrine généreuse" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 2, Label = "Taille de guêpe" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 3, Label = "Ventre bedonnant" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 4, Label = "Hanches larges" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 5, Label = "Hyperlordose" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 6, Label = "Délordose" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 7, Label = "Grosses cuisses" });


            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 1, Label = "Sédentaire" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 2, Label = "Actif / tonique" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 3, Label = "Assis longtemps" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 4, Label = "Activité de force" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 5, Label = "Grande mobilité" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 6, Label = "Transpiration" });

            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 1, Label = "Souplesse " });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 2, Label = "Légèreté" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 3, Label = "Facilité de mise en place" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 4, Label = "Maintien fort" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 5, Label = "Douceur du tissu" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 6, Label = "Discretion" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 7, Label = "Résistance/durabilité" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 8, Label = "Choix de coloris" });
        }
    }
}
