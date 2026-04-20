namespace Konferenciju_sistema
{
    partial class Form6
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
            this.KonferencijuLentele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KonferencijuLentele)).BeginInit();
            this.SuspendLayout();
            // 
            // KonferencijuLentele
            // 
            this.KonferencijuLentele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KonferencijuLentele.Location = new System.Drawing.Point(2, 148);
            this.KonferencijuLentele.Name = "KonferencijuLentele";
            this.KonferencijuLentele.RowHeadersWidth = 51;
            this.KonferencijuLentele.RowTemplate.Height = 24;
            this.KonferencijuLentele.Size = new System.Drawing.Size(786, 301);
            this.KonferencijuLentele.TabIndex = 0;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KonferencijuLentele);
            this.Name = "Form6";
            this.Text = "Keisti konferencija";
            ((System.ComponentModel.ISupportInitialize)(this.KonferencijuLentele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView KonferencijuLentele;
    }
}