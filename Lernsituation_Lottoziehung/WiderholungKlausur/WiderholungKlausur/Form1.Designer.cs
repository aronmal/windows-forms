
namespace WiderholungKlausur
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
            this.textBoxMinimumZahl = new System.Windows.Forms.TextBox();
            this.textBoxMaximumZahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxZahl1Zufall = new System.Windows.Forms.TextBox();
            this.textBoxZahl2Zufall = new System.Windows.Forms.TextBox();
            this.textBoxZahl3Zufall = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.überDieAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMinimumZahl
            // 
            this.textBoxMinimumZahl.Location = new System.Drawing.Point(165, 78);
            this.textBoxMinimumZahl.Name = "textBoxMinimumZahl";
            this.textBoxMinimumZahl.Size = new System.Drawing.Size(100, 26);
            this.textBoxMinimumZahl.TabIndex = 0;
            // 
            // textBoxMaximumZahl
            // 
            this.textBoxMaximumZahl.Location = new System.Drawing.Point(458, 84);
            this.textBoxMaximumZahl.Name = "textBoxMaximumZahl";
            this.textBoxMaximumZahl.Size = new System.Drawing.Size(100, 26);
            this.textBoxMaximumZahl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "kleinste Zahl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "größte Zahl";
            // 
            // textBoxZahl1Zufall
            // 
            this.textBoxZahl1Zufall.Location = new System.Drawing.Point(26, 152);
            this.textBoxZahl1Zufall.Name = "textBoxZahl1Zufall";
            this.textBoxZahl1Zufall.ReadOnly = true;
            this.textBoxZahl1Zufall.Size = new System.Drawing.Size(100, 26);
            this.textBoxZahl1Zufall.TabIndex = 4;
            // 
            // textBoxZahl2Zufall
            // 
            this.textBoxZahl2Zufall.Location = new System.Drawing.Point(165, 152);
            this.textBoxZahl2Zufall.Name = "textBoxZahl2Zufall";
            this.textBoxZahl2Zufall.ReadOnly = true;
            this.textBoxZahl2Zufall.Size = new System.Drawing.Size(100, 26);
            this.textBoxZahl2Zufall.TabIndex = 5;
            // 
            // textBoxZahl3Zufall
            // 
            this.textBoxZahl3Zufall.Location = new System.Drawing.Point(315, 152);
            this.textBoxZahl3Zufall.Name = "textBoxZahl3Zufall";
            this.textBoxZahl3Zufall.ReadOnly = true;
            this.textBoxZahl3Zufall.Size = new System.Drawing.Size(100, 26);
            this.textBoxZahl3Zufall.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Würfeln";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(26, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sortieren";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überDieAppToolStripMenuItem,
            this.appBeendenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1838, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // überDieAppToolStripMenuItem
            // 
            this.überDieAppToolStripMenuItem.Name = "überDieAppToolStripMenuItem";
            this.überDieAppToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.überDieAppToolStripMenuItem.Text = "Über die App";
            // 
            // appBeendenToolStripMenuItem
            // 
            this.appBeendenToolStripMenuItem.Name = "appBeendenToolStripMenuItem";
            this.appBeendenToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.appBeendenToolStripMenuItem.Text = "App beenden";
            this.appBeendenToolStripMenuItem.Click += new System.EventHandler(this.appBeendenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1838, 764);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxZahl3Zufall);
            this.Controls.Add(this.textBoxZahl2Zufall);
            this.Controls.Add(this.textBoxZahl1Zufall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaximumZahl);
            this.Controls.Add(this.textBoxMinimumZahl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMinimumZahl;
        private System.Windows.Forms.TextBox textBoxMaximumZahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxZahl1Zufall;
        private System.Windows.Forms.TextBox textBoxZahl2Zufall;
        private System.Windows.Forms.TextBox textBoxZahl3Zufall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem überDieAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appBeendenToolStripMenuItem;
    }
}

