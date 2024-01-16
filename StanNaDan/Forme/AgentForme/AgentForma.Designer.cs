namespace StanNaDanv2.Forme
{
    partial class AgentForma
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
            this.zaposlenii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IzmeniAgenta = new System.Windows.Forms.Button();
            this.DodajAgenta = new System.Windows.Forms.Button();
            this.ObrisiAgenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.zaposlenii);
            this.groupBox1.Controls.Add(this.IzmeniAgenta);
            this.groupBox1.Controls.Add(this.DodajAgenta);
            this.groupBox1.Controls.Add(this.ObrisiAgenta);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(611, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(466, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Lista spoljnih saradnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zaposlenii
            // 
            this.zaposlenii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.zaposlenii.FullRowSelect = true;
            this.zaposlenii.GridLines = true;
            this.zaposlenii.HideSelection = false;
            this.zaposlenii.Location = new System.Drawing.Point(5, 18);
            this.zaposlenii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zaposlenii.Name = "zaposlenii";
            this.zaposlenii.Size = new System.Drawing.Size(456, 324);
            this.zaposlenii.TabIndex = 4;
            this.zaposlenii.UseCompatibleStateImageBehavior = false;
            this.zaposlenii.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Maticni broj";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum zaposlenja";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Strucna sprema";
            this.columnHeader4.Width = 119;
            // 
            // IzmeniAgenta
            // 
            this.IzmeniAgenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IzmeniAgenta.Location = new System.Drawing.Point(466, 69);
            this.IzmeniAgenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IzmeniAgenta.Name = "IzmeniAgenta";
            this.IzmeniAgenta.Size = new System.Drawing.Size(129, 36);
            this.IzmeniAgenta.TabIndex = 2;
            this.IzmeniAgenta.Text = "Izmeni Agenta";
            this.IzmeniAgenta.UseVisualStyleBackColor = true;
            this.IzmeniAgenta.Click += new System.EventHandler(this.IzmeniAgenta_Click);
            // 
            // DodajAgenta
            // 
            this.DodajAgenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajAgenta.Location = new System.Drawing.Point(466, 29);
            this.DodajAgenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DodajAgenta.Name = "DodajAgenta";
            this.DodajAgenta.Size = new System.Drawing.Size(129, 36);
            this.DodajAgenta.TabIndex = 1;
            this.DodajAgenta.Text = "Dodaj Agenta";
            this.DodajAgenta.UseVisualStyleBackColor = true;
            this.DodajAgenta.Click += new System.EventHandler(this.DodajAgenta_Click);
            // 
            // ObrisiAgenta
            // 
            this.ObrisiAgenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObrisiAgenta.Location = new System.Drawing.Point(466, 110);
            this.ObrisiAgenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ObrisiAgenta.Name = "ObrisiAgenta";
            this.ObrisiAgenta.Size = new System.Drawing.Size(129, 36);
            this.ObrisiAgenta.TabIndex = 0;
            this.ObrisiAgenta.Text = "Obrisi Agenta";
            this.ObrisiAgenta.UseVisualStyleBackColor = true;
            this.ObrisiAgenta.Click += new System.EventHandler(this.ObrisiAgenta_Click);
            // 
            // AgentForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 366);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgentForma";
            this.Text = "Agent";
            this.Load += new System.EventHandler(this.AgentForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView zaposlenii;
        private System.Windows.Forms.Button IzmeniAgenta;
        private System.Windows.Forms.Button DodajAgenta;
        private System.Windows.Forms.Button ObrisiAgenta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}