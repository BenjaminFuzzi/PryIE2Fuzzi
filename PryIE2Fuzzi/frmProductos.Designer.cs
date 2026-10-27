namespace PryIE2Fuzzi
{
    partial class frmProductos
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
            TextBox txtDescripcion;
            gbxDatos = new GroupBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            lblStock = new Label();
            lblID = new Label();
            txtID = new TextBox();
            lblDescripcion = new Label();
            btnConsultar = new Button();
            btnBaja = new Button();
            btnModificar = new Button();
            btnAlta = new Button();
            dgvProductos = new DataGridView();
            menuStrip1 = new MenuStrip();
            volverToolStripMenuItem = new ToolStripMenuItem();
            txtDescripcion = new TextBox();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(245, 26);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(133, 56);
            txtDescripcion.TabIndex = 8;
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(lblPrecio);
            gbxDatos.Controls.Add(txtPrecio);
            gbxDatos.Controls.Add(txtStock);
            gbxDatos.Controls.Add(lblStock);
            gbxDatos.Controls.Add(lblID);
            gbxDatos.Controls.Add(txtDescripcion);
            gbxDatos.Controls.Add(txtID);
            gbxDatos.Controls.Add(lblDescripcion);
            gbxDatos.Location = new Point(12, 27);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(394, 96);
            gbxDatos.TabIndex = 16;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(83, 62);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += lblApellido_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(123, 59);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(41, 23);
            txtPrecio.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(45, 59);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(35, 23);
            txtStock.TabIndex = 12;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(6, 62);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 11;
            lblStock.Text = "Stock";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(6, 29);
            lblID.Name = "lblID";
            lblID.RightToLeft = RightToLeft.No;
            lblID.Size = new Size(91, 15);
            lblID.TabIndex = 5;
            lblID.Text = "ID Seleccionado";
            // 
            // txtID
            // 
            txtID.Location = new Point(103, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 23);
            txtID.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(170, 31);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(12, 334);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(80, 23);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(348, 334);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(75, 23);
            btnBaja.TabIndex = 14;
            btnBaja.Text = "Eliminar";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(429, 334);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(510, 334);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 12;
            btnAlta.Text = "Agregar";
            btnAlta.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 129);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(573, 199);
            dgvProductos.TabIndex = 11;
            dgvProductos.CellContentClick += dgvClientes_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { volverToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            volverToolStripMenuItem.Size = new Size(51, 20);
            volverToolStripMenuItem.Text = "Volver";
            volverToolStripMenuItem.Click += volverToolStripMenuItem_Click;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 362);
            Controls.Add(gbxDatos);
            Controls.Add(btnConsultar);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnAlta);
            Controls.Add(dgvProductos);
            Controls.Add(menuStrip1);
            Name = "frmProductos";
            Text = "Productos";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatos;
        private TextBox txtStock;
        private Label lblStock;
        private Label lblID;
        private TextBox txtDescripcion;
        private TextBox txtID;
        private Label lblDescripcion;
        private Button btnConsultar;
        private Button btnBaja;
        private Button btnModificar;
        private Button btnAlta;
        private DataGridView dgvProductos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem volverToolStripMenuItem;
        private Label lblPrecio;
        private TextBox txtPrecio;
    }
}