namespace PryIE2Fuzzi
{
    partial class frmClientes
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            dgvClientes = new DataGridView();
            btnAlta = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            btnConsultar = new Button();
            lblID = new Label();
            txtID = new TextBox();
            txtNombre = new TextBox();
            lblNombre = new Label();
            gbxDatos = new GroupBox();
            txtMail = new TextBox();
            lblMail = new Label();
            lblApellido = new Label();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            lblTelefono = new Label();
            menuStrip1 = new MenuStrip();
            volverToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbxDatos.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 129);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(573, 199);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(510, 334);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
            btnAlta.TabIndex = 1;
            btnAlta.Text = "Agregar";
            btnAlta.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(429, 334);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(348, 334);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(75, 23);
            btnBaja.TabIndex = 3;
            btnBaja.Text = "Eliminar";
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(12, 334);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(80, 23);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
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
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(63, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(101, 23);
            txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 62);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(txtMail);
            gbxDatos.Controls.Add(lblMail);
            gbxDatos.Controls.Add(lblApellido);
            gbxDatos.Controls.Add(txtTelefono);
            gbxDatos.Controls.Add(txtApellido);
            gbxDatos.Controls.Add(lblTelefono);
            gbxDatos.Controls.Add(lblID);
            gbxDatos.Controls.Add(txtNombre);
            gbxDatos.Controls.Add(txtID);
            gbxDatos.Controls.Add(lblNombre);
            gbxDatos.Location = new Point(12, 27);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(519, 96);
            gbxDatos.TabIndex = 9;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(399, 59);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 16;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(352, 62);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(41, 15);
            lblMail.TabIndex = 15;
            lblMail.Text = "E-Mail";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(179, 29);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(237, 59);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(237, 26);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 10;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(177, 62);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Teléfono";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { volverToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(597, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            volverToolStripMenuItem.Size = new Size(51, 20);
            volverToolStripMenuItem.Text = "Volver";
            volverToolStripMenuItem.Click += volverToolStripMenuItem_Click;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 365);
            Controls.Add(gbxDatos);
            Controls.Add(btnConsultar);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnAlta);
            Controls.Add(dgvClientes);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private DataGridView dgvClientes;
        private Button btnAlta;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnConsultar;
        private Label lblID;
        private TextBox txtID;
        private TextBox txtNombre;
        private Label lblNombre;
        private GroupBox gbxDatos;
        private TextBox txtMail;
        private Label lblMail;
        private Label lblApellido;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private Label lblTelefono;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem volverToolStripMenuItem;
    }
}