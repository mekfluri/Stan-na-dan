namespace StanNaDanv2.Forme
{
    partial class DodajDodatak
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonParkingMesto = new System.Windows.Forms.RadioButton();
            this.radioButtonKrevet = new System.Windows.Forms.RadioButton();
            this.radioButtonKuhinja = new System.Windows.Forms.RadioButton();
            this.radioButtonDodatnaOprema = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj dodatak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonParkingMesto);
            this.groupBox1.Controls.Add(this.radioButtonKrevet);
            this.groupBox1.Controls.Add(this.radioButtonKuhinja);
            this.groupBox1.Controls.Add(this.radioButtonDodatnaOprema);
            this.groupBox1.Location = new System.Drawing.Point(16, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(223, 262);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButtonParkingMesto
            // 
            this.radioButtonParkingMesto.AutoSize = true;
            this.radioButtonParkingMesto.Location = new System.Drawing.Point(8, 172);
            this.radioButtonParkingMesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonParkingMesto.Name = "radioButtonParkingMesto";
            this.radioButtonParkingMesto.Size = new System.Drawing.Size(114, 20);
            this.radioButtonParkingMesto.TabIndex = 3;
            this.radioButtonParkingMesto.TabStop = true;
            this.radioButtonParkingMesto.Text = "Parking mesto";
            this.radioButtonParkingMesto.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrevet
            // 
            this.radioButtonKrevet.AutoSize = true;
            this.radioButtonKrevet.Location = new System.Drawing.Point(8, 126);
            this.radioButtonKrevet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonKrevet.Name = "radioButtonKrevet";
            this.radioButtonKrevet.Size = new System.Drawing.Size(66, 20);
            this.radioButtonKrevet.TabIndex = 2;
            this.radioButtonKrevet.TabStop = true;
            this.radioButtonKrevet.Text = "Krevet";
            this.radioButtonKrevet.UseVisualStyleBackColor = true;
            // 
            // radioButtonKuhinja
            // 
            this.radioButtonKuhinja.AutoSize = true;
            this.radioButtonKuhinja.Location = new System.Drawing.Point(8, 81);
            this.radioButtonKuhinja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonKuhinja.Name = "radioButtonKuhinja";
            this.radioButtonKuhinja.Size = new System.Drawing.Size(71, 20);
            this.radioButtonKuhinja.TabIndex = 1;
            this.radioButtonKuhinja.TabStop = true;
            this.radioButtonKuhinja.Text = "Kuhinja";
            this.radioButtonKuhinja.UseVisualStyleBackColor = true;
            // 
            // radioButtonDodatnaOprema
            // 
            this.radioButtonDodatnaOprema.AutoSize = true;
            this.radioButtonDodatnaOprema.Checked = true;
            this.radioButtonDodatnaOprema.Location = new System.Drawing.Point(8, 37);
            this.radioButtonDodatnaOprema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonDodatnaOprema.Name = "radioButtonDodatnaOprema";
            this.radioButtonDodatnaOprema.Size = new System.Drawing.Size(130, 20);
            this.radioButtonDodatnaOprema.TabIndex = 0;
            this.radioButtonDodatnaOprema.TabStop = true;
            this.radioButtonDodatnaOprema.Text = "Dodatna oprema";
            this.radioButtonDodatnaOprema.UseVisualStyleBackColor = true;
            // 
            // DodajDodatak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(256, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajDodatak";
            this.Text = "DodajDodatak";
            this.Load += new System.EventHandler(this.DodajDodatak_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonParkingMesto;
        private System.Windows.Forms.RadioButton radioButtonKrevet;
        private System.Windows.Forms.RadioButton radioButtonKuhinja;
        private System.Windows.Forms.RadioButton radioButtonDodatnaOprema;
    }
}