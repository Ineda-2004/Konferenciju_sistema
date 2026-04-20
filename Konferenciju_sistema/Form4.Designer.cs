namespace Konferenciju_sistema
{
    partial class Form4
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
            this.comboMiestai = new System.Windows.Forms.ComboBox();
            this.dataKonferencijos = new System.Windows.Forms.DataGridView();
            this.btnRegistruotis = new System.Windows.Forms.Button();
            this.btnAtsijungti = new System.Windows.Forms.Button();
            this.Profilis = new System.Windows.Forms.Button();
            this.Dalyvavimai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataKonferencijos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Konferenta";
            // 
            // comboMiestai
            // 
            this.comboMiestai.FormattingEnabled = true;
            this.comboMiestai.Location = new System.Drawing.Point(3, 157);
            this.comboMiestai.Name = "comboMiestai";
            this.comboMiestai.Size = new System.Drawing.Size(160, 24);
            this.comboMiestai.TabIndex = 2;
            // 
            // dataKonferencijos
            // 
            this.dataKonferencijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKonferencijos.Location = new System.Drawing.Point(3, 187);
            this.dataKonferencijos.Name = "dataKonferencijos";
            this.dataKonferencijos.RowHeadersWidth = 51;
            this.dataKonferencijos.RowTemplate.Height = 24;
            this.dataKonferencijos.Size = new System.Drawing.Size(684, 260);
            this.dataKonferencijos.TabIndex = 3;
            // 
            // btnRegistruotis
            // 
            this.btnRegistruotis.Location = new System.Drawing.Point(694, 408);
            this.btnRegistruotis.Name = "btnRegistruotis";
            this.btnRegistruotis.Size = new System.Drawing.Size(156, 30);
            this.btnRegistruotis.TabIndex = 4;
            this.btnRegistruotis.Text = "Registruotis";
            this.btnRegistruotis.UseVisualStyleBackColor = true;
            // 
            // btnAtsijungti
            // 
            this.btnAtsijungti.Location = new System.Drawing.Point(743, 60);
            this.btnAtsijungti.Name = "btnAtsijungti";
            this.btnAtsijungti.Size = new System.Drawing.Size(94, 32);
            this.btnAtsijungti.TabIndex = 5;
            this.btnAtsijungti.Text = "Atsijungti";
            this.btnAtsijungti.UseVisualStyleBackColor = true;
            this.btnAtsijungti.Click += new System.EventHandler(this.btnAtsijungti_Click);
            // 
            // Profilis
            // 
            this.Profilis.Location = new System.Drawing.Point(743, 20);
            this.Profilis.Name = "Profilis";
            this.Profilis.Size = new System.Drawing.Size(94, 34);
            this.Profilis.TabIndex = 6;
            this.Profilis.Text = "Profilis";
            this.Profilis.UseVisualStyleBackColor = true;
            // 
            // Dalyvavimai
            // 
            this.Dalyvavimai.Location = new System.Drawing.Point(694, 358);
            this.Dalyvavimai.Name = "Dalyvavimai";
            this.Dalyvavimai.Size = new System.Drawing.Size(155, 23);
            this.Dalyvavimai.TabIndex = 7;
            this.Dalyvavimai.Text = "Dalyvavaimai";
            this.Dalyvavimai.UseVisualStyleBackColor = true;
            this.Dalyvavimai.Click += new System.EventHandler(this.Dalyvavimai_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.Dalyvavimai);
            this.Controls.Add(this.Profilis);
            this.Controls.Add(this.btnAtsijungti);
            this.Controls.Add(this.btnRegistruotis);
            this.Controls.Add(this.dataKonferencijos);
            this.Controls.Add(this.comboMiestai);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Pagrindinis puslapis";
            ((System.ComponentModel.ISupportInitialize)(this.dataKonferencijos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMiestai;
        private System.Windows.Forms.DataGridView dataKonferencijos;
        private System.Windows.Forms.Button btnRegistruotis;
        private System.Windows.Forms.Button btnAtsijungti;
        private System.Windows.Forms.Button Profilis;
        private System.Windows.Forms.Button Dalyvavimai;
    }
}