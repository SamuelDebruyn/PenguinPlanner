#region

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using PP_Data_SQLServer.Properties;
using PP_Entity;

#endregion

namespace PP_Data_SQLServer
{
    /// <summary>
    ///     Deze klasse roept alle procedures op in de database en koppelt deze aan gewone C#-methodes.
    /// </summary>
    public static class Databaseverbinding
    {
        private static Gebruiker _inlogGebruiker;
        private static readonly SqlConnection Conn;

        static Databaseverbinding()
        {
            Conn = new SqlConnection(
                Settings.Default.AD4_PenguinPlannerConnectionString_WithoutPort);
            Conn.Open();
        }

        private static DataTable DataTableFromCommand(SqlCommand command)
        {
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
            }
            catch (Exception)
            {
            }
            return result;
        }

        #region Nested type: Gebruikers

        public static class Gebruikers
        {
            public static Gebruiker FindInDatabase(String email, String wachtwoord)
            {
                /*
                 *  Zorgt voor het inloggen van de gebruiker
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_ZoekenNaarGebruiker]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.AddWithValue("@GEB_Email", email);
                    cmm.Parameters.AddWithValue("@GEB_Wachtwoord", wachtwoord);

                    DataTable inlogGegevensTable = DataTableFromCommand(cmm);

                    if (inlogGegevensTable.Rows.Count == 0) return null;

                    string taalStr = inlogGegevensTable.Rows[0].ItemArray[7].ToString();
                    Taal taal = (Taal) Enum.Parse(typeof (Taal), taalStr);

                    _inlogGebruiker = new Gebruiker(Convert.ToInt32(inlogGegevensTable.Rows[0].ItemArray[0]),
                        inlogGegevensTable.Rows[0].ItemArray[1].ToString(),
                        inlogGegevensTable.Rows[0].ItemArray[2].ToString(),
                        inlogGegevensTable.Rows[0].ItemArray[3].ToString(),
                        inlogGegevensTable.Rows[0].ItemArray[4].ToString(),
                        Convert.ToDateTime(inlogGegevensTable.Rows[0].ItemArray[5]), taal);

                    foreach (Rol rol in from DataRow row in inlogGegevensTable.Rows
                        select row.ItemArray[6].ToString()
                        into rolStr
                        select (Rol) Enum.Parse(typeof (Rol), rolStr))
                    {
                        _inlogGebruiker.RolToevoegen(rol);
                    }
                    return _inlogGebruiker;
                }
                catch (Exception)
                {
                    return null;
                }
            }

            public static Gebruiker ZoekGebruikerViaId(int gebruikerId)
            {
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_ZoekenNaarGebruikerViaID]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.AddWithValue("@GebruikerID", gebruikerId);

                    DataTable gevondenGebruikerTable = DataTableFromCommand(cmm);

                    if (gevondenGebruikerTable.Rows.Count == 0) return null;

                    string taalStr = gevondenGebruikerTable.Rows[0].ItemArray[6].ToString();
                    Taal taal = (Taal) Enum.Parse(typeof (Taal), taalStr);

                    return new Gebruiker(Convert.ToInt32(gevondenGebruikerTable.Rows[0].ItemArray[0]),
                        gevondenGebruikerTable.Rows[0].ItemArray[1].ToString(),
                        gevondenGebruikerTable.Rows[0].ItemArray[2].ToString(),
                        gevondenGebruikerTable.Rows[0].ItemArray[3].ToString(),
                        gevondenGebruikerTable.Rows[0].ItemArray[4].ToString(),
                        Convert.ToDateTime(gevondenGebruikerTable.Rows[0].ItemArray[5]), taal);
                }
                catch (Exception)
                {
                    return null;
                }
            }

            public static DataTable sp_AlleGebruikersPerVak(Vak vak, Rol rol)
            {
                SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleGebruikersPerVak]", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                switch (rol)
                {
                    case Rol.Beheerder:
                        cmm.Parameters.AddWithValue("@RolID", 1);
                        break;
                    case Rol.Docent:
                        cmm.Parameters.AddWithValue("@RolID", 2);
                        break;
                    default:
                        // ReSharper disable once RedundantCaseLabel
                    case Rol.Student:
                        cmm.Parameters.AddWithValue("@RolID", 3);
                        break;
                }
                cmm.Parameters.Add("@VakID", SqlDbType.Int).Value = vak.Id;

                return DataTableFromCommand(cmm);
            }

            public static DataTable sp_AlleGebruikersPerRol(Rol rol)
            {
                SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleGebruikersPerRol]", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                switch (rol)
                {
                    case Rol.Beheerder:
                        cmm.Parameters.AddWithValue("@RolID", 1);
                        break;
                    case Rol.Docent:
                        cmm.Parameters.AddWithValue("@RolID", 2);
                        break;
                    default:
                        // ReSharper disable once RedundantCaseLabel
                    case Rol.Student:
                        cmm.Parameters.AddWithValue("@RolID", 3);
                        break;
                }

                return DataTableFromCommand(cmm);
            }

            public static DataTable sp_AlleRollenPerGebruiker(int gebruikerId)
            {
                SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleRollenPerGebruiker]", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmm.Parameters.AddWithValue("@GebruikerID", gebruikerId);

                return DataTableFromCommand(cmm);
            }

            public static DataTable sp_AlleGebruikersEenmalig()
            {
                SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleGebruikersEenmalig]", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                return DataTableFromCommand(cmm);
            }

            public static Boolean GebruikerToevoegen(Gebruiker nieuweGebruiker)
            {
                /*
                *  Voegt een gebruiker toe
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_GebruikerToevoegen]", Conn);
                    cmm.Parameters.AddWithValue("@GEB_Vooraam", nieuweGebruiker.Voornaam);
                    cmm.Parameters.AddWithValue("@GEB_Naam", nieuweGebruiker.Achternaam);
                    cmm.Parameters.AddWithValue("@GEB_EMAIL", nieuweGebruiker.Email);
                    cmm.Parameters.AddWithValue("@GEB_Paswoord", nieuweGebruiker.Wachtwoord);
                    cmm.Parameters.AddWithValue("@GEB_GeboorteDatum", nieuweGebruiker.Geboortedatum);
                    cmm.Parameters.AddWithValue("@GEB_TaalVoorkeur", (nieuweGebruiker.Taal + 1));
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static Boolean GebruikerUpdaten(Gebruiker uptedatenGebruiker)
            {
                /*
                *  Update een gebruiker 
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_GebruikerUpdaten]", Conn);
                    cmm.Parameters.AddWithValue("@GebruikersID", uptedatenGebruiker.Id);
                    cmm.Parameters.AddWithValue("@Vooraam", uptedatenGebruiker.Voornaam);
                    cmm.Parameters.AddWithValue("@Naam", uptedatenGebruiker.Achternaam);
                    cmm.Parameters.AddWithValue("@EMAIL", uptedatenGebruiker.Email);
                    cmm.Parameters.AddWithValue("@Paswoord", uptedatenGebruiker.Wachtwoord);
                    cmm.Parameters.AddWithValue("@GeboorteDatum", uptedatenGebruiker.Geboortedatum);
                    string taal = uptedatenGebruiker.Taal.ToString();
                    cmm.Parameters.AddWithValue("@TaalVoorkeur", taal);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static Boolean GebruikerVerwijderen(int gebruikerId)
            {
                /*
                *  Verwijdert een gebruiker 
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_GebruikerVerwijderen]", Conn);
                    cmm.Parameters.AddWithValue("@GebruikerID", gebruikerId);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static Boolean sp_GebruikersUitCSVToevoegen(IEnumerable<Gebruiker> lijstNieuweGebruikers)
            {
                /*
                *  Voegt gebruikers toe uit CSV
                 */
                foreach (Gebruiker nieuweGebruiker in lijstNieuweGebruikers)
                {
                    try
                    {
                        SqlCommand cmm = new SqlCommand("[dbo].[sp_GebruikersUitCSVToevoegen]", Conn);
                        cmm.Parameters.AddWithValue("@GEB_Vooraam", nieuweGebruiker.Voornaam);
                        cmm.Parameters.AddWithValue("@GEB_Naam", nieuweGebruiker.Achternaam);
                        cmm.Parameters.AddWithValue("@GEB_EMAIL", nieuweGebruiker.Email);
                        cmm.Parameters.AddWithValue("@GEB_Paswoord", nieuweGebruiker.Wachtwoord);
                        cmm.Parameters.AddWithValue("@GEB_GeboorteDatum", nieuweGebruiker.Geboortedatum);

                        switch (nieuweGebruiker.Taal)
                        {
                            default:
                                // ReSharper disable once RedundantCaseLabel
                            case Taal.Nederlands:
                                cmm.Parameters.AddWithValue("@GEB_TaalVoorkeur", 1);
                                break;
                            case Taal.Engels:
                                cmm.Parameters.AddWithValue("@GEB_TaalVoorkeur", 2);
                                break;
                            case Taal.Frans:
                                cmm.Parameters.AddWithValue("@GEB_TaalVoorkeur", 3);
                                break;
                        }

                        cmm.CommandType = CommandType.StoredProcedure;
                        cmm.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                return true;
            }

            public static Boolean sp_GebruikerInschrijven(int gebruikerId, Rol rol, Vak vak)
            {
                /*
                *  Schrijft gebruikers in als admin, student of docent
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_GebruikerInschrijven]", Conn);
                    cmm.Parameters.AddWithValue("@GebruikerID", gebruikerId);
                    cmm.Parameters.AddWithValue("@Rol", rol.ToString());
                    cmm.Parameters.AddWithValue("@VakID", vak.Id);
                    cmm.CommandType = CommandType.StoredProcedure;
                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static Gebruiker ZoekNaarDocentViaVak(Vak vak)
            {
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_ZoekenNaarDocentViaVak]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.AddWithValue("@VAK_Naam", vak.Naam);

                    DataTable gevondenDocentTable = DataTableFromCommand(cmm);

                    string taalStr = gevondenDocentTable.Rows[0].ItemArray[7].ToString();
                    Taal taal = (Taal) Enum.Parse(typeof (Taal), taalStr);

                    return new Gebruiker(Convert.ToInt32(gevondenDocentTable.Rows[0].ItemArray[0]),
                        gevondenDocentTable.Rows[0].ItemArray[1].ToString(),
                        gevondenDocentTable.Rows[0].ItemArray[2].ToString(),
                        gevondenDocentTable.Rows[0].ItemArray[3].ToString(),
                        gevondenDocentTable.Rows[0].ItemArray[4].ToString(),
                        Convert.ToDateTime(gevondenDocentTable.Rows[0].ItemArray[5]), taal);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        #endregion

        #region Nested type: Lessen

        public static class Lessen
        {
            public static Boolean LesVerwijderen(Les les)
            {
                /*
                *  Verwijdert een les
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_LesVerwijderen]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.AddWithValue("@LesID", les.Id);
                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static DataTable LessenPerVak(Vak vak)
            {
                /*
                *  Geeft alle lessen voor een vak terug
                 */
                SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleLessenPerVak]", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmm.Parameters.Add("@VakId", SqlDbType.Int).Value = vak.Id;

                return DataTableFromCommand(cmm);
            }
        }

