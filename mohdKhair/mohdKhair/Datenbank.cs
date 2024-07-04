using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace mohdKhair
{
    public class Datenbank
    {
        private MySqlConnection con;

        public Datenbank()
        {
            string conStr = "SERVER=localhost;DATABASE=quiz;" +
                "UID=root;PASSWORD=''";
            con = new MySqlConnection(conStr);
        }
        private void oeffnen()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void schliessen()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        //Europa
        public List<Laender> GetLaender()
        {
            List<Laender> laenderList = new List<Laender>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();

            Random rnd = new Random();
            int randomNum = rnd.Next(1, 11);

            cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 1 AND NR BETWEEN @RandomNumber AND 13;";
            cmd.Parameters.AddWithValue("@RandomNumber", randomNum);
            //cmd.CommandText = "SELECT * FROM Laender";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                laenderList.Add(new Laender(
                    dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                    dr.IsDBNull(1) ? "" : dr.GetString(1),
                    dr.IsDBNull(2) ? "" : dr.GetString(2),
                    dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                ));
            }

            dr.Close();
            schliessen();
            return laenderList;
        }


        //Afrika
        public List<Laender> GetLaenderAfrika()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Stellen Sie sicher, dass der Zufallswert innerhalb der verfügbaren NR-Werte liegt.

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 2 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////
        /// </summary>


        public List<Laender> GetLaenderAsian()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Stellen Sie sicher, dass der Zufallswert innerhalb der verfügbaren NR-Werte liegt.

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 3 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        public List<Laender> GetLaenderNordamerika()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Stellen Sie sicher, dass der Zufallswert innerhalb der verfügbaren NR-Werte liegt.

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 4 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////
        /// </summary>


        public List<Laender> GetLaenderAustralien()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Stellen Sie sicher, dass der Zufallswert innerhalb der verfügbaren NR-Werte liegt.

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 5 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////
        /// </summary>

        public List<Laender> GetLaenderSudamerika()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Stellen Sie sicher, dass der Zufallswert innerhalb der verfügbaren NR-Werte liegt.

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 6 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////
        /// </summary>
        /// 

        public List<Laender> GetLaenderWeldweit()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Laender ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        /// <summary>
        /// ////////////////////////////////////////////////////////////////
        /// </summary>
        ///  /// <summary>
        /// ////////////////////////////////////////////////////////////////
        /// </summary>

        public List<Laender> GetHauptstadtSudamerika()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Adjust range as needed

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 6 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                       
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }



        public List<Laender> GetHauptstadtAustralien()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Adjust range as needed

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 5 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)

                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        public List<Laender> GetHauptstadtNordamerika()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Adjust range as needed

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 4 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)

                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        public List<Laender> GetHauptstadtAsien()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Adjust range as needed

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 3 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)

                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        public List<Laender> GetHauptstadtAfrika()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Adjust range as needed

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 2 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)

                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        public List<Laender> GetHauptstadtEUROBA()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                Random rnd = new Random();
                int randomNum = rnd.Next(1, 10); // Adjust range as needed

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 1 ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)

                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }



        public List<Laender> GetHautstadtWeldweit()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Laender ORDER BY RAND() LIMIT 4;";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        public List<Laender> GetRichtigeFlagge()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 2 ORDER BY RAND();";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }




        /// <summary>
        /// ////////////////////////////////

        public List<Laender> GetRichtigeFlaggeEuropa()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 1 ORDER BY RAND();";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }



        public List<Laender> GetRichtigeFlaggeNordamerka()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 4 ORDER BY RAND();";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        public List<Laender> GetRichtigeFlaggeSudamerka()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 6 ORDER BY RAND();";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }

        public List<Laender> GetRichtigeFlaggeAsian()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 3 ORDER BY RAND();";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }



        public List<Laender> GetRichtigeFlaggeAstrarien()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Laender WHERE KoNr = 5 ORDER BY RAND();";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        public List<Laender> GetRichtigeFlaggeWeltweit()
        {
            List<Laender> laenderList = new List<Laender>();
            try
            {
                oeffnen();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "SELECT* FROM Laender ORDER BY RAND();";
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    laenderList.Add(new Laender(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                        dr.IsDBNull(1) ? "" : dr.GetString(1),
                        dr.IsDBNull(2) ? "" : dr.GetString(2),
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3)
                    ));
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler bei der Datenbankabfrage: " + ex.Message);
            }
            finally
            {
                schliessen();
            }

            if (laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder wurden gefunden.");
            }

            return laenderList;
        }


        
        //SaveErgebnisse
        public void SaveErgebnisse(UserAndResults userAndResults)
        {
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            string s;
            if (userAndResults.NR1 != -1)
            { 
                s = string.Format("UPDATE UserAndResults " +
                                    "SET NR = '{0}', " +
                                    "User = {1}, " +
                                    "Results = {2} " +
                                    "WHERE Nr = {3};",
                                    userAndResults.NR1,
                                    userAndResults.User,
                                    userAndResults.Results1);

            }
            else
            {
                s = string.Format("INSERT INTO UserAndResults " +
                    "VALUES( NULL, '{0}', '{1}');",

                    userAndResults.User,
                    userAndResults.Results1);
            }
            cmd.CommandText = s;
            cmd.ExecuteNonQuery();
            schliessen();
        }

        public List<UserAndResults> GetErgebnisse()
        {
            List<UserAndResults> userAndResultsList = new List<UserAndResults>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM UserAndResults";
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                userAndResultsList.Add(new UserAndResults(
                    dr.IsDBNull(0) ? -1 : dr.GetInt32(0),
                    dr.IsDBNull(1) ? "" : dr.GetString(1),
                    dr.IsDBNull(2) ? -1 : dr.GetInt32(2)
                ));
            }
            dr.Close();
            schliessen();
            return userAndResultsList;
        }
    }
}
