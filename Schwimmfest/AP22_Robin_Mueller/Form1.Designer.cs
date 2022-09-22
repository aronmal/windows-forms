
namespace AP22_Robin_Mueller
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSchwimmer = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bKinderAnzeigen = new System.Windows.Forms.Button();
            this.bKindHinzufuegen = new System.Windows.Forms.Button();
            this.bBekanntgabeGewinner = new System.Windows.Forms.Button();
            this.bBekanntgabeGesamtgewinner = new System.Windows.Forms.Button();
            this.rbAufsteigend = new System.Windows.Forms.RadioButton();
            this.rbAbsteigend = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxPlatzierungen = new System.Windows.Forms.ListBox();
            this.tbGesamtGewinner = new System.Windows.Forms.TextBox();
            this.rbRuecken = new System.Windows.Forms.RadioButton();
            this.rbBrust = new System.Windows.Forms.RadioButton();
            this.rbKraulen = new System.Windows.Forms.RadioButton();
            this.cbZeitInSekunden = new System.Windows.Forms.CheckBox();
            this.cbZeitInHHMMSS = new System.Windows.Forms.CheckBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSchule = new System.Windows.Forms.TextBox();
            this.tbKlasse = new System.Windows.Forms.TextBox();
            this.tbZeitRuecken = new System.Windows.Forms.TextBox();
            this.tbZeitBrust = new System.Windows.Forms.TextBox();
            this.tbZeitKraulen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbZeitKraulenNeu = new System.Windows.Forms.TextBox();
            this.tbZeitBrustNeu = new System.Windows.Forms.TextBox();
            this.tbZeitRueckenNeu = new System.Windows.Forms.TextBox();
            this.tbKlasseNeu = new System.Windows.Forms.TextBox();
            this.tbSchuleNeu = new System.Windows.Forms.TextBox();
            this.tbNameNeu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSchwimmer
            // 
            this.listBoxSchwimmer.FormattingEnabled = true;
            this.listBoxSchwimmer.Location = new System.Drawing.Point(31, 38);
            this.listBoxSchwimmer.Name = "listBoxSchwimmer";
            this.listBoxSchwimmer.Size = new System.Drawing.Size(290, 420);
            this.listBoxSchwimmer.TabIndex = 0;
            this.listBoxSchwimmer.SelectedIndexChanged += new System.EventHandler(this.listBoxSchwimmer_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAbsteigend);
            this.groupBox1.Controls.Add(this.rbAufsteigend);
            this.groupBox1.Location = new System.Drawing.Point(31, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortierung";
            // 
            // bKinderAnzeigen
            // 
            this.bKinderAnzeigen.Location = new System.Drawing.Point(338, 38);
            this.bKinderAnzeigen.Name = "bKinderAnzeigen";
            this.bKinderAnzeigen.Size = new System.Drawing.Size(176, 40);
            this.bKinderAnzeigen.TabIndex = 2;
            this.bKinderAnzeigen.Text = "teilnehmende Kinder anzeigen";
            this.bKinderAnzeigen.UseVisualStyleBackColor = true;
            this.bKinderAnzeigen.Click += new System.EventHandler(this.bKinderAnzeigen_Click);
            // 
            // bKindHinzufuegen
            // 
            this.bKindHinzufuegen.Location = new System.Drawing.Point(549, 38);
            this.bKindHinzufuegen.Name = "bKindHinzufuegen";
            this.bKindHinzufuegen.Size = new System.Drawing.Size(176, 40);
            this.bKindHinzufuegen.TabIndex = 3;
            this.bKindHinzufuegen.Text = "neues Kind hinzufügen";
            this.bKindHinzufuegen.UseVisualStyleBackColor = true;
            this.bKindHinzufuegen.Click += new System.EventHandler(this.bKindHinzufuegen_Click);
            // 
            // bBekanntgabeGewinner
            // 
            this.bBekanntgabeGewinner.Location = new System.Drawing.Point(754, 38);
            this.bBekanntgabeGewinner.Name = "bBekanntgabeGewinner";
            this.bBekanntgabeGewinner.Size = new System.Drawing.Size(203, 40);
            this.bBekanntgabeGewinner.TabIndex = 4;
            this.bBekanntgabeGewinner.Text = "Bekanntgabe Gewinner";
            this.bBekanntgabeGewinner.UseVisualStyleBackColor = true;
            this.bBekanntgabeGewinner.Click += new System.EventHandler(this.bBekanntgabeGewinner_Click);
            // 
            // bBekanntgabeGesamtgewinner
            // 
            this.bBekanntgabeGesamtgewinner.Location = new System.Drawing.Point(990, 38);
            this.bBekanntgabeGesamtgewinner.Name = "bBekanntgabeGesamtgewinner";
            this.bBekanntgabeGesamtgewinner.Size = new System.Drawing.Size(225, 40);
            this.bBekanntgabeGesamtgewinner.TabIndex = 5;
            this.bBekanntgabeGesamtgewinner.Text = "Bekanntgabe Gesamtgewinner";
            this.bBekanntgabeGesamtgewinner.UseVisualStyleBackColor = true;
            this.bBekanntgabeGesamtgewinner.Click += new System.EventHandler(this.bBekanntgabeGesamtgewinner_Click);
            // 
            // rbAufsteigend
            // 
            this.rbAufsteigend.AutoSize = true;
            this.rbAufsteigend.Location = new System.Drawing.Point(16, 34);
            this.rbAufsteigend.Name = "rbAufsteigend";
            this.rbAufsteigend.Size = new System.Drawing.Size(111, 17);
            this.rbAufsteigend.TabIndex = 6;
            this.rbAufsteigend.TabStop = true;
            this.rbAufsteigend.Text = "Name aufsteigend";
            this.rbAufsteigend.UseVisualStyleBackColor = true;
            // 
            // rbAbsteigend
            // 
            this.rbAbsteigend.AutoSize = true;
            this.rbAbsteigend.Location = new System.Drawing.Point(150, 34);
            this.rbAbsteigend.Name = "rbAbsteigend";
            this.rbAbsteigend.Size = new System.Drawing.Size(108, 17);
            this.rbAbsteigend.TabIndex = 7;
            this.rbAbsteigend.TabStop = true;
            this.rbAbsteigend.Text = "Name absteigend";
            this.rbAbsteigend.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbZeitKraulen);
            this.groupBox2.Controls.Add(this.tbZeitBrust);
            this.groupBox2.Controls.Add(this.tbZeitRuecken);
            this.groupBox2.Controls.Add(this.tbKlasse);
            this.groupBox2.Controls.Add(this.tbSchule);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Location = new System.Drawing.Point(338, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 371);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informationen gewähltes Kind";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbZeitKraulenNeu);
            this.groupBox3.Controls.Add(this.tbZeitBrustNeu);
            this.groupBox3.Controls.Add(this.tbZeitRueckenNeu);
            this.groupBox3.Controls.Add(this.tbKlasseNeu);
            this.groupBox3.Controls.Add(this.tbSchuleNeu);
            this.groupBox3.Controls.Add(this.tbNameNeu);
            this.groupBox3.Location = new System.Drawing.Point(549, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 371);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neues Kind und die Ergebnisse";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbKraulen);
            this.groupBox4.Controls.Add(this.rbBrust);
            this.groupBox4.Controls.Add(this.rbRuecken);
            this.groupBox4.Location = new System.Drawing.Point(754, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 112);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gewinner pro Disziplin";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbZeitInHHMMSS);
            this.groupBox5.Controls.Add(this.cbZeitInSekunden);
            this.groupBox5.Location = new System.Drawing.Point(754, 216);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 77);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Anzeige der Ergebnisse";
            // 
            // listBoxPlatzierungen
            // 
            this.listBoxPlatzierungen.FormattingEnabled = true;
            this.listBoxPlatzierungen.Location = new System.Drawing.Point(754, 311);
            this.listBoxPlatzierungen.Name = "listBoxPlatzierungen";
            this.listBoxPlatzierungen.Size = new System.Drawing.Size(203, 225);
            this.listBoxPlatzierungen.TabIndex = 10;
            // 
            // tbGesamtGewinner
            // 
            this.tbGesamtGewinner.BackColor = System.Drawing.Color.Turquoise;
            this.tbGesamtGewinner.Location = new System.Drawing.Point(990, 105);
            this.tbGesamtGewinner.Multiline = true;
            this.tbGesamtGewinner.Name = "tbGesamtGewinner";
            this.tbGesamtGewinner.ReadOnly = true;
            this.tbGesamtGewinner.Size = new System.Drawing.Size(225, 61);
            this.tbGesamtGewinner.TabIndex = 11;
            // 
            // rbRuecken
            // 
            this.rbRuecken.AutoSize = true;
            this.rbRuecken.Checked = true;
            this.rbRuecken.Location = new System.Drawing.Point(15, 28);
            this.rbRuecken.Name = "rbRuecken";
            this.rbRuecken.Size = new System.Drawing.Size(89, 17);
            this.rbRuecken.TabIndex = 0;
            this.rbRuecken.TabStop = true;
            this.rbRuecken.Text = "50 m Rücken";
            this.rbRuecken.UseVisualStyleBackColor = true;
            // 
            // rbBrust
            // 
            this.rbBrust.AutoSize = true;
            this.rbBrust.Location = new System.Drawing.Point(15, 51);
            this.rbBrust.Name = "rbBrust";
            this.rbBrust.Size = new System.Drawing.Size(75, 17);
            this.rbBrust.TabIndex = 1;
            this.rbBrust.Text = "50 m Brust";
            this.rbBrust.UseVisualStyleBackColor = true;
            // 
            // rbKraulen
            // 
            this.rbKraulen.AutoSize = true;
            this.rbKraulen.Location = new System.Drawing.Point(15, 74);
            this.rbKraulen.Name = "rbKraulen";
            this.rbKraulen.Size = new System.Drawing.Size(87, 17);
            this.rbKraulen.TabIndex = 2;
            this.rbKraulen.Text = "50 m Kraulen";
            this.rbKraulen.UseVisualStyleBackColor = true;
            // 
            // cbZeitInSekunden
            // 
            this.cbZeitInSekunden.AutoSize = true;
            this.cbZeitInSekunden.Checked = true;
            this.cbZeitInSekunden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZeitInSekunden.Location = new System.Drawing.Point(10, 19);
            this.cbZeitInSekunden.Name = "cbZeitInSekunden";
            this.cbZeitInSekunden.Size = new System.Drawing.Size(148, 17);
            this.cbZeitInSekunden.TabIndex = 0;
            this.cbZeitInSekunden.Text = "Zeit in Sekunden [default]";
            this.cbZeitInSekunden.UseVisualStyleBackColor = true;
            this.cbZeitInSekunden.CheckedChanged += new System.EventHandler(this.cbZeitInSekunden_CheckedChanged);
            // 
            // cbZeitInHHMMSS
            // 
            this.cbZeitInHHMMSS.AutoSize = true;
            this.cbZeitInHHMMSS.Enabled = false;
            this.cbZeitInHHMMSS.Location = new System.Drawing.Point(10, 42);
            this.cbZeitInHHMMSS.Name = "cbZeitInHHMMSS";
            this.cbZeitInHHMMSS.Size = new System.Drawing.Size(102, 17);
            this.cbZeitInHHMMSS.TabIndex = 1;
            this.cbZeitInHHMMSS.Text = "Zeit in hh:mm:ss";
            this.cbZeitInHHMMSS.UseVisualStyleBackColor = true;
            this.cbZeitInHHMMSS.CheckedChanged += new System.EventHandler(this.cbZeitInHHMMSS_CheckedChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 49);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(163, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbSchule
            // 
            this.tbSchule.Location = new System.Drawing.Point(6, 93);
            this.tbSchule.Name = "tbSchule";
            this.tbSchule.ReadOnly = true;
            this.tbSchule.Size = new System.Drawing.Size(163, 20);
            this.tbSchule.TabIndex = 1;
            // 
            // tbKlasse
            // 
            this.tbKlasse.Location = new System.Drawing.Point(6, 146);
            this.tbKlasse.Name = "tbKlasse";
            this.tbKlasse.ReadOnly = true;
            this.tbKlasse.Size = new System.Drawing.Size(163, 20);
            this.tbKlasse.TabIndex = 2;
            // 
            // tbZeitRuecken
            // 
            this.tbZeitRuecken.Location = new System.Drawing.Point(6, 197);
            this.tbZeitRuecken.Name = "tbZeitRuecken";
            this.tbZeitRuecken.ReadOnly = true;
            this.tbZeitRuecken.Size = new System.Drawing.Size(163, 20);
            this.tbZeitRuecken.TabIndex = 3;
            // 
            // tbZeitBrust
            // 
            this.tbZeitBrust.Location = new System.Drawing.Point(6, 244);
            this.tbZeitBrust.Name = "tbZeitBrust";
            this.tbZeitBrust.ReadOnly = true;
            this.tbZeitBrust.Size = new System.Drawing.Size(163, 20);
            this.tbZeitBrust.TabIndex = 4;
            // 
            // tbZeitKraulen
            // 
            this.tbZeitKraulen.Location = new System.Drawing.Point(6, 284);
            this.tbZeitKraulen.Name = "tbZeitKraulen";
            this.tbZeitKraulen.ReadOnly = true;
            this.tbZeitKraulen.Size = new System.Drawing.Size(163, 20);
            this.tbZeitKraulen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Schule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Klasse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zeit 50 m Rücken [sek]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zeit 50 m Brust [sek]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Zeit 50 m Kraulen [sek]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Zeit 50 m Kraulen [sek]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Zeit 50 m Brust [sek]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Zeit 50 m Rücken [sek]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Klasse";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Schule";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Name";
            // 
            // tbZeitKraulenNeu
            // 
            this.tbZeitKraulenNeu.Location = new System.Drawing.Point(7, 283);
            this.tbZeitKraulenNeu.Name = "tbZeitKraulenNeu";
            this.tbZeitKraulenNeu.Size = new System.Drawing.Size(163, 20);
            this.tbZeitKraulenNeu.TabIndex = 17;
            // 
            // tbZeitBrustNeu
            // 
            this.tbZeitBrustNeu.Location = new System.Drawing.Point(7, 243);
            this.tbZeitBrustNeu.Name = "tbZeitBrustNeu";
            this.tbZeitBrustNeu.Size = new System.Drawing.Size(163, 20);
            this.tbZeitBrustNeu.TabIndex = 16;
            // 
            // tbZeitRueckenNeu
            // 
            this.tbZeitRueckenNeu.Location = new System.Drawing.Point(7, 196);
            this.tbZeitRueckenNeu.Name = "tbZeitRueckenNeu";
            this.tbZeitRueckenNeu.Size = new System.Drawing.Size(163, 20);
            this.tbZeitRueckenNeu.TabIndex = 15;
            // 
            // tbKlasseNeu
            // 
            this.tbKlasseNeu.Location = new System.Drawing.Point(7, 145);
            this.tbKlasseNeu.Name = "tbKlasseNeu";
            this.tbKlasseNeu.Size = new System.Drawing.Size(163, 20);
            this.tbKlasseNeu.TabIndex = 14;
            // 
            // tbSchuleNeu
            // 
            this.tbSchuleNeu.Location = new System.Drawing.Point(7, 92);
            this.tbSchuleNeu.Name = "tbSchuleNeu";
            this.tbSchuleNeu.Size = new System.Drawing.Size(163, 20);
            this.tbSchuleNeu.TabIndex = 13;
            // 
            // tbNameNeu
            // 
            this.tbNameNeu.Location = new System.Drawing.Point(7, 48);
            this.tbNameNeu.Name = "tbNameNeu";
            this.tbNameNeu.Size = new System.Drawing.Size(163, 20);
            this.tbNameNeu.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 556);
            this.Controls.Add(this.tbGesamtGewinner);
            this.Controls.Add(this.listBoxPlatzierungen);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bBekanntgabeGesamtgewinner);
            this.Controls.Add(this.bBekanntgabeGewinner);
            this.Controls.Add(this.bKindHinzufuegen);
            this.Controls.Add(this.bKinderAnzeigen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxSchwimmer);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Schwimmfest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSchwimmer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAbsteigend;
        private System.Windows.Forms.RadioButton rbAufsteigend;
        private System.Windows.Forms.Button bKinderAnzeigen;
        private System.Windows.Forms.Button bKindHinzufuegen;
        private System.Windows.Forms.Button bBekanntgabeGewinner;
        private System.Windows.Forms.Button bBekanntgabeGesamtgewinner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxPlatzierungen;
        private System.Windows.Forms.TextBox tbGesamtGewinner;
        private System.Windows.Forms.RadioButton rbKraulen;
        private System.Windows.Forms.RadioButton rbBrust;
        private System.Windows.Forms.RadioButton rbRuecken;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox cbZeitInHHMMSS;
        private System.Windows.Forms.CheckBox cbZeitInSekunden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbZeitKraulen;
        private System.Windows.Forms.TextBox tbZeitBrust;
        private System.Windows.Forms.TextBox tbZeitRuecken;
        private System.Windows.Forms.TextBox tbKlasse;
        private System.Windows.Forms.TextBox tbSchule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbZeitKraulenNeu;
        private System.Windows.Forms.TextBox tbZeitBrustNeu;
        private System.Windows.Forms.TextBox tbZeitRueckenNeu;
        private System.Windows.Forms.TextBox tbKlasseNeu;
        private System.Windows.Forms.TextBox tbSchuleNeu;
        private System.Windows.Forms.TextBox tbNameNeu;
    }
}

