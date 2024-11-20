namespace UI
{
    partial class VistaProvedoresCompra
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
            this.dgvProvedoresCompra = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedoresCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProvedoresCompra
            // 
            this.dgvProvedoresCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvedoresCompra.Location = new System.Drawing.Point(17, 38);
            this.dgvProvedoresCompra.Name = "dgvProvedoresCompra";
            this.dgvProvedoresCompra.Size = new System.Drawing.Size(350, 239);
            this.dgvProvedoresCompra.TabIndex = 0;
            this.dgvProvedoresCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProvedoresCompra_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROVEEDORES:";
            // 
            // VistaProvedoresCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProvedoresCompra);
            this.Name = "VistaProvedoresCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaProvedoresCompra";
            this.Load += new System.EventHandler(this.VistaProvedoresCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvedoresCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProvedoresCompra;
        private System.Windows.Forms.Label label1;
    }
}