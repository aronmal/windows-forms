using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace AP22_Robin_Mueller
{
    public partial class Form1 : Form
    {
        OleDbConnection dbSchwimmfest;
        public Form1()
        {
            InitializeComponent();
            //Verbindung zur Datenbank herstellen
            dbSchwimmfest = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Schwimmfest.accdb; ");
            dbSchwimmfest.Open();
        }

        ~Form1()
        {
            //Verbindung zur Datenbank schließen
            dbSchwimmfest.Close();
        }

        private void bKinderAnzeigen_Click(object sender, EventArgs e)
        {
            //Listbox mit Schwimmern leeren
            listBoxSchwimmer.Items.Clear();

            //Sortierung in den SQL String einbeziehen
            string sSQLNamen = "SELECT Vorname, Nachname FROM Sportler";
            if (rbAbsteigend.Checked)
            {
                sSQLNamen += " ORDER BY Nachname DESC;";
            }
            else if(rbAufsteigend.Checked)
            {
                sSQLNamen += " ORDER BY Nachname ASC;";
            }

            //Daten auslesen
            OleDbCommand dbAusleseBefehlNamen = new OleDbCommand(sSQLNamen, dbSchwimmfest);

            OleDbDataReader dbLeserNamen = dbAusleseBefehlNamen.ExecuteReader();

            //Daten werden einzeln in die Listbox eingefügt
            while (dbLeserNamen.Read())
            {
                listBoxSchwimmer.Items.Add(dbLeserNamen["Vorname"] + " " + dbLeserNamen["Nachname"]);
            }

            dbLeserNamen.Close();

        }

        private void listBoxSchwimmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            InfoTextboxenLeeren();

            //Daten des Schwimmers auslesen
            string sSQLSportler = $"SELECT * FROM Sportler WHERE (Vorname + ' ' + Nachname) = '{listBoxSchwimmer.SelectedItem.ToString()}';";
            OleDbCommand dbAusleseBefehlSportler = new OleDbCommand(sSQLSportler, dbSchwimmfest);

            OleDbDataReader dbLeserSportler = dbAusleseBefehlSportler.ExecuteReader();
            dbLeserSportler.Read();

            //Daten einfügen
            tbName.Text = dbLeserSportler["Vorname"].ToString() + " " + dbLeserSportler["Nachname"].ToString();
            tbSchule.Text = dbLeserSportler["Schule"].ToString();
            tbKlasse.Text = dbLeserSportler["Klasse"].ToString();
            tbZeitRuecken.Text = dbLeserSportler["Zeit_50Ruecken"].ToString();
            tbZeitBrust.Text = dbLeserSportler["Zeit_50Brust"].ToString();
            tbZeitKraulen.Text = dbLeserSportler["Zeit_50Kraulen"].ToString();

            dbLeserSportler.Close();
        }

        public void InfoTextboxenLeeren() //Leert alle Info Textboxen
        {
            tbName.Clear();
            tbSchule.Clear();
            tbKlasse.Clear();
            tbZeitRuecken.Clear();
            tbZeitBrust.Clear();
            tbZeitKraulen.Clear();

        }

        public void EinfuegeTextboxenLeeren() //Leert alle einfüge Textboxen
        {
            tbNameNeu.Clear();
            tbSchuleNeu.Clear();
            tbKlasseNeu.Clear();
            tbZeitRueckenNeu.Clear();
            tbZeitBrustNeu.Clear();
            tbZeitKraulenNeu.Clear();

        }

        private void bKindHinzufuegen_Click(object sender, EventArgs e)
        {
            //Variablen initialisieren
            string sName;
            string sSchule;
            string sKlasse;
            int iZeitRuecken;
            int iZeitBrust;
            int iZeitKraulen;

            try
            {
                //Befüllen der Strings mit der Eingabe des Benutzers
                sName = tbNameNeu.Text;
                sSchule = tbSchuleNeu.Text;
                sKlasse = tbKlasseNeu.Text;
                iZeitRuecken = Convert.ToInt32(tbZeitRueckenNeu.Text);
                iZeitBrust = Convert.ToInt32(tbZeitBrustNeu.Text);
                iZeitKraulen = Convert.ToInt32(tbZeitKraulenNeu.Text);
            }
            catch (FormatException)
            {
                //Fehlermeldung wenn falsche Eingaben gemacht wurden
                MessageBox.Show("Fehler! Bitte überprüfen Sie ihre Eingaben.");
                return;
            }
            //Überprüfung ob der Name aus einem Vor- und Nachnamen besteht
            if(sName.IndexOf(' ') == -1)
            {
                MessageBox.Show("Bitte geben Sie einen vollständigen Namen ein. (Vorname + Nachname)");
                return;
            }

            //Aufteilen des Namen in Vor- und Nachnamen
            string sVorname = sName.Substring(0, sName.IndexOf(' '));
            string sNachname = sName.Substring(sName.IndexOf(' ') + 1, sName.Length - 1 - sName.IndexOf(' '));

            //Auslesen der höchsten ID
            string sSQLMaxID = "SELECT MAX(ID) FROM Sportler;";
            OleDbCommand dbAusleseBefehlMaxID = new OleDbCommand(sSQLMaxID, dbSchwimmfest);

            OleDbDataReader dbLeserMaxID = dbAusleseBefehlMaxID.ExecuteReader();
            dbLeserMaxID.Read();

            int iID = Convert.ToInt32(dbLeserMaxID[0]) + 1;

            dbLeserMaxID.Close();

            //Einfügen des Schwimmers
            string sSQLEinfuegen = $"INSERT INTO Sportler VALUES ({iID}, '{sVorname}', '{sNachname}', '{sSchule}', '{sKlasse}', {iZeitRuecken}, {iZeitBrust}, {iZeitKraulen});";
            OleDbCommand dbEinfuegeBefehl = new OleDbCommand(sSQLEinfuegen, dbSchwimmfest);
            dbEinfuegeBefehl.ExecuteNonQuery();

            MessageBox.Show("Kind wurde hinzugefügt!");
        }

        private void bBekanntgabeGewinner_Click(object sender, EventArgs e)
        {
            //Leeren der Listbox
            listBoxPlatzierungen.Items.Clear();

            //Überprüfen, welche Schwimmart anzgezeigt werden soll
            string sSchwimmArt = " ";
            if (rbRuecken.Checked)
            {
                sSchwimmArt = "Zeit_50Ruecken";
            }else if (rbBrust.Checked)
            {
                sSchwimmArt = "Zeit_50Brust";
            }
            else if (rbKraulen.Checked)
            {
                sSchwimmArt = "Zeit_50Kraulen";
            }

            //Auslesen der Schwimmer sortiert nach der jeweiligen Zeit
            string sSQL = $"SELECT Vorname, Nachname, {sSchwimmArt} FROM Sportler ORDER BY {sSchwimmArt} ASC;";

            OleDbCommand dbAusleseBefehl = new OleDbCommand(sSQL, dbSchwimmfest);
            OleDbDataReader dbLeser = dbAusleseBefehl.ExecuteReader();

            int iZaehler = 0;
            //Es werden maximal 5 Datensätze ausgelesen weil nur die Top 5 Spieler angezeigt werden sollen
            while (dbLeser.Read() && iZaehler < 5)
            {
                string sZeitangabe = " "; //String für die Zeitangabe in der Listbox zur Vereinfachung der Programmierung

                //Befüllung der Zeitangabe je nach Auswahl des Nutzers
                if (cbZeitInSekunden.Checked)
                {
                    sZeitangabe = dbLeser[sSchwimmArt] + " Sekunden";
                }
                else if (cbZeitInHHMMSS.Checked)
                {
                    int iSekunden = Convert.ToInt32(dbLeser[sSchwimmArt]);
                    int iMinuten = 0;
                    int iStunden = 0;

                    //Umrechnung von Sekunden in hh:mm:ss
                    while(iSekunden >= 60)
                    {
                        iSekunden -= 60;
                        iMinuten++;
                    }

                    while(iMinuten >= 60)
                    {
                        iMinuten -= 60;
                        iStunden++;
                    }

                    sZeitangabe = $"{iStunden}:{iMinuten}:{iSekunden}";
                }
                //Einfügen der Daten in die Listbox
                listBoxPlatzierungen.Items.Add((iZaehler + 1) + ": " + dbLeser["Vorname"] + " " + dbLeser["Nachname"] + "\t" + sZeitangabe);

                dbLeser.Close();

                iZaehler++;
            }
        }
        //Logik für die Checkboxen der Zeitangaben (Es dürfen nicht beide gleichzeitig gecheckt sein)
        private void cbZeitInHHMMSS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbZeitInHHMMSS.Checked)
            {
                cbZeitInSekunden.Checked = false;
                cbZeitInSekunden.Enabled = false;
            }
            else
            {
                cbZeitInSekunden.Checked = true;
                cbZeitInSekunden.Enabled = true;
            }
        }
        //Logik für die Checkboxen der Zeitangaben (Es dürfen nicht beide gleichzeitig gecheckt sein)
        private void cbZeitInSekunden_CheckedChanged(object sender, EventArgs e)
        {
            if (cbZeitInSekunden.Checked)
            {
                cbZeitInHHMMSS.Checked = false;
                cbZeitInHHMMSS.Enabled = false;
            }
            else
            {
                cbZeitInHHMMSS.Checked = true;
                cbZeitInHHMMSS.Enabled = true;
            }
        }

        private void bBekanntgabeGesamtgewinner_Click(object sender, EventArgs e)
        {
            //Alle Zeiten der Schwimmer abfragen
            string sSQLZeiten = "SELECT Zeit_50Ruecken, Zeit_50Brust, Zeit_50Kraulen FROM Sportler;";
            OleDbCommand dbAusleseBefehlZeiten = new OleDbCommand(sSQLZeiten, dbSchwimmfest);

            OleDbDataReader dbLeserZeiten = dbAusleseBefehlZeiten.ExecuteReader();
            List<int> LZeiten = new List<int>();
            //Zeiten werden zusammengerechnet und jeweils in eine Liste gespeichert
            while (dbLeserZeiten.Read())
            {
                
                int iGesamtZeit = Convert.ToInt32(dbLeserZeiten["Zeit_50Ruecken"]) + Convert.ToInt32(dbLeserZeiten["Zeit_50Brust"]) + Convert.ToInt32(dbLeserZeiten["Zeit_50Kraulen"]);
                LZeiten.Add(iGesamtZeit);
            }
            dbLeserZeiten.Close();
            //Gesamtsieger wird mittels der kleinsten gesamtzeit aus der Liste ermittelt und abgefragt
            string sSQLGesamtSieger = $"SELECT Vorname, Nachname FROM Sportler WHERE (Zeit_50Ruecken + Zeit_50Brust + Zeit_50Kraulen) = {LZeiten.Min()}";
            OleDbCommand dbAusleseBefehlGesamtSieger = new OleDbCommand(sSQLGesamtSieger, dbSchwimmfest);

            OleDbDataReader dbLeserGesamtSieger = dbAusleseBefehlGesamtSieger.ExecuteReader();
            dbLeserGesamtSieger.Read();

            //Gesamtsieger wird in die Textbox eingefügt
            tbGesamtGewinner.Text = dbLeserGesamtSieger["Vorname"] + " " + dbLeserGesamtSieger["Nachname"];

            dbLeserGesamtSieger.Close();
        }
    }
}
