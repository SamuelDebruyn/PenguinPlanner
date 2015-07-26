#region

using System;
using System.Collections.Generic;
using System.Data;
using PP_Entity;

#endregion

namespace PP_Business
{
    public static class Database
    {
        #region Nested type: Gebruikers

        public static class Gebruikers
        {
            public static Gebruiker InlogGebruiker;

            public static Gebruiker FindInDatabase(String email, String wachtwoord)
            {
                InlogGebruiker = PP_Database.Database.Gebruikers.FindInDatabase(email, wachtwoord);
                return InlogGebruiker;
            }

            public static Gebruiker ZoekGebruikerViaId(int gebruikerId)
            {
                return PP_Database.Database.Gebruikers.ZoekGebruikerViaId(gebruikerId);
            }

            public static DataTable sp_AlleGebruikersPerVak(Vak vak, Rol rol)
            {
                return PP_Database.Database.Gebruikers.sp_AlleGebruikersPerVak(vak, rol);
            }

            public static DataTable sp_AlleGebruikersPerRol(Rol rol)
            {
                return PP_Database.Database.Gebruikers.sp_AlleGebruikersPerRol(rol);
            }

            public static DataTable sp_AlleRollenPerGebruiker(int gebruikerId)
            {
                return PP_Database.Database.Gebruikers.sp_AlleRollenPerGebruiker(gebruikerId);
            }

            public static DataTable sp_AlleGebruikersEenmalig()
            {
                return PP_Database.Database.Gebruikers.sp_AlleGebruikersEenmalig();
            }

            public static Boolean GebruikerToevoegen(Gebruiker nieuweGebruiker)
            {
                return PP_Database.Database.Gebruikers.GebruikerToevoegen(nieuweGebruiker);
            }

            public static Boolean GebruikerUpdaten(Gebruiker uptedatenGebruiker)
            {
                return PP_Database.Database.Gebruikers.GebruikerUpdaten(uptedatenGebruiker);
            }

            public static Boolean GebruikerVerwijderen(int gebruikerId)
            {
                return PP_Database.Database.Gebruikers.GebruikerVerwijderen(gebruikerId);
            }

            public static Boolean GebruikersUitCsvToevoegen(IEnumerable<Gebruiker> nieuweGebruikers)
            {
                return PP_Database.Database.Gebruikers.sp_GebruikersUitCSVToevoegen(nieuweGebruikers);
            }

            public static Boolean sp_GebruikerInschrijven(int gebruikerId, Rol rol, Vak vak)
            {
                return PP_Database.Database.Gebruikers.sp_GebruikerInschrijven(gebruikerId, rol, vak);
            }

            public static Gebruiker ZoekenDocentViaVak(Vak vak)
            {
                return PP_Database.Database.Gebruikers.ZoekNaarDocentViaVak(vak);
            }
        }

        #endregion

        #region Nested type: Lessen

        public static class Lessen
        {
            public static Boolean LesVerwijderen(Les les)
            {
                return PP_Database.Database.Lessen.LesVerwijderen(les);
            }

            public static DataTable LessenPerVak(Vak vak)
            {
                return PP_Database.Database.Lessen.LessenPerVak(vak);
            }
        }

        #endregion

        #region Nested type: Lokalen

        public static class Lokalen
        {
            public static List<Lokaal> BeschikbareLokalen(DateTimeOffset beginDatum, DateTimeOffset eindDatum)
            {
                return PP_Database.Database.Lokalen.BeschikbareLokalen(beginDatum, eindDatum);
            }
        }

        #endregion

        #region Nested type: Memos

        public static class Memos
        {
            public static DataTable MemoPerGebruikerPerVak(int gebruikerId, int vakId)
            {
                return PP_Database.Database.Memos.MemoPerGebruikerPerVak(gebruikerId, vakId);
            }

            public static Boolean MemoUpdaten(int memId, String memo)
            {
                return PP_Database.Database.Memos.MemoUpdaten(memId, memo);
            }

            public static Boolean MemoToevoegen(int gebId, int vakId, String memo)
            {
                return PP_Database.Database.Memos.MemoToevoegen(gebId, vakId, memo);
            }
        }

        #endregion

        #region Nested type: Opdrachten

        public static class Opdrachten
        {
            public static DataTable MededelingenPerGebruiker
            {
                get { return PP_Database.Database.Opdrachten.MededelingenPerGebruiker; }
            }

            public static DataTable TakenPerGebruiker
            {
                get { return PP_Database.Database.Opdrachten.TakenPerGebruiker; }
            }

            public static DataTable TestenPerGebruiker
            {
                get { return PP_Database.Database.Opdrachten.TestenPerGebruiker; }
            }

            public static Boolean OpdrachtToevoegen(Opdracht opdracht, OpdrachtSoort soort)
            {
                return PP_Database.Database.Opdrachten.OpdrachtToevoegen(opdracht, soort);
            }
        }

        #endregion

        #region Nested type: Vakken

        public static class Vakken
        {
            public static List<Vak> Lijst
            {
                get { return PP_Database.Database.Vakken.Lijst; }
            }

            public static List<Vak> AlleVakken
            {
                get { return PP_Database.Database.Vakken.AlleVakken; }
            }

            public static Boolean VakAanpassen(Vak vak, String naam, String beschrijving, Int16 studiepunten)
            {
                return PP_Database.Database.Vakken.VakAanpassen(vak, naam, beschrijving, studiepunten);
            }

            public static Boolean VakToevoegen(Vak vak)
            {
                return PP_Database.Database.Vakken.VakToevoegen(vak);
            }

            public static Boolean VakVerwijderen(Vak vak)
            {
                return PP_Database.Database.Vakken.VakVerwijderen(vak);
            }
        }

        #endregion
    }
}