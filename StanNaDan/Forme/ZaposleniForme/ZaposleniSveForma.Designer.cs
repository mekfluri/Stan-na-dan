namespace StanNaDanv2.Forme.ZaposleniForme
{
    partial class ZaposleniSveForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbBrojZaposlenih = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zaposlenii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbBrojZaposlenih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.zaposlenii);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 457);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaposleni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(510, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ukupan broj zaposlenih:";
            // 
            // txbBrojZaposlenih
            // 
            this.txbBrojZaposlenih.Location = new System.Drawing.Point(510, 186);
            this.txbBrojZaposlenih.Name = "txbBrojZaposlenih";
            this.txbBrojZaposlenih.ReadOnly = true;
            this.txbBrojZaposlenih.Size = new System.Drawing.Size(160, 22);
            this.txbBrojZaposlenih.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "U tabeli su prikazani svi \r\nzaposleni svih agencija. \r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // zaposlenii
            // 
            this.zaposlenii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.zaposlenii.FullRowSelect = true;
            this.zaposlenii.GridLines = true;
            this.zaposlenii.HideSelection = false;
            this.zaposlenii.Location = new System.Drawing.Point(7, 22);
            this.zaposlenii.Name = "zaposlenii";
            this.zaposlenii.Size = new System.Drawing.Size(416, 415);
            this.zaposlenii.TabIndex = 0;
            this.zaposlenii.UseCompatibleStateImageBehavior = false;
            this.zaposlenii.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Maticni broj";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 57;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum zaposlenja";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sef";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Agent";
            // 
            // ZaposleniSveForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 483);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZaposleniSveForms";
            this.Text = "ZaposleniSveForms";
            this.Load += new System.EventHandler(this.ZaposleniSveForms_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBrojZaposlenih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView zaposlenii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}