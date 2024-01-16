namespace StanNaDanv2.Forme
{
    partial class DodajNajam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAgencijaID = new System.Windows.Forms.TextBox();
            this.textBoxAgentMATBR = new System.Windows.Forms.TextBox();
            this.textBoxNekretninaID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxCenaPoDanu = new System.Windows.Forms.TextBox();
            this.DatumKrajaNajma = new System.Windows.Forms.DateTimePicker();
            this.DatumPocetkaNajma = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxAgencijaID);
            this.groupBox1.Controls.Add(this.textBoxAgentMATBR);
            this.groupBox1.Controls.Add(this.textBoxNekretninaID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBoxCenaPoDanu);
            this.groupBox1.Controls.Add(this.DatumKrajaNajma);
            this.groupBox1.Controls.Add(this.DatumPocetkaNajma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 344);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Najam";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAgencijaID
            // 
            this.textBoxAgencijaID.Location = new System.Drawing.Point(126, 101);
            this.textBoxAgencijaID.Name = "textBoxAgencijaID";
            this.textBoxAgencijaID.Size = new System.Drawing.Size(140, 20);
            this.textBoxAgencijaID.TabIndex = 22;
            // 
            // textBoxAgentMATBR
            // 
            this.textBoxAgentMATBR.Location = new System.Drawing.Point(126, 68);
            this.textBoxAgentMATBR.Name = "textBoxAgentMATBR";
            this.textBoxAgentMATBR.Size = new System.Drawing.Size(140, 20);
            this.textBoxAgentMATBR.TabIndex = 21;
            // 
            // textBoxNekretninaID
            // 
            this.textBoxNekretninaID.Location = new System.Drawing.Point(126, 36);
            this.textBoxNekretninaID.Name = "textBoxNekretninaID";
            this.textBoxNekretninaID.Size = new System.Drawing.Size(140, 20);
            this.textBoxNekretninaID.TabIndex = 20;
            this.textBoxNekretninaID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Agencija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Agent";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(126, 240);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // textBoxCenaPoDanu
            // 
            this.textBoxCenaPoDanu.Location = new System.Drawing.Point(126, 210);
            this.textBoxCenaPoDanu.Name = "textBoxCenaPoDanu";
            this.textBoxCenaPoDanu.Size = new System.Drawing.Size(140, 20);
            this.textBoxCenaPoDanu.TabIndex = 8;
            // 
            // DatumKrajaNajma
            // 
            this.DatumKrajaNajma.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumKrajaNajma.Location = new System.Drawing.Point(126, 167);
            this.DatumKrajaNajma.Name = "DatumKrajaNajma";
            this.DatumKrajaNajma.Size = new System.Drawing.Size(140, 20);
            this.DatumKrajaNajma.TabIndex = 7;
            // 
            // DatumPocetkaNajma
            // 
            this.DatumPocetkaNajma.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatumPocetkaNajma.Location = new System.Drawing.Point(126, 139);
            this.DatumPocetkaNajma.Name = "DatumPocetkaNajma";
            this.DatumPocetkaNajma.Size = new System.Drawing.Size(140, 20);
            this.DatumPocetkaNajma.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nekretnina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Popust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena po danu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum zavrsetka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum pocetka";
            // 
            // DodajNajam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 370);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajNajam";
            this.Text = "NajamForma";
            this.Load += new System.EventHandler(this.DodajNajam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCenaPoDanu;
        private System.Windows.Forms.DateTimePicker DatumKrajaNajma;
        private System.Windows.Forms.DateTimePicker DatumPocetkaNajma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNekretninaID;
        private System.Windows.Forms.TextBox textBoxAgencijaID;
        private System.Windows.Forms.TextBox textBoxAgentMATBR;
    }
}