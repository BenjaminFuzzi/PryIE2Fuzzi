namespace PryIE2Fuzzi
{
    partial class frmProveedores
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
            gbxDatos = new GroupBox();
            txtMail = new TextBox();
            lblMail = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            lblID = new Label();
            txtRazonSocial = new TextBox();
            txtID = new TextBox();
            lblRazonSocial = new Label();
            btnConsultar = new Button();
            btnBaja = new Button();
            btnModificar = new Button();
            btnAlta = new Button();
            dgvProveedores = new DataGridView();
            menuStrip1 = new MenuStrip();
            volverToolStripMenuItem = new ToolStripMenuItem();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(txtMail);
            gbxDatos.Controls.Add(lblMail);
            gbxDatos.Controls.Add(txtTelefono);
            gbxDatos.Controls.Add(lblTelefono);
            gbxDatos.Controls.Add(lblID);
            gbxDatos.Controls.Add(txtRazonSocial);
            gbxDatos.Controls.Add(txtID);
            gbxDatos.Controls.Add(lblRazonSocial);
            gbxDatos.Location = new Point(12, 25);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(363, 96);
            gbxDatos.TabIndex = 16;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(251, 59);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 16;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(204, 62);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(41, 15);
            lblMail.TabIndex = 15;
            lblMail.Text = "E-Mail";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(251, 26);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 12;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(192, 29);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Teléfono";
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
            // txtRazonSocial
            // 
            txtRazonSocial.Location = new Point(85, 59);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(101, 23);
            txtRazonSocial.TabIndex = 8;
            // 
            // txtID
            // 
            txtID.Location = new Point(103, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(83, 23);
            txtID.TabIndex = 6;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(6, 62);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(73, 15);
            lblRazonSocial.TabIndex = 7;
            lblRazonSocial.Text = "Razón Social";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(12, 332);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(80, 23);
            btnConsultar.TabIndex = 15;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(348, 332);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(75, 23);
            btnBaja.TabIndex = 14;
            btnBaja.Text = "Eliminar";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(429, 332);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(510, 332);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 12;
            btnAlta.Text = "Agregar";
            btnAlta.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(12, 127);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(573, 199);
            dgvProveedores.TabIndex = 11;
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
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 363);
            Controls.Add(gbxDatos);
            Controls.Add(btnConsultar);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnAlta);
            Controls.Add(dgvProveedores);
            Controls.Add(menuStrip1);
            Name = "frmProveedores";
            Text = "Proveedores";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatos;
        private TextBox txtMail;
        private Label lblMail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblID;
        private TextBox txtRazonSocial;
        private TextBox txtID;
        private Label lblRazonSocial;
        private Button btnConsultar;
        private Button btnBaja;
        private Button btnModificar;
        private Button btnAlta;
        private DataGridView dgvProveedores;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem volverToolStripMenuItem;
    }
}