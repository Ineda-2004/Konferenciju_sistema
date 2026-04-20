namespace Konferenciju_sistema
{
    partial class Organizatorius
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPavadinimas = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAprasymas = new System.Windows.Forms.TextBox();
            this.cmbMiestas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.cmbBusena = new System.Windows.Forms.ComboBox();
            this.btnPrideti = new System.Windows.Forms.Button();
            this.txtAdresas = new System.Windows.Forms.TextBox();
            this.txtPastas = new System.Windows.Forms.TextBox();
            this.chkNuotolinis = new System.Windows.Forms.CheckBox();
            this.Keist = new System.Windows.Forms.Button();
            this.btnAtsijungti = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Adresesas = new System.Windows.Forms.Label();
            this.Pastatas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pavadinimas";
            // 
            // txtPavadinimas
            // 
            this.txtPavadinimas.Location = new System.Drawing.Point(106, 40);
            this.txtPavadinimas.Name = "txtPavadinimas";
            this.txtPavadinimas.Size = new System.Drawing.Size(267, 22);
            this.txtPavadinimas.TabIndex = 1;
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(16, 85);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(357, 22);
            this.dtpData.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aprašymas";
            // 
            // txtAprasymas
            // 
            this.txtAprasymas.Location = new System.Drawing.Point(13, 167);
            this.txtAprasymas.Name = "txtAprasymas";
            this.txtAprasymas.Size = new System.Drawing.Size(500, 22);
            this.txtAprasymas.TabIndex = 4;
            // 
            // cmbMiestas
            // 
            this.cmbMiestas.FormattingEnabled = true;
            this.cmbMiestas.Location = new System.Drawing.Point(13, 228);
            this.cmbMiestas.Name = "cmbMiestas";
            this.cmbMiestas.Size = new System.Drawing.Size(121, 24);
            this.cmbMiestas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Miestas";
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(215, 228);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(121, 24);
            this.cmbTema.TabIndex = 7;
            // 
            // cmbBusena
            // 
            this.cmbBusena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusena.FormattingEnabled = true;
            this.cmbBusena.Location = new System.Drawing.Point(404, 228);
            this.cmbBusena.Name = "cmbBusena";
            this.cmbBusena.Size = new System.Drawing.Size(121, 24);
            this.cmbBusena.TabIndex = 8;
            // 
            // btnPrideti
            // 
            this.btnPrideti.Location = new System.Drawing.Point(450, 395);
            this.btnPrideti.Name = "btnPrideti";
            this.btnPrideti.Size = new System.Drawing.Size(75, 23);
            this.btnPrideti.TabIndex = 9;
            this.btnPrideti.Text = "Pridėti";
            this.btnPrideti.UseVisualStyleBackColor = true;
            this.btnPrideti.Click += new System.EventHandler(this.btnPrideti_Click);
            // 
            // txtAdresas
            // 
            this.txtAdresas.Location = new System.Drawing.Point(16, 323);
            this.txtAdresas.Name = "txtAdresas";
            this.txtAdresas.Size = new System.Drawing.Size(100, 22);
            this.txtAdresas.TabIndex = 10;
            // 
            // txtPastas
            // 
            this.txtPastas.Location = new System.Drawing.Point(218, 323);
            this.txtPastas.Name = "txtPastas";
            this.txtPastas.Size = new System.Drawing.Size(100, 22);
            this.txtPastas.TabIndex = 11;
            // 
            // chkNuotolinis
            // 
            this.chkNuotolinis.AutoSize = true;
            this.chkNuotolinis.Location = new System.Drawing.Point(425, 325);
            this.chkNuotolinis.Name = "chkNuotolinis";
            this.chkNuotolinis.Size = new System.Drawing.Size(88, 20);
            this.chkNuotolinis.TabIndex = 12;
            this.chkNuotolinis.Text = "Nuotoliniu";
            this.chkNuotolinis.UseVisualStyleBackColor = true;
            // 
            // Keist
            // 
            this.Keist.Location = new System.Drawing.Point(545, 395);
            this.Keist.Name = "Keist";
            this.Keist.Size = new System.Drawing.Size(223, 23);
            this.Keist.TabIndex = 13;
            this.Keist.Text = "Keisti konferencijas";
            this.Keist.UseVisualStyleBackColor = true;
            this.Keist.Click += new System.EventHandler(this.Keist_Click);
            // 
            // btnAtsijungti
            // 
            this.btnAtsijungti.Location = new System.Drawing.Point(700, 13);
            this.btnAtsijungti.Name = "btnAtsijungti";
            this.btnAtsijungti.Size = new System.Drawing.Size(88, 27);
            this.btnAtsijungti.TabIndex = 14;
            this.btnAtsijungti.Text = "Atsijungti";
            this.btnAtsijungti.UseVisualStyleBackColor = true;
            this.btnAtsijungti.Click += new System.EventHandler(this.btnAtsijungti_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tema";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Būsena";
            // 
            // Adresesas
            // 
            this.Adresesas.AutoSize = true;
            this.Adresesas.Location = new System.Drawing.Point(16, 301);
            this.Adresesas.Name = "Adresesas";
            this.Adresesas.Size = new System.Drawing.Size(58, 16);
            this.Adresesas.TabIndex = 17;
            this.Adresesas.Text = "Adresas";
            // 
            // Pastatas
            // 
            this.Pastatas.AutoSize = true;
            this.Pastatas.Location = new System.Drawing.Point(215, 301);
            this.Pastatas.Name = "Pastatas";
            this.Pastatas.Size = new System.Drawing.Size(60, 16);
            this.Pastatas.TabIndex = 18;
            this.Pastatas.Text = "Pastatas";
            // 
            // Organizatorius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pastatas);
            this.Controls.Add(this.Adresesas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAtsijungti);
            this.Controls.Add(this.Keist);
            this.Controls.Add(this.chkNuotolinis);
            this.Controls.Add(this.txtPastas);
            this.Controls.Add(this.txtAdresas);
            this.Controls.Add(this.btnPrideti);
            this.Controls.Add(this.cmbBusena);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMiestas);
            this.Controls.Add(this.txtAprasymas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtPavadinimas);
            this.Controls.Add(this.label1);
            this.Name = "Organizatorius";
            this.Text = "Organizatorius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPavadinimas;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAprasymas;
        private System.Windows.Forms.ComboBox cmbMiestas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.ComboBox cmbBusena;
        private System.Windows.Forms.Button btnPrideti;
        private System.Windows.Forms.TextBox txtAdresas;
        private System.Windows.Forms.TextBox txtPastas;
        private System.Windows.Forms.CheckBox chkNuotolinis;
        private System.Windows.Forms.Button Keist;
        private System.Windows.Forms.Button btnAtsijungti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Adresesas;
        private System.Windows.Forms.Label Pastatas;
    }
}