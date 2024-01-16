
namespace StanNaDanv2.Forme
{
    partial class FormaZaDodavanjeAgencije
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
            this.cmdDodajAgenciju = new System.Windows.Forms.Button();
            this.textAgencija = new System.Windows.Forms.TextBox();
            this.labelaAgencija = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDodajAgenciju
            // 
            this.cmdDodajAgenciju.BackColor = System.Drawing.Color.Linen;
            this.cmdDodajAgenciju.Location = new System.Drawing.Point(28, 135);
            this.cmdDodajAgenciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdDodajAgenciju.Name = "cmdDodajAgenciju";
            this.cmdDodajAgenciju.Size = new System.Drawing.Size(156, 30);
            this.cmdDodajAgenciju.TabIndex = 0;
            this.cmdDodajAgenciju.Text = "Dodaj";
            this.cmdDodajAgenciju.UseVisualStyleBackColor = false;
            this.cmdDodajAgenciju.Click += new System.EventHandler(this.cmdDodajAgenciju_Click);
            // 
            // textAgencija
            // 
            this.textAgencija.Location = new System.Drawing.Point(81, 89);
            this.textAgencija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAgencija.Name = "textAgencija";
            this.textAgencija.Size = new System.Drawing.Size(280, 22);
            this.textAgencija.TabIndex = 1;
            // 
            // labelaAgencija
            // 
            this.labelaAgencija.AutoSize = true;
            this.labelaAgencija.Location = new System.Drawing.Point(24, 89);
            this.labelaAgencija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelaAgencija.Name = "labelaAgencija";
            this.labelaAgencija.Size = new System.Drawing.Size(44, 16);
            this.labelaAgencija.TabIndex = 2;
            this.labelaAgencija.Text = "Naziv:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Osnovni podaci o agenciji:";
            // 
            // FormaZaDodavanjeAgencije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 258);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelaAgencija);
            this.Controls.Add(this.textAgencija);
            this.Controls.Add(this.cmdDodajAgenciju);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormaZaDodavanjeAgencije";
            this.Text = "DODAVANJE AGENCIIJE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDodajAgenciju;
        private System.Windows.Forms.TextBox textAgencija;
        private System.Windows.Forms.Label labelaAgencija;
        private System.Windows.Forms.Label label1;
    }
}