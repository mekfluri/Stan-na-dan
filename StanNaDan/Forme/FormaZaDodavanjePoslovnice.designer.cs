
namespace StanNaDanv2.Forme
{
    partial class FormaZaDodavanjePoslovnice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DodajPoslovicu = new System.Windows.Forms.Button();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.textRadnoVreme = new System.Windows.Forms.TextBox();
            this.Adresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // DodajPoslovicu
            // 
            this.DodajPoslovicu.BackColor = System.Drawing.Color.Linen;
            this.DodajPoslovicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajPoslovicu.Location = new System.Drawing.Point(16, 175);
            this.DodajPoslovicu.Margin = new System.Windows.Forms.Padding(4);
            this.DodajPoslovicu.Name = "DodajPoslovicu";
            this.DodajPoslovicu.Size = new System.Drawing.Size(155, 28);
            this.DodajPoslovicu.TabIndex = 0;
            this.DodajPoslovicu.Text = "Dodaj";
            this.DodajPoslovicu.UseVisualStyleBackColor = false;
            this.DodajPoslovicu.Click += new System.EventHandler(this.DodajPoslovicu_Click);
            // 
            // textAdresa
            // 
            this.textAdresa.Location = new System.Drawing.Point(120, 59);
            this.textAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(215, 22);
            this.textAdresa.TabIndex = 1;
            // 
            // textRadnoVreme
            // 
            this.textRadnoVreme.Location = new System.Drawing.Point(120, 101);
            this.textRadnoVreme.Margin = new System.Windows.Forms.Padding(4);
            this.textRadnoVreme.Name = "textRadnoVreme";
            this.textRadnoVreme.Size = new System.Drawing.Size(213, 22);
            this.textRadnoVreme.TabIndex = 2;
            // 
            // Adresa
            // 
            this.Adresa.AutoSize = true;
            this.Adresa.Location = new System.Drawing.Point(16, 59);
            this.Adresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adresa.Name = "Adresa";
            this.Adresa.Size = new System.Drawing.Size(54, 16);
            this.Adresa.TabIndex = 3;
            this.Adresa.Text = "Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Radno vreme:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 209);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // FormaZaDodavanjePoslovnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(448, 234);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Adresa);
            this.Controls.Add(this.textRadnoVreme);
            this.Controls.Add(this.textAdresa);
            this.Controls.Add(this.DodajPoslovicu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaZaDodavanjePoslovnice";
            this.Text = "DODAVANJE POSLOVICE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajPoslovicu;
        private System.Windows.Forms.TextBox textAdresa;
        private System.Windows.Forms.TextBox textRadnoVreme;
        private System.Windows.Forms.Label Adresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}