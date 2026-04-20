namespace Konferenciju_sistema
{
    partial class Form1
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
            this.Prisijungti = new System.Windows.Forms.Button();
            this.Miestas = new System.Windows.Forms.ComboBox();
            this.KonferencijuLentele = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Registruotis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KonferencijuLentele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konferenta";
            // 
            // Prisijungti
            // 
            this.Prisijungti.BackColor = System.Drawing.Color.PapayaWhip;
            this.Prisijungti.Location = new System.Drawing.Point(783, 9);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(108, 32);
            this.Prisijungti.TabIndex = 1;
            this.Prisijungti.Text = "Prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = false;
            this.Prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // Miestas
            // 
            this.Miestas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Miestas.FormattingEnabled = true;
            this.Miestas.Location = new System.Drawing.Point(3, 103);
            this.Miestas.Name = "Miestas";
            this.Miestas.Size = new System.Drawing.Size(190, 24);
            this.Miestas.TabIndex = 2;
            this.Miestas.SelectedIndexChanged += new System.EventHandler(this.Miestas_SelectedIndexChanged);
            // 
            // KonferencijuLentele
            // 
            this.KonferencijuLentele.AllowUserToAddRows = false;
            this.KonferencijuLentele.AllowUserToDeleteRows = false;
            this.KonferencijuLentele.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.KonferencijuLentele.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KonferencijuLentele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KonferencijuLentele.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.KonferencijuLentele.Location = new System.Drawing.Point(12, 164);
            this.KonferencijuLentele.Name = "KonferencijuLentele";
            this.KonferencijuLentele.ReadOnly = true;
            this.KonferencijuLentele.RowHeadersWidth = 51;
            this.KonferencijuLentele.RowTemplate.Height = 24;
            this.KonferencijuLentele.Size = new System.Drawing.Size(730, 492);
            this.KonferencijuLentele.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasirink miestą:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(8, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vykstančios konferencijos:";
            // 
            // Registruotis
            // 
            this.Registruotis.BackColor = System.Drawing.Color.PapayaWhip;
            this.Registruotis.Location = new System.Drawing.Point(783, 47);
            this.Registruotis.Name = "Registruotis";
            this.Registruotis.Size = new System.Drawing.Size(108, 32);
            this.Registruotis.TabIndex = 6;
            this.Registruotis.Text = "Registruotis";
            this.Registruotis.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 693);
            this.Controls.Add(this.Registruotis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KonferencijuLentele);
            this.Controls.Add(this.Miestas);
            this.Controls.Add(this.Prisijungti);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pagrindinis puslapis";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KonferencijuLentele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Prisijungti;
        private System.Windows.Forms.ComboBox Miestas;
        private System.Windows.Forms.DataGridView KonferencijuLentele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Registruotis;
    }
}

