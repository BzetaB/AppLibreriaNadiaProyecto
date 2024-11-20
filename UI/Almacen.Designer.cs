namespace UI
{
    partial class Almacen
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
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.radiobutonCodigo = new System.Windows.Forms.RadioButton();
            this.radiobutonProduc = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMermar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dgvVencimineto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimineto)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(637, 22);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(156, 21);
            this.comboCategoria.TabIndex = 2;
            this.comboCategoria.SelectedValueChanged += new System.EventHandler(this.comboCategoria_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categorías:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscar.Location = new System.Drawing.Point(88, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(138, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar:";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(3, 138);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(906, 358);
            this.dgvRegistros.TabIndex = 6;
            this.dgvRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marca:";
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(409, 20);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(148, 21);
            this.comboMarca.TabIndex = 10;
            this.comboMarca.SelectedValueChanged += new System.EventHandler(this.comboMarca_SelectedValueChanged);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(244, 56);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(86, 23);
            this.btnRefrescar.TabIndex = 11;
            this.btnRefrescar.Text = "REFRESCAR ";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // radiobutonCodigo
            // 
            this.radiobutonCodigo.AutoSize = true;
            this.radiobutonCodigo.Location = new System.Drawing.Point(88, 52);
            this.radiobutonCodigo.Name = "radiobutonCodigo";
            this.radiobutonCodigo.Size = new System.Drawing.Size(58, 17);
            this.radiobutonCodigo.TabIndex = 12;
            this.radiobutonCodigo.TabStop = true;
            this.radiobutonCodigo.Text = "Código";
            this.radiobutonCodigo.UseVisualStyleBackColor = true;
            // 
            // radiobutonProduc
            // 
            this.radiobutonProduc.AutoSize = true;
            this.radiobutonProduc.Location = new System.Drawing.Point(152, 54);
            this.radiobutonProduc.Name = "radiobutonProduc";
            this.radiobutonProduc.Size = new System.Drawing.Size(65, 17);
            this.radiobutonProduc.TabIndex = 13;
            this.radiobutonProduc.TabStop = true;
            this.radiobutonProduc.Text = "Nombre ";
            this.radiobutonProduc.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Por:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(244, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMermar
            // 
            this.btnMermar.Enabled = false;
            this.btnMermar.Location = new System.Drawing.Point(647, 81);
            this.btnMermar.Name = "btnMermar";
            this.btnMermar.Size = new System.Drawing.Size(75, 35);
            this.btnMermar.TabIndex = 16;
            this.btnMermar.Text = "MERMAR";
            this.btnMermar.UseVisualStyleBackColor = true;
            this.btnMermar.Click += new System.EventHandler(this.btnMermar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(728, 81);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 36);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(566, 81);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 36);
            this.btnIngresar.TabIndex = 18;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dgvVencimineto
            // 
            this.dgvVencimineto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVencimineto.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvVencimineto.Location = new System.Drawing.Point(915, 12);
            this.dgvVencimineto.Name = "dgvVencimineto";
            this.dgvVencimineto.ReadOnly = true;
            this.dgvVencimineto.Size = new System.Drawing.Size(442, 468);
            this.dgvVencimineto.TabIndex = 19;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 482);
            this.Controls.Add(this.dgvVencimineto);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMermar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radiobutonProduc);
            this.Controls.Add(this.radiobutonCodigo);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCategoria);
            this.Name = "Almacen";
            this.Text = "ALMACEN - LIBRERIA NADIA";
            this.Load += new System.EventHandler(this.Almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVencimineto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.RadioButton radiobutonCodigo;
        private System.Windows.Forms.RadioButton radiobutonProduc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMermar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dgvVencimineto;
    }
}