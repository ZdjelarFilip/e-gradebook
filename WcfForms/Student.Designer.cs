namespace WcfForms
{
    partial class Student
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonSpremeni = new System.Windows.Forms.Button();
            this.buttonOdstrani = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPriimek = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelpriimek = new System.Windows.Forms.Label();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(23, 102);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(158, 41);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.ButtonDodaj_Click);
            // 
            // buttonSpremeni
            // 
            this.buttonSpremeni.Location = new System.Drawing.Point(187, 102);
            this.buttonSpremeni.Name = "buttonSpremeni";
            this.buttonSpremeni.Size = new System.Drawing.Size(165, 41);
            this.buttonSpremeni.TabIndex = 1;
            this.buttonSpremeni.Text = "Spremeni";
            this.buttonSpremeni.UseVisualStyleBackColor = true;
            this.buttonSpremeni.Click += new System.EventHandler(this.ButtonSpremeni_Click);
            // 
            // buttonOdstrani
            // 
            this.buttonOdstrani.Location = new System.Drawing.Point(358, 102);
            this.buttonOdstrani.Name = "buttonOdstrani";
            this.buttonOdstrani.Size = new System.Drawing.Size(156, 41);
            this.buttonOdstrani.TabIndex = 2;
            this.buttonOdstrani.Text = "Odstrani";
            this.buttonOdstrani.UseVisualStyleBackColor = true;
            this.buttonOdstrani.Click += new System.EventHandler(this.ButtonOdstrani_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(491, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(101, 17);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(129, 20);
            this.textBoxId.TabIndex = 4;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(389, 17);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(125, 20);
            this.textBoxIme.TabIndex = 6;
            // 
            // textBoxPriimek
            // 
            this.textBoxPriimek.Location = new System.Drawing.Point(389, 54);
            this.textBoxPriimek.Name = "textBoxPriimek";
            this.textBoxPriimek.Size = new System.Drawing.Size(125, 20);
            this.textBoxPriimek.TabIndex = 7;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(20, 24);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 8;
            this.labelId.Text = "ID:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(20, 60);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(75, 13);
            this.labelDatum.TabIndex = 9;
            this.labelDatum.Text = "Datum rojstva:";
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(333, 23);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(27, 13);
            this.labelIme.TabIndex = 10;
            this.labelIme.Text = "Ime:";
            // 
            // labelpriimek
            // 
            this.labelpriimek.AutoSize = true;
            this.labelpriimek.Location = new System.Drawing.Point(333, 60);
            this.labelpriimek.Name = "labelpriimek";
            this.labelpriimek.Size = new System.Drawing.Size(44, 13);
            this.labelpriimek.TabIndex = 11;
            this.labelpriimek.Text = "Priimek:";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(101, 54);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerDatum.TabIndex = 12;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 319);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.labelpriimek);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxPriimek);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOdstrani);
            this.Controls.Add(this.buttonSpremeni);
            this.Controls.Add(this.buttonDodaj);
            this.Name = "Student";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonSpremeni;
        private System.Windows.Forms.Button buttonOdstrani;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPriimek;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelpriimek;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
    }
}