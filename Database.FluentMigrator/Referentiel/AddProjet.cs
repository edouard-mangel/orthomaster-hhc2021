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
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 1, Label = "antalgie" });
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 2, Label = "protéger le mouvement" });
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 3, Label = "éviter une récidive" });
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 4, Label = "retrouver le mouvement" });
            Insert.IntoTable("Projet").WithIdentityInsert().Row(new { Id = 5, Label = "restaurer un tonus musculaire" });

            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 1, Label = "douleur irradiante dans la jambe" });
            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 2, Label = "blocage musculaire" });
            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 3, Label = "périodes de crise" });
            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 4, Label = "raideur matinale" });
            Insert.IntoTable("Symptomatologie").WithIdentityInsert().Row(new { Id = 5, Label = "grossesse" });

            Insert.IntoTable("ContreIndications").WithIdentityInsert().Row(new { Id = 1, Label = "Insuffisance respiratoire" });
            Insert.IntoTable("ContreIndications").WithIdentityInsert().Row(new { Id = 2, Label = "Hernie Hiatale" });
            Insert.IntoTable("ContreIndications").WithIdentityInsert().Row(new { Id = 3, Label = "Hernie Inguinale" });
            Insert.IntoTable("ContreIndications").WithIdentityInsert().Row(new { Id = 4, Label = "Prolapsus" });

            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 1, Label = "Poitrine généreuse" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 2, Label = "taille de guêpe" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 3, Label = "ventre bedonnant" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 4, Label = "hanches larges" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 5, Label = "hyperlordose" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 6, Label = "délordose" });
            Insert.IntoTable("Morphologie").WithIdentityInsert().Row(new { Id = 7, Label = "grosses cuisses" });

            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 1, Label = "sédentaire" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 2, Label = "actif / tonique" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 3, Label = "assis longtemps" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 4, Label = "activité de force" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 5, Label = "grande mobilité" });
            Insert.IntoTable("Activite").WithIdentityInsert().Row(new { Id = 6, Label = "transpiration" });


            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 1, Label = "souplesse " });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 2, Label = "légèreté" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 3, Label = "facilité de mise en place" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 4, Label = "maintien fort" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 5, Label = "douceur du tissu" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 6, Label = "discretion" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 7, Label = "resistance/durabilité" });
            Insert.IntoTable("AttentesPersonnelles").WithIdentityInsert().Row(new { Id = 8, Label = "choix de coloris" });
        }
    }
}
