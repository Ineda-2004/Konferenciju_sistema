namespace Konferenciju_sistema
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.elpastas = new System.Windows.Forms.TextBox();
            this.slapt = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnPrisijungti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "El. paštas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slaptažodis:";
            // 
            // elpastas
            // 
            this.elpastas.Location = new System.Drawing.Point(140, 64);
            this.elpastas.Name = "elpastas";
            this.elpastas.Size = new System.Drawing.Size(273, 22);
            this.elpastas.TabIndex = 2;
            // 
            // slapt
            // 
            this.slapt.Location = new System.Drawing.Point(140, 105);
            this.slapt.Name = "slapt";
            this.slapt.PasswordChar = '*';
            this.slapt.Size = new System.Drawing.Size(273, 22);
            this.slapt.TabIndex = 3;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnPrisijungti
            // 
            this.btnPrisijungti.Location = new System.Drawing.Point(199, 162);
            this.btnPrisijungti.Name = "btnPrisijungti";
            this.btnPrisijungti.Size = new System.Drawing.Size(100, 29);
            this.btnPrisijungti.TabIndex = 4;
            this.btnPrisijungti.Text = "Prisijungti";
            this.btnPrisijungti.UseVisualStyleBackColor = true;
            this.btnPrisijungti.Click += new System.EventHandler(this.btnPrisijungti_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrisijungti);
            this.Controls.Add(this.slapt);
            this.Controls.Add(this.elpastas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Prisijungimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox elpastas;
        private System.Windows.Forms.TextBox slapt;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnPrisijungti;
    }
}