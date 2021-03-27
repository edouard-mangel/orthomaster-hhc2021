using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.FluentMigrator.Referentiel
{

    [Migration(202103272315)]
    public class InsertionCeintureLombaire : AutoReversingMigration
    {
        public override void Up()
        {
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 70, MesureMax = 80, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T0", Reference = 3322541037961 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 80, MesureMax = 90, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T1 ", Reference = 3322541037978 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 90, MesureMax = 100, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T2", Reference = 3322541037985 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 100, MesureMax = 110, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T3", Reference = 3322541037992 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 110, MesureMax = 125, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T4 ", Reference = 3322541038005 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 125, MesureMax = 140, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T5 ", Reference = 3322541038012 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 70, MesureMax = 80, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T0", Reference = 3322541038029 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 80, MesureMax = 90, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T1 ", Reference = 3322541038036 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 90, MesureMax = 100, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T2", Reference = 3322541038043 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 100, MesureMax = 110, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T3", Reference = 3322541038050 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 110, MesureMax = 125, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T4 ", Reference = 3322541038067 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 1, MesureMin = 125, MesureMax = 140, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T5 ", Reference = 3322541038074 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 70, MesureMax = 80, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T0", Reference = 3322541035660 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 80, MesureMax = 90, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T1 ", Reference = 3322541000903 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 100, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T2", Reference = 3322541000910 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 100, MesureMax = 110, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T3", Reference = 3322541000927 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 110, MesureMax = 125, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T4 ", Reference = 3322541000934 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 125, MesureMax = 140, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T5 ", Reference = 3322541000941 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 70, MesureMax = 80, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T0", Reference = 3322541035363 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 80, MesureMax = 90, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T1 ", Reference = 3322541035370 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 100, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T2", Reference = 3322541035387 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 100, MesureMax = 110, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T3", Reference = 3322541035094 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 110, MesureMax = 125, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T4 ", Reference = 3322541035400 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 1, CompatiblePetiteTaille = 0, MesureMin = 125, MesureMax = 140, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T5 ", Reference = 3322541035417 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 70, MesureMax = 80, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T0", Reference = 3322541038081 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 80, MesureMax = 90, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T1 ", Reference = 3322541038098 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 90, MesureMax = 100, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T2", Reference = 3322541038104 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 100, MesureMax = 110, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T3", Reference = 3322541038173 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 110, MesureMax = 125, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T4 ", Reference = 3322541038180 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 125, MesureMax = 140, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T5 ", Reference = 3322541038135 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 70, MesureMax = 80, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T0", Reference = 3322541038142 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 80, MesureMax = 90, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T1 ", Reference = 3322541038159 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 90, MesureMax = 100, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T2", Reference = 3322541038166 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 100, MesureMax = 110, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T3", Reference = 3322541038173 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 110, MesureMax = 125, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T4 ", Reference = 3322541038180 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 1, MesureMin = 125, MesureMax = 140, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T5 ", Reference = 3322541038197 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 70, MesureMax = 80, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T0", Reference = 3322541035486 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 80, MesureMax = 90, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T1 ", Reference = 3322541035493 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 100, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T2", Reference = 3322541035509 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 100, MesureMax = 110, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T3", Reference = 3322541035516 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 110, MesureMax = 125, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T4 ", Reference = 3322541035523 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 125, MesureMax = 140, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T5 ", Reference = 3322541035530 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 70, MesureMax = 80, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T0", Reference = 3322541035547 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 80, MesureMax = 90, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T1 ", Reference = 3322541035554 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 100, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T2", Reference = 3322541035561 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 100, MesureMax = 110, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T3", Reference = 3322541035578 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 110, MesureMax = 125, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T4 ", Reference = 3322541035585 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 2, CompatiblePetiteTaille = 0, MesureMin = 125, MesureMax = 140, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T5 ", Reference = 3322541035592 });
            
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 70, MesureMax = 80, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T0", Reference = 3322541037848 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 80, MesureMax = 90, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T1 ", Reference = 3322541037855 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 90, MesureMax = 100, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T2", Reference = 3322541037862 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 100, MesureMax = 110, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T3", Reference = 3322541037879 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 110, MesureMax = 125, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T4 ", Reference = 3322541037886 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 125, MesureMax = 140, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T5 ", Reference = 3322541037893 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 70, MesureMax = 80, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T0", Reference = 3322541037909 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 80, MesureMax = 90, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T1 ", Reference = 3322541037916 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 90, MesureMax = 100, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T2", Reference = 3322541037923 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 100, MesureMax = 110, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T3", Reference = 3322541037930 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 110, MesureMax = 125, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T4 ", Reference = 3322541037947 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 1, MesureMin = 125, MesureMax = 140, HauteurDorsale = 21, Couleur = "BLEU", Taille = "T5 ", Reference = 3322541037954 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 70, MesureMax = 80, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T0", Reference = 3322546046740 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 80, MesureMax = 90, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T1 ", Reference = 3325546048757 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 100, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T2", Reference = 3322546048894 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 100, MesureMax = 110, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T3", Reference = 3322546048848 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 110, MesureMax = 125, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T4 ", Reference = 3322546048955 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 125, MesureMax = 140, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T5 ", Reference = 3322546048986 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 70, MesureMax = 80, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T0", Reference = 3322541035240 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 80, MesureMax = 90, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T1 ", Reference = 3322541035257 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 100, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T2", Reference = 3322541035264 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 100, MesureMax = 110, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T3", Reference = 3322541035288 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 110, MesureMax = 125, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T4 ", Reference = 3322541035288 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 3, CompatiblePetiteTaille = 0, MesureMin = 125, MesureMax = 140, HauteurDorsale = 26, Couleur = "BLEU", Taille = "T5 ", Reference = 3322541035295 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 4, MesureMin = 80, MesureMax = 135, Couleur = "BLEU", Taille = "T1", Reference = 3322541033482 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 4, MesureMin = 80, MesureMax = 135, Couleur = "BLEU", Taille = "T1", Reference = 3322541033482 });
            
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 1, MesureMin = 56, MesureMax = 68, HauteurDorsale = 21, Couleur = "NOIR", Taille = "XS", Reference = 82 - 0227 - 1 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 1, MesureMin = 68, MesureMax = 82, HauteurDorsale = 21, Couleur = "NOIR", Taille = "S", Reference = 82 - 0227 - 2 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 1, MesureMin = 82, MesureMax = 98, HauteurDorsale = 21, Couleur = "NOIR", Taille = "M", Reference = 82 - 0227 - 3 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 1, MesureMin = 98, MesureMax = 116, HauteurDorsale = 21, Couleur = "NOIR", Taille = "L", Reference = 82 - 0227 - 4 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 1, MesureMin = 116, MesureMax = 136, HauteurDorsale = 21, Couleur = "NOIR", Taille = "XL", Reference = 82 - 0227 - 5 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 0, MesureMin = 56, MesureMax = 68, HauteurDorsale = 26, Couleur = "NOIR", Taille = "XS", Reference = 82 - 0228 - 1 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 0, MesureMin = 68, MesureMax = 82, HauteurDorsale = 26, Couleur = "NOIR", Taille = "S", Reference = 82 - 0228 - 2 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 0, MesureMin = 82, MesureMax = 98, HauteurDorsale = 26, Couleur = "NOIR", Taille = "M", Reference = 82 - 0228 - 3 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 0, MesureMin = 98, MesureMax = 116, HauteurDorsale = 26, Couleur = "NOIR", Taille = "L", Reference = 82 - 0228 - 4 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 5, CompatiblePetiteTaille = 0, MesureMin = 116, MesureMax = 136, HauteurDorsale = 26, Couleur = "NOIR", Taille = "XL", Reference = 82 - 0228 - 5 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 6, CompatiblePetiteTaille = 0, MesureMin = 56, MesureMax = 68, HauteurDorsale = 26, Couleur = "NOIR", Taille = "XS", Reference = 82 - 0229 - 1 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 6, CompatiblePetiteTaille = 0, MesureMin = 68, MesureMax = 82, HauteurDorsale = 26, Couleur = "NOIR", Taille = "S", Reference = 82 - 0229 - 2 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 6, CompatiblePetiteTaille = 0, MesureMin = 82, MesureMax = 98, HauteurDorsale = 26, Couleur = "NOIR", Taille = "M", Reference = 82 - 0229 - 3 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 6, CompatiblePetiteTaille = 0, MesureMin = 98, MesureMax = 116, HauteurDorsale = 26, Couleur = "NOIR", Taille = "L", Reference = 82 - 0229 - 4 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 6, CompatiblePetiteTaille = 0, MesureMin = 116, MesureMax = 136, HauteurDorsale = 26, Couleur = "NOIR", Taille = "XL", Reference = 82 - 0229 - 5 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 7, CompatiblePetiteTaille = 1, MesureMin = 80, MesureMax = 150, HauteurDorsale = 23, HauteurVentrale = 8.5m, Couleur = "BLANC/VERT", Taille = "", Reference = 82 - 0245 });
            
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 8, CompatiblePetiteTaille = 1, MesureMin = 82, MesureMax = 125, HauteurDorsale = 21, Couleur = "", Taille = "T1", Reference = 3401097272412 });
            
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 52, MesureMax = 62, HauteurDorsale = 21, Couleur = "BLANC", Taille = "T1", Reference = 3401044809944 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 63, MesureMax = 74, HauteurDorsale = 21, Couleur = "BLANC", Taille = "T2", Reference = 3401044810025 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 75, MesureMax = 89, HauteurDorsale = 21, Couleur = "BLANC", Taille = "T3", Reference = 3401044810193 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 90, MesureMax = 105, HauteurDorsale = 21, Couleur = "BLANC", Taille = "T4", Reference = 3401044810254 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 106, MesureMax = 120, HauteurDorsale = 21, Couleur = "BLANC", Taille = "T5", Reference = 3401044810315 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 121, MesureMax = 140, HauteurDorsale = 21, Couleur = "BLANC", Taille = "T6", Reference = 3401044810483 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 52, MesureMax = 62, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T1", Reference = 3401045630134 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 63, MesureMax = 74, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T2", Reference = 3401045630363 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 75, MesureMax = 89, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T3", Reference = 3401045630424 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 90, MesureMax = 105, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T4", Reference = 3401045630592 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 106, MesureMax = 120, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T5", Reference = 3401045630653 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 1, MesureMin = 121, MesureMax = 140, HauteurDorsale = 21, Couleur = "NOIR", Taille = "T6", Reference = 3401045630714 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 52, MesureMax = 62, HauteurDorsale = 26, Couleur = "BLANC", Taille = "T1", Reference = 3401079106278 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 63, MesureMax = 74, HauteurDorsale = 26, Couleur = "BLANC", Taille = "T2", Reference = 3401079106339 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 75, MesureMax = 89, HauteurDorsale = 26, Couleur = "BLANC", Taille = "T3", Reference = 3401079106568 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 105, HauteurDorsale = 26, Couleur = "BLANC", Taille = "T4", Reference = 3401079106629 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 106, MesureMax = 120, HauteurDorsale = 26, Couleur = "BLANC", Taille = "T5", Reference = 3401079106797 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 121, MesureMax = 140, HauteurDorsale = 26, Couleur = "BLANC", Taille = "T6", Reference = 3401079106858 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 52, MesureMax = 62, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T1", Reference = 3401079106919 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 63, MesureMax = 74, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T2", Reference = 3401079107220 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 75, MesureMax = 89, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T3", Reference = 3401079107220 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 105, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T4", Reference = 3401079107398 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 106, MesureMax = 120, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T5", Reference = 3401079107459 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 121, MesureMax = 140, HauteurDorsale = 26, Couleur = "NOIR", Taille = "T6", Reference = 3401079107510 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 52, MesureMax = 62, HauteurDorsale = 26, Couleur = "BEIGE", Taille = "T1", Reference = 3401051798774 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 63, MesureMax = 74, HauteurDorsale = 26, Couleur = "BEIGE", Taille = "T2", Reference = 3401051798835 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 75, MesureMax = 89, HauteurDorsale = 26, Couleur = "BEIGE", Taille = "T3", Reference = 3401051799207 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 90, MesureMax = 105, HauteurDorsale = 26, Couleur = "BEIGE", Taille = "T4", Reference = 3401051799375 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 106, MesureMax = 120, HauteurDorsale = 26, Couleur = "BEIGE", Taille = "T5", Reference = 3401051799375 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 9, CompatiblePetiteTaille = 0, MesureMin = 121, MesureMax = 140, HauteurDorsale = 26, Couleur = "BEIGE", Taille = "T6", Reference = 3401051800187 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 1, MesureMin = 60, MesureMax = 75, HauteurDorsale = 21, Couleur = "", Taille = "T1", Reference = 3401096534477 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 1, MesureMin = 76, MesureMax = 94, HauteurDorsale = 21, Couleur = "", Taille = "T2", Reference = 3401048996589 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 1, MesureMin = 95, MesureMax = 115, HauteurDorsale = 21, Couleur = "", Taille = "T3", Reference = 3401079966179 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 1, MesureMin = 116, MesureMax = 140, HauteurDorsale = 21, Couleur = "", Taille = "T4", Reference = 3401096508579 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 1, MesureMin = 140, MesureMax = 160, HauteurDorsale = 21, Couleur = "", Taille = "T5", Reference = 3401072332334 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 0, MesureMin = 60, MesureMax = 75, HauteurDorsale = 26, Couleur = "", Taille = "T1", Reference = 3401079962676 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 0, MesureMin = 76, MesureMax = 94, HauteurDorsale = 26, Couleur = "", Taille = "T2", Reference = 3401079961617 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 0, MesureMin = 95, MesureMax = 115, HauteurDorsale = 26, Couleur = "", Taille = "T3", Reference = 3401079961785 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 0, MesureMin = 116, MesureMax = 140, HauteurDorsale = 26, Couleur = "", Taille = "T4", Reference = 3401079961846 });
            Insert.IntoTable("CeintureLombaire").Row(new { IdProduit = 10, CompatiblePetiteTaille = 0, MesureMin = 140, MesureMax = 160, HauteurDorsale = 26, Couleur = "", Taille = "T5", Reference = 3401079961907 });
        }
    }
}
