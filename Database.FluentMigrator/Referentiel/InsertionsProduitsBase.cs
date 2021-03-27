using FluentMigrator;
using FluentMigrator.SqlServer;
using System;

namespace Database.FluentMigrator.Referentiel
{
    [Migration(202103272300)]
    public class InsertionsProduitsBase : AutoReversingMigration
    {
        public override void Up()
        {
            InsertIntoProduitProjet();
            InsertIntoProduitActivite();
            InsertIntoProduitSymptomatologie();
            InsertIntoProduitMorphologie();
            InsertIntoProduitAttentesPersonnelles();
        }

        private void InsertReferences()
        {
            
        }

        private void InsertIntoProduitAttentesPersonnelles()
        {
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 1, IdAttentesPersonnelles = 4 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 1, IdAttentesPersonnelles = 7 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 1, IdAttentesPersonnelles = 1 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 1, IdAttentesPersonnelles = 3 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 1, IdAttentesPersonnelles = 8 });
            
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 2, IdAttentesPersonnelles = 3 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 2, IdAttentesPersonnelles = 4 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 2, IdAttentesPersonnelles = 7 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 2, IdAttentesPersonnelles = 8 });
            
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 3, IdAttentesPersonnelles = 1 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 3, IdAttentesPersonnelles = 2 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 3, IdAttentesPersonnelles = 3 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 3, IdAttentesPersonnelles = 5 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 3, IdAttentesPersonnelles = 6 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 3, IdAttentesPersonnelles = 8 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 4, IdAttentesPersonnelles = 5 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 4, IdAttentesPersonnelles = 3 });
            
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 5, IdAttentesPersonnelles = 1 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 5, IdAttentesPersonnelles = 2 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 5, IdAttentesPersonnelles = 3 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 5, IdAttentesPersonnelles = 6 });
            
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 6, IdAttentesPersonnelles = 4 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 6, IdAttentesPersonnelles = 7 });
            
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 7, IdAttentesPersonnelles = 3 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 7, IdAttentesPersonnelles = 5 });
            
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 8, IdAttentesPersonnelles = 1 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 8, IdAttentesPersonnelles = 5 });
            
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 9, IdAttentesPersonnelles = 3 });
            
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 10, IdAttentesPersonnelles = 1 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 10, IdAttentesPersonnelles = 3 });
            Insert.IntoTable("Produit-AttentesPersonnelles").Row(new { IdProduit = 10, IdAttentesPersonnelles = 5 });
        }

        private void InsertIntoProduitMorphologie()
        {
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 1, IdMorphologie = 1 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 1, IdMorphologie = 3 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 1, IdMorphologie = 4 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 1, IdMorphologie = 5 });

            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 2, IdMorphologie = 2 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 2, IdMorphologie = 4 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 2, IdMorphologie = 5 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 2, IdMorphologie = 7 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 2, IdMorphologie = 6 });

            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 3, IdMorphologie = 1 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 3, IdMorphologie = 3 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 3, IdMorphologie = 4 });

            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 4, IdMorphologie = 5 });

            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 5, IdMorphologie = 1 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 5, IdMorphologie = 2 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 5, IdMorphologie = 6 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 5, IdMorphologie = 7 });

            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 6, IdMorphologie = 1 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 6, IdMorphologie = 5 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 6, IdMorphologie = 6 });

            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 7, IdMorphologie = 5 });
            
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 8, IdMorphologie = 5 });
            
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 9, IdMorphologie = 5 });
            
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 10, IdMorphologie = 1 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 10, IdMorphologie = 2 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 10, IdMorphologie = 3 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 10, IdMorphologie = 4 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 10, IdMorphologie = 5 });
            Insert.IntoTable("Produit-Morphologie").Row(new { IdProduit = 10, IdMorphologie = 6 });
        }

        private void InsertIntoProduitActivite()
        {
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 1, IdActivite = 2 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 1, IdActivite = 4 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 1, IdActivite = 5 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 1, IdActivite = 6 });
            
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 2, IdActivite = 2 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 2, IdActivite = 3 });
            
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 3, IdActivite = 1 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 3, IdActivite = 6 });
            
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 4, IdActivite = 1 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 4, IdActivite = 2 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 4, IdActivite = 3 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 5, IdActivite = 1 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 5, IdActivite = 3 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 5, IdActivite = 5 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 5, IdActivite = 6 });
            
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 6, IdActivite = 1 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 6, IdActivite = 4 });
            
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 7, IdActivite = 1 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 7, IdActivite = 2 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 7, IdActivite = 3 });
            
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 8, IdActivite = 1 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 8, IdActivite = 2 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 8, IdActivite = 3 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 9, IdActivite = 2 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 9, IdActivite = 4 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 9, IdActivite = 5 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 9, IdActivite = 6 });
            
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 10, IdActivite = 1 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 10, IdActivite = 2 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 10, IdActivite = 3 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 10, IdActivite = 5 });
            Insert.IntoTable("Produit-Activite").Row(new { IdProduit = 10, IdActivite = 6 });
        }

        private void InsertIntoProduitSymptomatologie()
        {
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 1, IdSymptomatologie = 1 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 1, IdSymptomatologie = 2 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 1, IdSymptomatologie = 3 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 1, IdSymptomatologie = 4 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 2, IdSymptomatologie = 1 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 2, IdSymptomatologie = 2 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 2, IdSymptomatologie = 3 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 2, IdSymptomatologie = 4 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 3, IdSymptomatologie = 2 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 3, IdSymptomatologie = 3 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 3, IdSymptomatologie = 4 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 4, IdSymptomatologie = 5 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 5, IdSymptomatologie = 2 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 5, IdSymptomatologie = 4 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 6, IdSymptomatologie = 2 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 6, IdSymptomatologie = 3 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 7, IdSymptomatologie = 5 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 8, IdSymptomatologie = 5 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 9, IdSymptomatologie = 1 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 9, IdSymptomatologie = 2 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 9, IdSymptomatologie = 3 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 9, IdSymptomatologie = 4 });

            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 10, IdSymptomatologie = 1 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 10, IdSymptomatologie = 2 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 10, IdSymptomatologie = 3 });
            Insert.IntoTable("Produit-Symptomatologie").Row(new { IdProduit = 10, IdSymptomatologie = 4 });
        }

        private void InsertIntoProduitProjet()
        {
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 1, IdProjet = 1 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 1, IdProjet = 2 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 1, IdProjet = 3 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 1, IdProjet = 4 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 2, IdProjet = 4 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 2, IdProjet = 1 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 2, IdProjet = 5 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 2, IdProjet = 2 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 3, IdProjet = 4 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 3, IdProjet = 2 });

            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 4, IdProjet = 1 });

            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 5, IdProjet = 2 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 5, IdProjet = 3 });

            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 6, IdProjet = 1 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 6, IdProjet = 2 });

            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 7, IdProjet = 1 });

            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 8, IdProjet = 1 });

            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 9, IdProjet = 1 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 9, IdProjet = 3 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 9, IdProjet = 2 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 9, IdProjet = 4 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 9, IdProjet = 5 });

            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 10, IdProjet = 1 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 10, IdProjet = 2 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 10, IdProjet = 3 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 10, IdProjet = 4 });
            Insert.IntoTable("Produit-Projet").Row(new { IdProduit = 10, IdProjet = 5 });
        }
    }
}
