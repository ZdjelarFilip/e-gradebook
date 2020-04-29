namespace WcfForms
{
    partial class Predmet
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
            this.labelEcts = new System.Windows.Forms.Label();
            this.labelKratica = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxEcts = new System.Windows.Forms.TextBox();
            this.textBoxKratica = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonOdstrani = new System.Windows.Forms.Button();
            this.buttonSpremeni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEcts
            // 
            this.labelEcts.AutoSize = true;
            this.labelEcts.Location = new System.Drawing.Point(336, 64);
            this.labelEcts.Name = "labelEcts";
            this.labelEcts.Size = new System.Drawing.Size(38, 13);
            this.labelEcts.TabIndex = 23;
            this.labelEcts.Text = "ECTS:";
            // 
            // labelKratica
            // 
            this.labelKratica.AutoSize = true;
            this.labelKratica.Location = new System.Drawing.Point(336, 27);
            this.labelKratica.Name = "labelKratica";
            this.labelKratica.Size = new System.Drawing.Size(43, 13);
            this.labelKratica.TabIndex = 22;
            this.labelKratica.Text = "Kratica:";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(23, 64);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(37, 13);
            this.labelNaziv.TabIndex = 21;
            this.labelNaziv.Text = "Naziv:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(23, 28);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(70, 13);
            this.labelId.TabIndex = 20;
            this.labelId.Text = "Stara kratica:";
            // 
            // textBoxEcts
            // 
            this.textBoxEcts.Location = new System.Drawing.Point(392, 58);
            this.textBoxEcts.Name = "textBoxEcts";
            this.textBoxEcts.Size = new System.Drawing.Size(125, 20);
            this.textBoxEcts.TabIndex = 19;
            // 
            // textBoxKratica
            // 
            this.textBoxKratica.Location = new System.Drawing.Point(392, 21);
            this.textBoxKratica.Name = "textBoxKratica";
            this.textBoxKratica.Size = new System.Drawing.Size(125, 20);
            this.textBoxKratica.TabIndex = 18;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(104, 21);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(129, 20);
            this.textBoxId.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // buttonOdstrani
            // 
            this.buttonOdstrani.Location = new System.Drawing.Point(361, 106);
            this.buttonOdstrani.Name = "buttonOdstrani";
            this.buttonOdstrani.Size = new System.Drawing.Size(156, 41);
            this.buttonOdstrani.TabIndex = 15;
            this.buttonOdstrani.Text = "Odstrani";
            this.buttonOdstrani.UseVisualStyleBackColor = true;
            this.buttonOdstrani.Click += new System.EventHandler(this.ButtonOdstrani_Click_1);
            // 
            // buttonSpremeni
            // 
            this.buttonSpremeni.Location = new System.Drawing.Point(190, 106);
            this.buttonSpremeni.Name = "buttonSpremeni";
            this.buttonSpremeni.Size = new System.Drawing.Size(165, 41);
            this.buttonSpremeni.TabIndex = 14;
            this.buttonSpremeni.Text = "Spremeni";
            this.buttonSpremeni.UseVisualStyleBackColor = true;
            this.buttonSpremeni.Click += new System.EventHandler(this.ButtonSpremeni_Click_1);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(26, 106);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(158, 41);
            this.buttonDodaj.TabIndex = 13;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.ButtonDodaj_Click_1);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(104, 64);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(129, 20);
            this.textBoxNaziv.TabIndex = 24;
            // 
            // Predmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 336);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelEcts);
            this.Controls.Add(this.labelKratica);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxEcts);
            this.Controls.Add(this.textBoxKratica);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOdstrani);
            this.Controls.Add(this.buttonSpremeni);
            this.Controls.Add(this.buttonDodaj);
            this.Name = "Predmet";
            this.Text = "Predmet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEcts;
        private System.Windows.Forms.Label labelKratica;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxEcts;
        private System.Windows.Forms.TextBox textBoxKratica;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOdstrani;
        private System.Windows.Forms.Button buttonSpremeni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxNaziv;
    }
}