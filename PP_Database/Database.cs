#region

using System;
using System.Collections.Generic;
using System.Data;
using PP_Data_SQLServer;
using PP_Entity;

#endregion

namespace PP_Database
{
    public static class Database
    {
        #region Nested type: Gebruikers

        public static class Gebruikers
        {
            public static Gebruiker FindInDatabase(String email, String wachtwoord)
            {
                return Databaseverbinding.Gebruikers.FindInDatabase(email, wachtwoord);
            }

            public static Gebruiker ZoekGebruikerViaId(int gebruikerId)
            {
                return Databaseverbinding.Gebruikers.ZoekGebruikerViaId(gebruikerId);
            }

            public static DataTable sp_AlleGebruikersPerVak(Vak vak, Rol rol)
            {
                return Databaseverbinding.Gebruikers.sp_AlleGebruikersPerVak(vak, rol);
            }

            public static DataTable sp_AlleGebruikersPerRol(Rol rol)
            {
                return Databaseverbinding.Gebruikers.sp_AlleGebruikersPerRol(rol);
            }

            public static DataTable sp_AlleRollenPerGebruiker(int gebruikerId)
            {
                return Databaseverbinding.Gebruikers.sp_AlleRollenPerGebruiker(gebruikerId);
            }


            public static DataTable sp_AlleGebruikersEenmalig()
            {
                return Databaseverbinding.Gebruikers.sp_AlleGebruikersEenmalig();
            }

            public static Boolean GebruikerToevoegen(Gebruiker nieuweGebruiker)
            {
                return Databaseverbinding.Gebruikers.GebruikerToevoegen(nieuweGebruiker);
            }

            public static Boolean GebruikerUpdaten(Gebruiker uptedatenGebruiker)
            {
                return Databaseverbinding.Gebruikers.GebruikerUpdaten(uptedatenGebruiker);
            }

            public static Boolean GebruikerVerwijderen(int gebruikerId)
            {
                return Databaseverbinding.Gebruikers.GebruikerVerwijderen(gebruikerId);
            }

            public static Boolean sp_GebruikersUitCSVToevoegen(IEnumerable<Gebruiker> lijstNieuweGebruikers)
            {
                return Databaseverbinding.Gebruikers.sp_GebruikersUitCSVToevoegen(lijstNieuweGebruikers);
            }

            public static Boolean sp_GebruikerInschrijven(int gebruikerId, Rol rol, Vak vak)
            {
                return Databaseverbinding.Gebruikers.sp_GebruikerInschrijven(gebruikerId, rol, vak);
            }

            public static Gebruiker ZoekNaarDocentViaVak(Vak vak)
            {
                return Databaseverbinding.Gebruikers.ZoekNaarDocentViaVak(vak);
            }
        }

        #endregion

        #region Nested type: Lessen

        public static class Lessen
        {
            public static Boolean LesVerwijderen(Les les)
            {
                return Databaseverbinding.Lessen.LesVerwijderen(les);
            }

            public static DataTable LessenPerVak(Vak vak)
            {
                return Databaseverbinding.Lessen.LessenPerVak(vak);
            }
        }

        #endregion

        #region Nested type: Lokalen

        public static class Lokalen
        {
            public static List<Lokaal> BeschikbareLokalen(DateTimeOffset beginDatum, DateTimeOffset eindDatum)
            {
                return Databaseverbinding.Lokalen.BeschikbareLokalen(beginDatum, eindDatum);
            }
        }

        #endregion

        #region Nested type: Memos

        public static class Memos
        {
            public static DataTable MemoPerGebruikerPerVak(int gebruikerId, int vakId)
            {
                return Databaseverbinding.Memos.MemoPerGebruikerPerVak(gebruikerId, vakId);
            }

            public static Boolean MemoUpdaten(int memId, String memo)
            {
                return Databaseverbinding.Memos.MemoUpdaten(memId, memo);
            }

            public static Boolean MemoToevoegen(int gebId, int vakId, String memo)
            {
                return Databaseverbinding.Memos.MemoToevoegen(gebId, vakId, memo);
            }
        }

        #endregion

        #region Nested type: Opdrachten

        public static class Opdrachten
        {
            public static DataTable MededelingenPerGebruiker
            {
                get { return Databaseverbinding.Opdrachten.MededelingenPerGebruiker; }
            }

            public static DataTable TakenPerGebruiker
            {
                get { return Databaseverbinding.Opdrachten.TakenPerGebruiker; }
            }

            public static DataTable TestenPerGebruiker
            {
                get { return Databaseverbinding.Opdrachten.TestenPerGebruiker; }
            }

            public static Boolean OpdrachtToevoegen(Opdracht opdracht, OpdrachtSoort soort)
            {
                return Databaseverbinding.Opdrachten.OpdrachtToevoegen(opdracht, soort);
            }
        }

        #endregion

        #region Nested type: Vakken

        public static class Vakken
        {
            public static List<Vak> Lijst
            {
                get { return Databaseverbinding.Vakken.Lijst; }
            }

            public static List<Vak> AlleVakken
            {
                get { return Databaseverbinding.Vakken.AlleVakken; }
            }

            public static Boolean VakAanpassen(Vak vak, String naam, String beschrijving, Int16 studiepunten)
            {
                return Databaseverbinding.Vakken.VakAanpassen(vak, naam, beschrijving, studiepunten);
            }

            public static Boolean VakToevoegen(Vak vak)
            {
                return Databaseverbinding.Vakken.VakToevoegen(vak);
            }

            public static Boolean VakVerwijderen(Vak vak)
            {
                return Databaseverbinding.Vakken.VakVerwijderen(vak);
            }
        }

        #endregion
    }
}