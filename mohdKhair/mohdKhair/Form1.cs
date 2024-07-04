using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace mohdKhair
{
    public partial class Form1 : Form
    {
    
        private List<Laender> laenderList;
        private List<Button> buttonList = new List<Button>();
        private Datenbank db = new Datenbank();
        private List<UserAndResults> UserAndResultsList;

        public Form1()
        {
            InitializeComponent();
            buttonList.Add(Wahl1);
            buttonList.Add(Wahl2);
            buttonList.Add(Wahl3);
            buttonList.Add(Wahl4);
            falsemachen();
            DisplayMessageBoxText();
            SeeErgibnesse();


        }

        private void anmelden_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = false;
            Afrika.Visible = true;
            Nordamerika.Visible = true;
            Asien.Visible = true;
            Australien.Visible = true;
            sudamerka.Visible = true;
            Europa.Visible = true;
            Weltweit.Visible = true;

            Afrika_hauptstaedte.Visible = true;
            Nordamerka_hauptstaedte.Visible = true;
            Asien_hauptstaedte.Visible = true;
            Austraarin_hauptstaedte.Visible = true;
            sudamaerka_hauptstaedte.Visible = true;
            europa_hauptstaedte.Visible = true;
            Weltweit_hauptstaedte.Visible = true;

            Afrika_flagge.Visible = true;
            Nordamerika_fagge.Visible = true;
            Asien_flagge.Visible = true;
            Austraarin_flagge.Visible = true;
            sudamerika_flagge.Visible = true;
            Europa_flagge.Visible = true;
            Weltweit_flagge.Visible = true;
        }

        private void falsemachen()
        {

            Afrika.Visible = false;
            Nordamerika.Visible = false;
            Asien.Visible = false;
            Australien.Visible = false;
            sudamerka.Visible = false;
            Europa.Visible = false;
            Weltweit.Visible = false;

            Afrika_hauptstaedte.Visible = false;
            Nordamerka_hauptstaedte.Visible = false;
            Asien_hauptstaedte.Visible = false;
            Austraarin_hauptstaedte.Visible = false;
            sudamaerka_hauptstaedte.Visible = false;
            europa_hauptstaedte.Visible = false;
            Weltweit_hauptstaedte.Visible = false;

            Afrika_flagge.Visible = false;
            Nordamerika_fagge.Visible = false;
            Asien_flagge.Visible = false;
            Austraarin_flagge.Visible = false;
            sudamerika_flagge.Visible = false;
            Europa_flagge.Visible = false;
            Weltweit_flagge.Visible = false;
        }

        private void DisplayMessageBoxText()
        {
            MessageBox.Show("Bitte melde dich mit deinem Spielernamen an");
        }
        private void clearButtons()
        {
            foreach (Button button in buttonList)
            {
                button.Text = "";
                button.BackColor = Color.White;

            }
        }
        //europa


        //flaggenAufrufen
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void LadeFlaggen()
        {
            if (laenderList != null && laenderList.Count > 0)
            {
                LoadFlaggenImage(laenderList[0].Name); // Nur die erste Flagge laden
            }
        }

        private void LoadFlaggenImage(string landName)
        {
            try
            {
                // Das aktuelle Bild freigeben, falls vorhanden
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                // Neues Bild laden
                pictureBox1.Image = Image.FromFile($"..\\..\\..\\Flaggen\\Flaggen_raten\\{landName}.png");
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Fehler beim Laden des Bildes: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Allgemeiner Fehler: " + ex.Message);
            }
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////
        /// </summary>

        int a = 1;
        private void weite_Click(object sender, EventArgs e)
        {
            if (Europa.BackColor == Color.Gold)
            {
                Europa_Click(sender, e);
            }

            if (Afrika.BackColor == Color.Gold)
            {
                Afrika_Click(sender, e);

            }

            if (Asien.BackColor == Color.Gold)
            {
                Asien_Click(sender, e);
            }

            if (Nordamerika.BackColor == Color.Gold)
            {
                Nordamerika_Click(sender, e);
            }

            if (Australien.BackColor == Color.Gold)
            {
                Australien_Click(sender, e);
            }

            if (sudamerka.BackColor == Color.Gold)
            {
                sudamerka_Click(sender, e);
            }

            if (Weltweit.BackColor == Color.Gold)
            {
                Weltweit_Click(sender, e);
            }

            if (sudamaerka_hauptstaedte.BackColor == Color.Gold)
            {
                sudamaerka_hauptstaedte_Click(sender, e);
            }

            if (Austraarin_hauptstaedte.BackColor == Color.Gold)
            {
                Austraarin_hauptstaedte_Click(sender, e);
            }

            if (Nordamerka_hauptstaedte.BackColor == Color.Gold)
            {
                Nordamerka_hauptstaedte_Click(sender, e);
            }

            if (Asien_hauptstaedte.BackColor == Color.Gold)
            {
                Asien_hauptstaedte_Click(sender, e);
            }

            if (Afrika_hauptstaedte.BackColor == Color.Gold)
            {
                Afrika_hauptstaedte_Click(sender, e);
            }

            if (europa_hauptstaedte.BackColor == Color.Gold)
            {
                europa_hauptstaedte_Click(sender, e);
            }

            if (Weltweit_hauptstaedte.BackColor == Color.Gold)
            {
                Weltweit_hauptstaedte_Click(sender, e);
            }

            if (Afrika_flagge.BackColor == Color.Gold)
            {
                Afrika_flagge_Click(sender, e);
            }

            if (Europa_flagge.BackColor == Color.Gold)
            {
                Europa_flagge_Click_1(sender, e);
            }

            if (Nordamerika_fagge.BackColor == Color.Gold)
            {
                Nordamerika_fagge_Click(sender, e);
            }

            if (sudamerika_flagge.BackColor == Color.Gold)
            {
                sudamerika_flagge_Click(sender, e);
            }

            if (Asien_flagge.BackColor == Color.Gold)
            {
                Asien_flagge_Click(sender, e);
            }

            if (Austraarin_flagge.BackColor == Color.Gold)
            {
                Austraarin_flagge_Click(sender, e);
            }

            if (Weltweit_flagge.BackColor == Color.Gold)
            {
                Weltweit_flagge_Click(sender, e);
            }




            a++;

            if (a == 10)
            {

                weite.Text = "Ende";
                MessageBox.Show($"ergebniss : {label1.Text} Das Ende, Wenn Sie wieder Spielen möchten dann Klicken Sie auf die Kontinente, wo Sie spielen möchten.");
                a = 0;


                UserAndResults userAndResults = new UserAndResults(
                    -1,
                    textBox1.Text,
                    Convert.ToInt32(label1.Text));

                db.SaveErgebnisse(userAndResults);

            }
        }

        private bool IsFlagCorrect(string selectedCountry)
        {
            return Land.Text == selectedCountry;
        }

        private void Wahl1_Click(object sender, EventArgs e)
        {
            int punktestand;
            if (!int.TryParse(label1.Text, out punktestand))
            {
                punktestand = 0;
            }

            if (Afrika_flagge.BackColor == Color.Gold)
            {
                if (IsFlagCorrect(Wahl1.Text))
                {
                    Wahl1.BackColor = Color.Green;
                    punktestand += 10;
                }
                else
                {
                    Wahl1.BackColor = Color.Red;
                    punktestand -= 10;
                }
            }
            else
            {
                // Bestehende Logik für andere Spielmodi
                if (laenderList != null && laenderList.Count > 0)
                {
                    if (laenderList[0].Name == Wahl1.Text || laenderList[0].Hauptstadt1 == Wahl1.Text)
                    {
                        Wahl1.BackColor = Color.Green;
                        punktestand += 10;
                    }
                    else
                    {
                        Wahl1.BackColor = Color.Red;
                        punktestand -= 10;
                    }
                }
            }

            label1.Text = punktestand.ToString();
        }

        private void Wahl2_Click_1(object sender, EventArgs e)
        {
            int punktestand;
            if (!int.TryParse(label1.Text, out punktestand))
            {
                punktestand = 0;
            }

            if (Afrika_flagge.BackColor == Color.Gold)
            {
                if (IsFlagCorrect(Wahl2.Text))
                {
                    Wahl2.BackColor = Color.Green;
                    punktestand += 10;
                }
                else
                {
                    Wahl2.BackColor = Color.Red;
                    punktestand -= 10;
                }
            }
            else
            {
                // Bestehende Logik für andere Spielmodi
                if (laenderList != null && laenderList.Count > 0)
                {
                    if (laenderList[0].Name == Wahl2.Text || laenderList[0].Hauptstadt1 == Wahl2.Text)
                    {
                        Wahl2.BackColor = Color.Green;
                        punktestand += 10;
                    }
                    else
                    {
                        Wahl2.BackColor = Color.Red;
                        punktestand -= 10;
                    }
                }
            }

            label1.Text = punktestand.ToString();
        }

        private void Wahl3_Click_1(object sender, EventArgs e)
        {
            int punktestand;
            if (!int.TryParse(label1.Text, out punktestand))
            {
                punktestand = 0;
            }

            if (Afrika_flagge.BackColor == Color.Gold)
            {
                if (IsFlagCorrect(Wahl3.Text))
                {
                    Wahl3.BackColor = Color.Green;
                    punktestand += 10;
                }
                else
                {
                    Wahl3.BackColor = Color.Red;
                    punktestand -= 10;
                }
            }
            else
            {
                // Bestehende Logik für andere Spielmodi
                if (laenderList != null && laenderList.Count > 0)
                {
                    if (laenderList[0].Name == Wahl3.Text || laenderList[0].Hauptstadt1 == Wahl3.Text)
                    {
                        Wahl3.BackColor = Color.Green;
                        punktestand += 10;
                    }
                    else
                    {
                        Wahl3.BackColor = Color.Red;
                        punktestand -= 10;
                    }
                }
            }

            label1.Text = punktestand.ToString();
        }

        private void Wahl4_Click_1(object sender, EventArgs e)
        {
            int punktestand;
            if (!int.TryParse(label1.Text, out punktestand))
            {
                punktestand = 0;
            }

            if (Afrika_flagge.BackColor == Color.Gold)
            {
                if (IsFlagCorrect(Wahl4.Text))
                {
                    Wahl4.BackColor = Color.Green;
                    punktestand += 10;
                }
                else
                {
                    Wahl4.BackColor = Color.Red;
                    punktestand -= 10;
                }
            }
            else
            {
                // Bestehende Logik für andere Spielmodi
                if (laenderList != null && laenderList.Count > 0)
                {
                    if (laenderList[0].Name == Wahl4.Text || laenderList[0].Hauptstadt1 == Wahl4.Text)
                    {
                        Wahl4.BackColor = Color.Green;
                        punktestand += 10;
                    }
                    else
                    {
                        Wahl4.BackColor = Color.Red;
                        punktestand -= 10;
                    }
                }
            }

            label1.Text = punktestand.ToString();
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void Europa_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.Gold;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;



            panel1.Visible = true;

            laenderList = db.GetLaender();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Name;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Name;
                }
            }

            LadeFlaggen();
        }
        private void Afrika_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.Gold;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetLaenderAfrika();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Name;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Name;
                }
            }

            LadeFlaggen();
        }

        private void Asien_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.Gold;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetLaenderAsian();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Name;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Name;
                }
            }

            LadeFlaggen();
        }

        private void Nordamerika_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.Gold;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetLaenderNordamerika();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Name;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Name;
                }
            }

            LadeFlaggen();
        }

        private void Australien_Click(object sender, EventArgs e)
        {
            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.Gold;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetLaenderAustralien();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Name;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Name;
                }
            }

            LadeFlaggen();
        }

        private void sudamerka_Click(object sender, EventArgs e)
        {
            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.Gold;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetLaenderSudamerika();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Name;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Name;
                }
            }

            LadeFlaggen();
        }

        private void Weltweit_Click(object sender, EventArgs e)
        {
            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.Gold;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetLaenderWeldweit();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Name;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Name;
                }
            }

            LadeFlaggen();
        }




        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////
        /// </summary>


        private void sudamaerka_hauptstaedte_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.Gold;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetHauptstadtSudamerika();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Hauptstadt1;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Hauptstadt1;
                }
            }

            LadeFlaggen();
        }

        private void Austraarin_hauptstaedte_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.Gold;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetHauptstadtAustralien();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Hauptstadt1;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Hauptstadt1;
                }
            }

            LadeFlaggen();

        }

        private void Nordamerka_hauptstaedte_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.Gold;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetHauptstadtNordamerika();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Hauptstadt1;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Hauptstadt1;
                }
            }

            LadeFlaggen();
        }

        private void Asien_hauptstaedte_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.Gold;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetHauptstadtAsien();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Hauptstadt1;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Hauptstadt1;
                }
            }

            LadeFlaggen();
        }

        private void Afrika_hauptstaedte_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.Gold;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetHauptstadtAfrika();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Hauptstadt1;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Hauptstadt1;
                }
            }

            LadeFlaggen();


        }

        private void europa_hauptstaedte_Click(object sender, EventArgs e)
        {
            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.Gold;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetHauptstadtEUROBA();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Hauptstadt1;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Hauptstadt1;
                }
            }

            LadeFlaggen();
        }

        private void Weltweit_hauptstaedte_Click(object sender, EventArgs e)
        {

            Land.Visible = false;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.Gold;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;

            panel1.Visible = true;

            laenderList = db.GetHautstadtWeldweit();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            buttonList[z].Text = laenderList[0].Hauptstadt1;

            int i = 1;
            foreach (Button button in buttonList)
            {
                if (button.Text == "" && i < laenderList.Count)
                {
                    button.Text = laenderList[i++].Hauptstadt1;
                }
            }

            LadeFlaggen();

        }



        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// </summary>





        private void Afrika_flagge_Click(object sender, EventArgs e)
        {
            Land.Visible = true;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.Gold;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;


            panel1.Visible = true;

            laenderList = db.GetRichtigeFlagge();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            Land.Text = laenderList[0].Name;

            int i = 0;
            foreach (Button button in buttonList)
            {
                if (i < laenderList.Count)
                {
                    button.Text = laenderList[i].Name; // Stelle sicher, dass der Text des Buttons gesetzt wird
                    button.Font = new Font(button.Font.FontFamily, 1);
                    button.BackgroundImage = Image.FromFile($"..\\..\\..\\Flaggen\\Flaggen_raten\\{laenderList[i++].Name}.png");
                }
            }
        }

        private void Europa_flagge_Click_1(object sender, EventArgs e)
        {
            Land.Visible = true;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.Gold;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;


            panel1.Visible = true;

            laenderList = db.GetRichtigeFlaggeEuropa();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            Land.Text = laenderList[0].Name;

            int i = 0;
            foreach (Button button in buttonList)
            {
                if (i < laenderList.Count)
                {
                    button.Text = laenderList[i].Name; // Stelle sicher, dass der Text des Buttons gesetzt wird
                    button.Font = new Font(button.Font.FontFamily, 1);
                    button.BackgroundImage = Image.FromFile($"..\\..\\..\\Flaggen\\Flaggen_raten\\{laenderList[i++].Name}.png");
                }
            }
        }

        private void Nordamerika_fagge_Click(object sender, EventArgs e)
        {
            Land.Visible = true;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.Gold;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;


            panel1.Visible = true;

            laenderList = db.GetRichtigeFlaggeNordamerka();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            Land.Text = laenderList[0].Name;

            int i = 0;
            foreach (Button button in buttonList)
            {
                if (i < laenderList.Count)
                {
                    button.Text = laenderList[i].Name; // Stelle sicher, dass der Text des Buttons gesetzt wird
                    button.Font = new Font(button.Font.FontFamily, 1);
                    button.BackgroundImage = Image.FromFile($"..\\..\\..\\Flaggen\\Flaggen_raten\\{laenderList[i++].Name}.png");
                }
            }
        }

        private void sudamerika_flagge_Click(object sender, EventArgs e)
        {
            Land.Visible = true;

            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.Gold;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;


            panel1.Visible = true;

            laenderList = db.GetRichtigeFlaggeSudamerka();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            Land.Text = laenderList[0].Name;

            int i = 0;
            foreach (Button button in buttonList)
            {
                if (i < laenderList.Count)
                {
                    button.Text = laenderList[i].Name; // Stelle sicher, dass der Text des Buttons gesetzt wird
                    button.Font = new Font(button.Font.FontFamily, 1);
                    button.BackgroundImage = Image.FromFile($"..\\..\\..\\Flaggen\\Flaggen_raten\\{laenderList[i++].Name}.png");
                }
            }
        }

        private void Asien_flagge_Click(object sender, EventArgs e)
        {
            Land.Visible = true;


            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.Gold;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.White;


            panel1.Visible = true;

            laenderList = db.GetRichtigeFlaggeAsian();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            Land.Text = laenderList[0].Name;

            int i = 0;
            foreach (Button button in buttonList)
            {
                if (i < laenderList.Count)
                {
                    button.Text = laenderList[i].Name; // Stelle sicher, dass der Text des Buttons gesetzt wird
                    button.Font = new Font(button.Font.FontFamily, 1);
                    button.BackgroundImage = Image.FromFile($"..\\..\\..\\Flaggen\\Flaggen_raten\\{laenderList[i++].Name}.png");
                }
            }
        }

        private void Austraarin_flagge_Click(object sender, EventArgs e)
        {
            Land.Visible = true;


            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.Gold;
            Weltweit_flagge.BackColor = Color.White;


            panel1.Visible = true;

            laenderList = db.GetRichtigeFlaggeAstrarien();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            Land.Text = laenderList[0].Name;

            int i = 0;
            foreach (Button button in buttonList)
            {
                if (i < laenderList.Count)
                {
                    button.Text = laenderList[i].Name; // Stelle sicher, dass der Text des Buttons gesetzt wird
                    button.Font = new Font(button.Font.FontFamily, 1);
                    button.BackgroundImage = Image.FromFile($"..\\..\\..\\Flaggen\\Flaggen_raten\\{laenderList[i++].Name}.png");
                }
            }
        }

        private void Weltweit_flagge_Click(object sender, EventArgs e)
        {
            Land.Visible = true;


            Europa.BackColor = Color.White;
            Afrika.BackColor = Color.White;
            Nordamerika.BackColor = Color.White;
            sudamerka.BackColor = Color.White;
            Asien.BackColor = Color.White;
            Australien.BackColor = Color.White;
            Weltweit.BackColor = Color.White;
            sudamaerka_hauptstaedte.BackColor = Color.White;
            Austraarin_hauptstaedte.BackColor = Color.White;
            Nordamerka_hauptstaedte.BackColor = Color.White;
            Asien_hauptstaedte.BackColor = Color.White;
            europa_hauptstaedte.BackColor = Color.White;
            Weltweit_hauptstaedte.BackColor = Color.White;
            Afrika_hauptstaedte.BackColor = Color.White;
            Afrika_flagge.BackColor = Color.White;
            Europa_flagge.BackColor = Color.White;
            Nordamerika_fagge.BackColor = Color.White;
            sudamerika_flagge.BackColor = Color.White;
            Asien_flagge.BackColor = Color.White;
            Austraarin_flagge.BackColor = Color.White;
            Weltweit_flagge.BackColor = Color.Gold;


            panel1.Visible = true;

            laenderList = db.GetRichtigeFlaggeWeltweit();
            clearButtons();

            if (laenderList == null || laenderList.Count == 0)
            {
                MessageBox.Show("Keine Länder gefunden.");
                return;
            }

            Random rd = new Random();
            int z = rd.Next(0, 4);
            Land.Text = laenderList[0].Name;

            int i = 0;
            foreach (Button button in buttonList)
            {
                if (i < laenderList.Count)
                {
                    button.Text = laenderList[i].Name; // Stelle sicher, dass der Text des Buttons gesetzt wird
                    button.Font = new Font(button.Font.FontFamily, 1);
                    button.BackgroundImage = Image.FromFile($"..\\..\\..\\Flaggen\\Flaggen_raten\\{laenderList[i++].Name}.png");
                }
            }
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////
        /// </summary>


        private void SeeErgibnesse()
        {

            UserAndResultsList = db.GetErgebnisse();
            dataGridView1.Rows.Clear();

            foreach (UserAndResults fw in UserAndResultsList)
            {
                dataGridView1.Rows.Add(fw.NR1, fw.User, fw.Results1);
            }
        }
    }
}
