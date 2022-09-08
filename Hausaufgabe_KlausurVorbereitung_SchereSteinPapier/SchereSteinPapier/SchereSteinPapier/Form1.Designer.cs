
namespace SchereSteinPapier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSchere = new System.Windows.Forms.Button();
            this.buttonStein = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNutzerwahl = new System.Windows.Forms.TextBox();
            this.textBoxComputer = new System.Windows.Forms.TextBox();
            this.textBoxGewinner = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonStein);
            this.groupBox1.Controls.Add(this.buttonSchere);
            this.groupBox1.Location = new System.Drawing.Point(95, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonSchere
            // 
            this.buttonSchere.Location = new System.Drawing.Point(141, 102);
            this.buttonSchere.Name = "buttonSchere";
            this.buttonSchere.Size = new System.Drawing.Size(178, 104);
            this.buttonSchere.TabIndex = 0;
            this.buttonSchere.Tag = "1";
            this.buttonSchere.Text = "Schere";
            this.buttonSchere.UseVisualStyleBackColor = true;
            this.buttonSchere.Click += new System.EventHandler(this.SpielAusfuehren);
            // 
            // buttonStein
            // 
            this.buttonStein.Location = new System.Drawing.Point(373, 102);
            this.buttonStein.Name = "buttonStein";
            this.buttonStein.Size = new System.Drawing.Size(178, 104);
            this.buttonStein.TabIndex = 1;
            this.buttonStein.Tag = "2";
            this.buttonStein.Text = "Stein";
            this.buttonStein.UseVisualStyleBackColor = true;
            this.buttonStein.Click += new System.EventHandler(this.SpielAusfuehren);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 104);
            this.button1.TabIndex = 2;
            this.button1.Tag = "3";
            this.button1.Text = "Papier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SpielAusfuehren);
            // 
            // textBoxNutzerwahl
            // 
            this.textBoxNutzerwahl.Location = new System.Drawing.Point(95, 400);
            this.textBoxNutzerwahl.Multiline = true;
            this.textBoxNutzerwahl.Name = "textBoxNutzerwahl";
            this.textBoxNutzerwahl.ReadOnly = true;
            this.textBoxNutzerwahl.Size = new System.Drawing.Size(881, 87);
            this.textBoxNutzerwahl.TabIndex = 1;

            // 
            // textBoxComputer
            // 
            this.textBoxComputer.Location = new System.Drawing.Point(95, 523);
            this.textBoxComputer.Multiline = true;
            this.textBoxComputer.Name = "textBoxComputer";
            this.textBoxComputer.ReadOnly = true;
            this.textBoxComputer.Size = new System.Drawing.Size(881, 87);
            this.textBoxComputer.TabIndex = 2;
            // 
            // textBoxGewinner
            // 
            this.textBoxGewinner.Location = new System.Drawing.Point(95, 661);
            this.textBoxGewinner.Multiline = true;
            this.textBoxGewinner.Name = "textBoxGewinner";
            this.textBoxGewinner.ReadOnly = true;
            this.textBoxGewinner.Size = new System.Drawing.Size(881, 87);
            this.textBoxGewinner.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 872);
            this.Controls.Add(this.textBoxGewinner);
            this.Controls.Add(this.textBoxComputer);
            this.Controls.Add(this.textBoxNutzerwahl);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStein;
        private System.Windows.Forms.Button buttonSchere;
        private System.Windows.Forms.TextBox textBoxNutzerwahl;
        private System.Windows.Forms.TextBox textBoxComputer;
        private System.Windows.Forms.TextBox textBoxGewinner;
    }
}

