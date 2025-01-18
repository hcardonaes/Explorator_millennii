namespace Explorator_millennii
{
    partial class PersonajesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvPersonajes = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMote = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtFechaMuerte = new TextBox();
            nudImportancia = new NumericUpDown();
            txtBiografia = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudImportancia).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonajes
            // 
            dgvPersonajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonajes.Location = new Point(12, 12);
            dgvPersonajes.Name = "dgvPersonajes";
            dgvPersonajes.Size = new Size(740, 150);
            dgvPersonajes.TabIndex = 0;
            dgvPersonajes.SelectionChanged += dgvPersonajes_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(107, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(252, 168);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(107, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtMote
            // 
            txtMote.Location = new Point(359, 168);
            txtMote.Name = "txtMote";
            txtMote.Size = new Size(107, 23);
            txtMote.TabIndex = 3;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(466, 168);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.PlaceholderText = "YYYY-MM-DD";
            txtFechaNacimiento.Size = new Size(107, 23);
            txtFechaNacimiento.TabIndex = 4;
            // 
            // txtFechaMuerte
            // 
            txtFechaMuerte.Location = new Point(573, 168);
            txtFechaMuerte.Name = "txtFechaMuerte";
            txtFechaMuerte.PlaceholderText = "YYYY-MM-DD";
            txtFechaMuerte.Size = new Size(107, 23);
            txtFechaMuerte.TabIndex = 5;
            // 
            // nudImportancia
            // 
            nudImportancia.Location = new Point(680, 168);
            nudImportancia.Name = "nudImportancia";
            nudImportancia.Size = new Size(72, 23);
            nudImportancia.TabIndex = 6;
            // 
            // txtBiografia
            // 
            txtBiografia.Location = new Point(12, 210);
            txtBiografia.Multiline = true;
            txtBiografia.Name = "txtBiografia";
            txtBiografia.Size = new Size(751, 50);
            txtBiografia.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(194, 266);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(338, 266);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(490, 266);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // PersonajesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 318);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtBiografia);
            Controls.Add(nudImportancia);
            Controls.Add(txtFechaMuerte);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtMote);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dgvPersonajes);
            Name = "PersonajesForm";
            Text = "Personajes";
            Load += PersonajesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudImportancia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvPersonajes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMote;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtFechaMuerte;
        private System.Windows.Forms.NumericUpDown nudImportancia;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
