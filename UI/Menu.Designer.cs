namespace UI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.itemAlmacen = new FontAwesome.Sharp.IconMenuItem();
            this.itemCompras = new FontAwesome.Sharp.IconMenuItem();
            this.itemProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.itemVentas = new FontAwesome.Sharp.IconMenuItem();
            this.itemReportes = new FontAwesome.Sharp.IconMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMuestraForm = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemUsuario,
            this.itemAlmacen,
            this.itemCompras,
            this.itemProveedores,
            this.itemVentas,
            this.itemReportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 55);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 77);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemUsuario
            // 
            this.itemUsuario.AutoSize = false;
            this.itemUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.itemUsuario.IconColor = System.Drawing.Color.Black;
            this.itemUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemUsuario.IconSize = 58;
            this.itemUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemUsuario.Name = "itemUsuario";
            this.itemUsuario.Size = new System.Drawing.Size(74, 76);
            this.itemUsuario.Text = "USUARIOS";
            this.itemUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemUsuario.Click += new System.EventHandler(this.itemUsuario_Click);
            // 
            // itemAlmacen
            // 
            this.itemAlmacen.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.itemAlmacen.IconColor = System.Drawing.Color.Black;
            this.itemAlmacen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemAlmacen.IconSize = 58;
            this.itemAlmacen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemAlmacen.Name = "itemAlmacen";
            this.itemAlmacen.Size = new System.Drawing.Size(75, 73);
            this.itemAlmacen.Text = "ALMACEN";
            this.itemAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemAlmacen.Click += new System.EventHandler(this.itemAlmacen_Click);
            // 
            // itemCompras
            // 
            this.itemCompras.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.itemCompras.IconColor = System.Drawing.Color.Black;
            this.itemCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemCompras.IconSize = 58;
            this.itemCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemCompras.Name = "itemCompras";
            this.itemCompras.Size = new System.Drawing.Size(75, 73);
            this.itemCompras.Text = "COMPRAS";
            this.itemCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemCompras.Click += new System.EventHandler(this.itemCompras_Click);
            // 
            // itemProveedores
            // 
            this.itemProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.itemProveedores.IconColor = System.Drawing.Color.Black;
            this.itemProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemProveedores.IconSize = 58;
            this.itemProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemProveedores.Name = "itemProveedores";
            this.itemProveedores.Size = new System.Drawing.Size(97, 73);
            this.itemProveedores.Text = "PROVEEDORES";
            this.itemProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.itemProveedores.Click += new System.EventHandler(this.itemProveedores_Click);
            // 
            // itemVentas
            // 
            this.itemVentas.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.itemVentas.IconColor = System.Drawing.Color.Black;
            this.itemVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemVentas.IconSize = 58;
            this.itemVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemVentas.Name = "itemVentas";
            this.itemVentas.Size = new System.Drawing.Size(70, 73);
            this.itemVentas.Text = "VENTAS";
            this.itemVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // itemReportes
            // 
            this.itemReportes.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.itemReportes.IconColor = System.Drawing.Color.Black;
            this.itemReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.itemReportes.IconSize = 58;
            this.itemReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemReportes.Name = "itemReportes";
            this.itemReportes.Size = new System.Drawing.Size(72, 73);
            this.itemReportes.Text = "REPORTES";
            this.itemReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1121, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelMuestraForm
            // 
            this.PanelMuestraForm.BackColor = System.Drawing.Color.SteelBlue;
            this.PanelMuestraForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMuestraForm.Location = new System.Drawing.Point(0, 132);
            this.PanelMuestraForm.Name = "PanelMuestraForm";
            this.PanelMuestraForm.Size = new System.Drawing.Size(1331, 447);
            this.PanelMuestraForm.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Navy;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1331, 55);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 30;
            this.btnSalir.Location = new System.Drawing.Point(12, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 34);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(445, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cargo: ";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.BackColor = System.Drawing.Color.Navy;
            this.labelCargo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.ForeColor = System.Drawing.Color.White;
            this.labelCargo.Location = new System.Drawing.Point(549, 14);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(96, 26);
            this.labelCargo.TabIndex = 7;
            this.labelCargo.Text = "cargo";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 579);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.PanelMuestraForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU-LIBRERIA NADIA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem itemUsuario;
        private FontAwesome.Sharp.IconMenuItem itemAlmacen;
        private FontAwesome.Sharp.IconMenuItem itemCompras;
        private FontAwesome.Sharp.IconMenuItem itemProveedores;
        private FontAwesome.Sharp.IconMenuItem itemVentas;
        private FontAwesome.Sharp.IconMenuItem itemReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelMuestraForm;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCargo;
    }
}