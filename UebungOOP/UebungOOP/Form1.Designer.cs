namespace UebungOOP
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
            this.pbZeichenflaeche = new System.Windows.Forms.PictureBox();
            this.bKreis = new System.Windows.Forms.Button();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bZufallKreis = new System.Windows.Forms.Button();
            this.tbAnzahl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRadiusVar = new System.Windows.Forms.TextBox();
            this.chUmfang = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbZeichenflaeche)).BeginInit();
            this.SuspendLayout();
            // 
            // pbZeichenflaeche
            // 
            this.pbZeichenflaeche.BackColor = System.Drawing.Color.White;
            this.pbZeichenflaeche.Location = new System.Drawing.Point(27, 28);
            this.pbZeichenflaeche.Name = "pbZeichenflaeche";
            this.pbZeichenflaeche.Size = new System.Drawing.Size(543, 398);
            this.pbZeichenflaeche.TabIndex = 0;
            this.pbZeichenflaeche.TabStop = false;
            // 
            // bKreis
            // 
            this.bKreis.Location = new System.Drawing.Point(612, 28);
            this.bKreis.Name = "bKreis";
            this.bKreis.Size = new System.Drawing.Size(162, 51);
            this.bKreis.TabIndex = 1;
            this.bKreis.Text = "Kreis";
            this.bKreis.UseVisualStyleBackColor = true;
            this.bKreis.Click += new System.EventHandler(this.bKreis_Click);
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(691, 110);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(83, 20);
            this.tbRadius.TabIndex = 2;
            this.tbRadius.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radius: ";
            // 
            // bZufallKreis
            // 
            this.bZufallKreis.Location = new System.Drawing.Point(612, 178);
            this.bZufallKreis.Name = "bZufallKreis";
            this.bZufallKreis.Size = new System.Drawing.Size(162, 51);
            this.bZufallKreis.TabIndex = 4;
            this.bZufallKreis.Text = "zufällige Kreise";
            this.bZufallKreis.UseVisualStyleBackColor = true;
            this.bZufallKreis.Click += new System.EventHandler(this.bZufallKreis_Click);
            // 
            // tbAnzahl
            // 
            this.tbAnzahl.Location = new System.Drawing.Point(691, 267);
            this.tbAnzahl.Name = "tbAnzahl";
            this.tbAnzahl.Size = new System.Drawing.Size(83, 20);
            this.tbAnzahl.TabIndex = 5;
            this.tbAnzahl.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anzahl: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Radius varriert bis: ";
            // 
            // tbRadiusVar
            // 
            this.tbRadiusVar.Location = new System.Drawing.Point(691, 303);
            this.tbRadiusVar.Name = "tbRadiusVar";
            this.tbRadiusVar.Size = new System.Drawing.Size(83, 20);
            this.tbRadiusVar.TabIndex = 7;
            this.tbRadiusVar.Text = "50";
            // 
            // chUmfang
            // 
            this.chUmfang.AutoSize = true;
            this.chUmfang.Location = new System.Drawing.Point(624, 236);
            this.chUmfang.Name = "chUmfang";
            this.chUmfang.Size = new System.Drawing.Size(109, 17);
            this.chUmfang.TabIndex = 9;
            this.chUmfang.Text = "Umfang anzeigen";
            this.chUmfang.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chUmfang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRadiusVar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAnzahl);
            this.Controls.Add(this.bZufallKreis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.bKreis);
            this.Controls.Add(this.pbZeichenflaeche);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbZeichenflaeche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbZeichenflaeche;
        private System.Windows.Forms.Button bKreis;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bZufallKreis;
        private System.Windows.Forms.TextBox tbAnzahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRadiusVar;
        private System.Windows.Forms.CheckBox chUmfang;
    }
}

