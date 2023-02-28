namespace DigitalniPotpis
{
    partial class Kriptiranje
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSadrzajDatoteke = new System.Windows.Forms.TextBox();
            this.tbKriptiranaPoruka = new System.Windows.Forms.TextBox();
            this.tbDekriptiranaPoruka = new System.Windows.Forms.TextBox();
            this.tbSHAsazetak = new System.Windows.Forms.TextBox();
            this.tbDigitalniPotpis = new System.Windows.Forms.TextBox();
            this.btnUcitajSadrzajDatoteke = new System.Windows.Forms.Button();
            this.btnKreirajKljuceve = new System.Windows.Forms.Button();
            this.btnKriptiraj = new System.Windows.Forms.Button();
            this.btnDekriptiraj = new System.Windows.Forms.Button();
            this.cbAES = new System.Windows.Forms.CheckBox();
            this.cbRSA = new System.Windows.Forms.CheckBox();
            this.btnIzracunajSazetak = new System.Windows.Forms.Button();
            this.btnProvjeriDigitalniPotpis = new System.Windows.Forms.Button();
            this.btnIzracunajDigitalniPotpis = new System.Windows.Forms.Button();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sadržaj iz datoteke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kriptirana poruka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dekriptirana \r\nporuka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SHA256 sažetak:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Digitalni potpis:";
            // 
            // tbSadrzajDatoteke
            // 
            this.tbSadrzajDatoteke.Enabled = false;
            this.tbSadrzajDatoteke.Location = new System.Drawing.Point(183, 59);
            this.tbSadrzajDatoteke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSadrzajDatoteke.Multiline = true;
            this.tbSadrzajDatoteke.Name = "tbSadrzajDatoteke";
            this.tbSadrzajDatoteke.Size = new System.Drawing.Size(409, 95);
            this.tbSadrzajDatoteke.TabIndex = 5;
            // 
            // tbKriptiranaPoruka
            // 
            this.tbKriptiranaPoruka.Enabled = false;
            this.tbKriptiranaPoruka.Location = new System.Drawing.Point(183, 179);
            this.tbKriptiranaPoruka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbKriptiranaPoruka.Multiline = true;
            this.tbKriptiranaPoruka.Name = "tbKriptiranaPoruka";
            this.tbKriptiranaPoruka.Size = new System.Drawing.Size(409, 92);
            this.tbKriptiranaPoruka.TabIndex = 6;
            // 
            // tbDekriptiranaPoruka
            // 
            this.tbDekriptiranaPoruka.Enabled = false;
            this.tbDekriptiranaPoruka.Location = new System.Drawing.Point(183, 295);
            this.tbDekriptiranaPoruka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDekriptiranaPoruka.Multiline = true;
            this.tbDekriptiranaPoruka.Name = "tbDekriptiranaPoruka";
            this.tbDekriptiranaPoruka.Size = new System.Drawing.Size(409, 97);
            this.tbDekriptiranaPoruka.TabIndex = 7;
            // 
            // tbSHAsazetak
            // 
            this.tbSHAsazetak.Enabled = false;
            this.tbSHAsazetak.Location = new System.Drawing.Point(183, 433);
            this.tbSHAsazetak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSHAsazetak.Multiline = true;
            this.tbSHAsazetak.Name = "tbSHAsazetak";
            this.tbSHAsazetak.Size = new System.Drawing.Size(409, 95);
            this.tbSHAsazetak.TabIndex = 8;
            // 
            // tbDigitalniPotpis
            // 
            this.tbDigitalniPotpis.Enabled = false;
            this.tbDigitalniPotpis.Location = new System.Drawing.Point(183, 553);
            this.tbDigitalniPotpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDigitalniPotpis.Multiline = true;
            this.tbDigitalniPotpis.Name = "tbDigitalniPotpis";
            this.tbDigitalniPotpis.Size = new System.Drawing.Size(409, 108);
            this.tbDigitalniPotpis.TabIndex = 9;
            // 
            // btnUcitajSadrzajDatoteke
            // 
            this.btnUcitajSadrzajDatoteke.Location = new System.Drawing.Point(629, 59);
            this.btnUcitajSadrzajDatoteke.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUcitajSadrzajDatoteke.Name = "btnUcitajSadrzajDatoteke";
            this.btnUcitajSadrzajDatoteke.Size = new System.Drawing.Size(194, 44);
            this.btnUcitajSadrzajDatoteke.TabIndex = 10;
            this.btnUcitajSadrzajDatoteke.Text = "Učitaj sadržaj datoteke";
            this.btnUcitajSadrzajDatoteke.UseVisualStyleBackColor = true;
            this.btnUcitajSadrzajDatoteke.Click += new System.EventHandler(this.btnUcitajSadrzajDatoteke_Click);
            // 
            // btnKreirajKljuceve
            // 
            this.btnKreirajKljuceve.Location = new System.Drawing.Point(629, 111);
            this.btnKreirajKljuceve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKreirajKljuceve.Name = "btnKreirajKljuceve";
            this.btnKreirajKljuceve.Size = new System.Drawing.Size(194, 44);
            this.btnKreirajKljuceve.TabIndex = 11;
            this.btnKreirajKljuceve.Text = "Kreiraj ključeve";
            this.btnKreirajKljuceve.UseVisualStyleBackColor = true;
            this.btnKreirajKljuceve.Click += new System.EventHandler(this.btnKreirajKljuceve_Click);
            // 
            // btnKriptiraj
            // 
            this.btnKriptiraj.Location = new System.Drawing.Point(629, 228);
            this.btnKriptiraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKriptiraj.Name = "btnKriptiraj";
            this.btnKriptiraj.Size = new System.Drawing.Size(194, 44);
            this.btnKriptiraj.TabIndex = 12;
            this.btnKriptiraj.Text = "Kriptiraj";
            this.btnKriptiraj.UseVisualStyleBackColor = true;
            this.btnKriptiraj.Click += new System.EventHandler(this.btnKriptiraj_Click);
            // 
            // btnDekriptiraj
            // 
            this.btnDekriptiraj.Location = new System.Drawing.Point(629, 349);
            this.btnDekriptiraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDekriptiraj.Name = "btnDekriptiraj";
            this.btnDekriptiraj.Size = new System.Drawing.Size(194, 44);
            this.btnDekriptiraj.TabIndex = 13;
            this.btnDekriptiraj.Text = "Dekriptiraj";
            this.btnDekriptiraj.UseVisualStyleBackColor = true;
            this.btnDekriptiraj.Click += new System.EventHandler(this.btnDekriptiraj_Click);
            // 
            // cbAES
            // 
            this.cbAES.AutoSize = true;
            this.cbAES.Location = new System.Drawing.Point(662, 195);
            this.cbAES.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAES.Name = "cbAES";
            this.cbAES.Size = new System.Drawing.Size(57, 24);
            this.cbAES.TabIndex = 14;
            this.cbAES.Text = "AES";
            this.cbAES.UseVisualStyleBackColor = true;
            this.cbAES.CheckedChanged += new System.EventHandler(this.cbAES_CheckedChanged);
            // 
            // cbRSA
            // 
            this.cbRSA.AutoSize = true;
            this.cbRSA.Location = new System.Drawing.Point(731, 195);
            this.cbRSA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRSA.Name = "cbRSA";
            this.cbRSA.Size = new System.Drawing.Size(58, 24);
            this.cbRSA.TabIndex = 15;
            this.cbRSA.Text = "RSA";
            this.cbRSA.UseVisualStyleBackColor = true;
            this.cbRSA.CheckedChanged += new System.EventHandler(this.cbRSA_CheckedChanged);
            // 
            // btnIzracunajSazetak
            // 
            this.btnIzracunajSazetak.Location = new System.Drawing.Point(629, 485);
            this.btnIzracunajSazetak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzracunajSazetak.Name = "btnIzracunajSazetak";
            this.btnIzracunajSazetak.Size = new System.Drawing.Size(194, 44);
            this.btnIzracunajSazetak.TabIndex = 16;
            this.btnIzracunajSazetak.Text = "Izračunaj sažetak";
            this.btnIzracunajSazetak.UseVisualStyleBackColor = true;
            this.btnIzracunajSazetak.Click += new System.EventHandler(this.btnIzracunajSazetak_Click);
            // 
            // btnProvjeriDigitalniPotpis
            // 
            this.btnProvjeriDigitalniPotpis.Location = new System.Drawing.Point(629, 617);
            this.btnProvjeriDigitalniPotpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProvjeriDigitalniPotpis.Name = "btnProvjeriDigitalniPotpis";
            this.btnProvjeriDigitalniPotpis.Size = new System.Drawing.Size(194, 45);
            this.btnProvjeriDigitalniPotpis.TabIndex = 17;
            this.btnProvjeriDigitalniPotpis.Text = "Provjeri digitalni potpis";
            this.btnProvjeriDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnProvjeriDigitalniPotpis.Click += new System.EventHandler(this.btnProvjeriDigitalniPotpis_Click);
            // 
            // btnIzracunajDigitalniPotpis
            // 
            this.btnIzracunajDigitalniPotpis.Location = new System.Drawing.Point(629, 553);
            this.btnIzracunajDigitalniPotpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzracunajDigitalniPotpis.Name = "btnIzracunajDigitalniPotpis";
            this.btnIzracunajDigitalniPotpis.Size = new System.Drawing.Size(194, 56);
            this.btnIzracunajDigitalniPotpis.TabIndex = 18;
            this.btnIzracunajDigitalniPotpis.Text = "Izračunaj digitalni potpis";
            this.btnIzracunajDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnIzracunajDigitalniPotpis.Click += new System.EventHandler(this.btnIzracunajDigitalniPotpis_Click);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(314, 671);
            this.btnOcisti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(155, 41);
            this.btnOcisti.TabIndex = 19;
            this.btnOcisti.Text = "Očisti sve";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // Kriptiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(875, 740);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.btnIzracunajDigitalniPotpis);
            this.Controls.Add(this.btnProvjeriDigitalniPotpis);
            this.Controls.Add(this.btnIzracunajSazetak);
            this.Controls.Add(this.cbRSA);
            this.Controls.Add(this.cbAES);
            this.Controls.Add(this.btnDekriptiraj);
            this.Controls.Add(this.btnKriptiraj);
            this.Controls.Add(this.btnKreirajKljuceve);
            this.Controls.Add(this.btnUcitajSadrzajDatoteke);
            this.Controls.Add(this.tbDigitalniPotpis);
            this.Controls.Add(this.tbSHAsazetak);
            this.Controls.Add(this.tbDekriptiranaPoruka);
            this.Controls.Add(this.tbKriptiranaPoruka);
            this.Controls.Add(this.tbSadrzajDatoteke);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Kriptiranje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kriptiranje/dekriptiranje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbSadrzajDatoteke;
        private TextBox tbKriptiranaPoruka;
        private TextBox tbDekriptiranaPoruka;
        private TextBox tbSHAsazetak;
        private TextBox tbDigitalniPotpis;
        private Button btnUcitajSadrzajDatoteke;
        private Button btnKreirajKljuceve;
        private Button btnKriptiraj;
        private Button btnDekriptiraj;
        private CheckBox cbAES;
        private CheckBox cbRSA;
        private Button btnIzracunajSazetak;
        private Button btnProvjeriDigitalniPotpis;
        private Button btnIzracunajDigitalniPotpis;
        private Button btnOcisti;
    }
}