        #endregion

        #region Nested type: Lokalen

        public static class Lokalen
        {
            public static List<Lokaal> BeschikbareLokalen(DateTimeOffset beginDatum, DateTimeOffset eindDatum)
            {
                /*
                 *  Geeft een lijst van beschikbare lokalen, lokalen waar er geen lessen voor in zijn voorzien
                 */
                List<Lokaal> lijst = new List<Lokaal>();

                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_BeschikbareLokalen]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.Add("@BeginDatum", SqlDbType.DateTimeOffset).Value = beginDatum;
                    cmm.Parameters.Add("@EindDatum", SqlDbType.DateTimeOffset).Value = eindDatum;

                    SqlDataReader reader = cmm.ExecuteReader();
                    while (reader.Read())
                        lijst.Add(new Lokaal(reader.GetInt32(0), reader.GetInt32(2)));
                    reader.Close();
                }
                catch (Exception)
                {
                }
                return lijst;
            }
        }

        #endregion

        #region Nested type: Memos

        public static class Memos
        {
            public static Boolean MemoToevoegen(int gebId, int vakId, String memo)
            {
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_MemoToevoegen]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.Add("@MemGebID", SqlDbType.Int).Value = gebId;
                    cmm.Parameters.Add("@MemVakID", SqlDbType.Int).Value = vakId;
                    cmm.Parameters.Add("@MemMemo", SqlDbType.NVarChar).Value = memo;

                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static Boolean MemoUpdaten(int memId, String memo)
            {
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_MemoUpdaten]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.Add("@MemID", SqlDbType.Int).Value = memId;
                    cmm.Parameters.Add("@MemMemo", SqlDbType.NVarChar).Value = memo;

                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static DataTable MemoPerGebruikerPerVak(int gebruikerId, int vakId)
            {
                SqlCommand cmm = new SqlCommand("[dbo].[sp_MemoPerGebruikerPerVak]", Conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmm.Parameters.Add("@MemGebID", SqlDbType.Int).Value = gebruikerId;
                cmm.Parameters.Add("@MemVakID", SqlDbType.Int).Value = vakId;

                return DataTableFromCommand(cmm);
            }
        }

        #endregion

        #region Nested type: Opdrachten

        public static class Opdrachten
        {
            public static DataTable MededelingenPerGebruiker
            {
                /*
                *  Geeft alle mededelingen voor een gebruiker terug
                 */
                get
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleOpdrachtenPerSoortPerGebruiker]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmm.Parameters.Add("@SoortOpdracht", SqlDbType.VarChar).Value = "Mededeling";
                    cmm.Parameters.Add("@GebruikerID", SqlDbType.Int).Value = _inlogGebruiker.Id;
                    cmm.Parameters.Add("@RolID", SqlDbType.Int).Value = ((int) _inlogGebruiker.Rol + 1);

                    return DataTableFromCommand(cmm);
                }
            }

            public static DataTable TakenPerGebruiker
            {
                /*
                *  Geeft alle taken voor een gebruiker terug
                 */
                get
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleOpdrachtenPerSoortPerGebruiker]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.Add("@SoortOpdracht", SqlDbType.VarChar).Value = "Taak";
                    cmm.Parameters.Add("@GebruikerID", SqlDbType.Int).Value = _inlogGebruiker.Id;
                        //VERANDEREN NAAR DE ID VAN DE INGELOGDE GEBRUIKER
                    cmm.Parameters.Add("@RolID", SqlDbType.Int).Value = ((int) _inlogGebruiker.Rol + 1);

                    return DataTableFromCommand(cmm);
                }
            }

            public static DataTable TestenPerGebruiker
            {
                /*
                *  Geeft alle Testen voor een gebruiker terug
                 */
                get
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleOpdrachtenPerSoortPerGebruiker]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmm.Parameters.Add("@SoortOpdracht", SqlDbType.VarChar).Value = "Test";
                    cmm.Parameters.Add("@GebruikerID", SqlDbType.Int).Value = _inlogGebruiker.Id;
                        //VERANDEREN NAAR DE ID VAN DE INGELOGDE GEBRUIKER
                    cmm.Parameters.Add("@RolID", SqlDbType.Int).Value = ((int) _inlogGebruiker.Rol + 1);

                    return DataTableFromCommand(cmm);
                }
            }

            public static Boolean OpdrachtToevoegen(Opdracht opdracht, OpdrachtSoort soort)
            {
                /*
                *  Voegt een opdracht toe
                 */
                try
                {
                    SqlCommand command = new SqlCommand("[dbo].[sp_OpdrachtToevoegen]", Conn);
                    command.Parameters.AddWithValue("@VakNaam", opdracht.Vak.Naam);

                    String soortStr = soort.ToString().First().ToString().ToUpper() +
                                      soort.ToString().Skip(1).ToString().ToLower();
                    command.Parameters.AddWithValue("@SoortOpdracht", soortStr);
                    command.Parameters.AddWithValue("@Beschrijving", opdracht.Beschrijving);
                    command.Parameters.AddWithValue("@BeginDatum", opdracht.Begindatum);
                    command.Parameters.AddWithValue("@EindDatum", opdracht.Einddatum);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        #endregion

        #region Nested type: Vakken

        public static class Vakken
        {
            public static List<Vak> Lijst
            {
                /*
                 *  Geeft een lijst van vakken terug voor een bepaalde gebruiker
                 */
                get
                {
                    List<Vak> lijst = new List<Vak>();

                    try
                    {
                        SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleVakkenPerGebruiker]", Conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmm.Parameters.Add("@GebID", SqlDbType.Int).Value = _inlogGebruiker.Id;
                            //VERANDEREN NAAR DE ID VAN DE INGELOGDE GEBRUIKER
                        cmm.Parameters.Add("@RolID", SqlDbType.Int).Value = ((int) _inlogGebruiker.Rol + 1);

                        SqlDataReader reader = cmm.ExecuteReader();
                        while (reader.Read())
                            lijst.Add(new Vak(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                reader.GetByte(3)));
                        reader.Close();
                    }
                    catch (Exception)
                    {
                    }

                    return lijst;
                }
            }

            public static List<Vak> AlleVakken
            {
                /*
                 *  Geeft een lijst van alle vakken terug
                 */
                get
                {
                    List<Vak> alleVakken = new List<Vak>();

                    try
                    {
                        SqlCommand cmm = new SqlCommand("[dbo].[sp_AlleVakken]", Conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        SqlDataReader reader = cmm.ExecuteReader();
                        while (reader.Read())
                            alleVakken.Add(new Vak(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                reader.GetByte(3)));
                        reader.Close();
                    }
                    catch (Exception)
                    {
                    }

                    return alleVakken;
                }
            }

            public static Boolean VakAanpassen(Vak vak, String naam, String beschrijving, Int16 studiepunten)
            {
                /*
                *  Past een vak aan
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_VakAanpassen]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.AddWithValue("@VAK_Id", vak.Id);
                    cmm.Parameters.AddWithValue("@VAK_Naam", naam);
                    cmm.Parameters.AddWithValue("@VAK_Beschrijving", beschrijving);
                    cmm.Parameters.AddWithValue("@VAK_StudiePunten", studiepunten);
                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static Boolean VakToevoegen(Vak vak)
            {
                /*
                *  Voegt een vak toe
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_VakToevoegen]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.AddWithValue("@VAK_Naam", vak.Naam);
                    cmm.Parameters.AddWithValue("@VAK_Beschrijving", vak.Beschrijving);
                    cmm.Parameters.AddWithValue("@VAK_StudiePunten", vak.Studiepunten);
                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public static Boolean VakVerwijderen(Vak vak)
            {
                /*
                *  Verwijdert een vak
                 */
                try
                {
                    SqlCommand cmm = new SqlCommand("[dbo].[sp_VakVerwijderen]", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmm.Parameters.AddWithValue("@VAK_Naam", vak.Naam);
                    cmm.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        #endregion
    }
}