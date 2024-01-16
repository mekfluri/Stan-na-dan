namespace StanNaDanv2.Forme
{
    partial class IzmeniSefaForma
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datum_postavljanja = new System.Windows.Forms.DateTimePicker();
            this.ime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datum_zaposlenja = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.datum_postavljanja);
            this.groupBox2.Controls.Add(this.ime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.datum_zaposlenja);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 392);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "unesite podatke o sefu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datum_postavljanja
            // 
            this.datum_postavljanja.Location = new System.Drawing.Point(138, 163);
            this.datum_postavljanja.Name = "datum_postavljanja";
            this.datum_postavljanja.Size = new System.Drawing.Size(246, 22);
            this.datum_postavljanja.TabIndex = 7;
            this.datum_postavljanja.ValueChanged += new System.EventHandler(this.datum_postavljanja_ValueChanged);
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(138, 77);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(246, 22);
            this.ime.TabIndex = 1;
            this.ime.TextChanged += new System.EventHandler(this.ime_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Datum postavljanja";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ime";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Datum zaposlenja";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // datum_zaposlenja
            // 
            this.datum_zaposlenja.Location = new System.Drawing.Point(138, 122);
            this.datum_zaposlenja.Name = "datum_zaposlenja";
            this.datum_zaposlenja.Size = new System.Drawing.Size(246, 22);
            this.datum_zaposlenja.TabIndex = 4;
            this.datum_zaposlenja.ValueChanged += new System.EventHandler(this.datum_zaposlenja_ValueChanged);
            // 
            // IzmeniSefaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 418);
            this.Controls.Add(this.groupBox2);
            this.Name = "IzmeniSefaForma";
            this.Text = "IzmeniSefa";
            this.Load += new System.EventHandler(this.IzmeniSefaForma_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker datum_postavljanja;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datum_zaposlenja;
    }
}