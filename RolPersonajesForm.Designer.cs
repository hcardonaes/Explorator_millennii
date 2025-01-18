namespace Explorator_millennii
{
    partial class RolPersonajesForm
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
            dgvRolPersonajes = new DataGridView();
            cbPersonajes = new ComboBox();
            cbRoles = new ComboBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRolPersonajes).BeginInit();
            SuspendLayout();
            // 
            // dgvRolPersonajes
            // 
            dgvRolPersonajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolPersonajes.Location = new Point(12, 12);
            dgvRolPersonajes.Name = "dgvRolPersonajes";
            dgvRolPersonajes.Size = new Size(345, 150);
            dgvRolPersonajes.TabIndex = 0;
            dgvRolPersonajes.SelectionChanged += dgvRolPersonajes_SelectionChanged;
            // 
            // cbPersonajes
            // 
            cbPersonajes.FormattingEnabled = true;
            cbPersonajes.Location = new Point(134, 168);
            cbPersonajes.Name = "cbPersonajes";
            cbPersonajes.Size = new Size(117, 23);
            cbPersonajes.TabIndex = 1;
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(257, 168);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(100, 23);
            cbRoles.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 207);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(134, 207);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(257, 207);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // RolPersonajesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 264);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbRoles);
            Controls.Add(cbPersonajes);
            Controls.Add(dgvRolPersonajes);
            Name = "RolPersonajesForm";
            Text = "Roles de Personajes";
            Load += RolPersonajesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRolPersonajes).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvRolPersonajes;
        private System.Windows.Forms.ComboBox cbPersonajes;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
