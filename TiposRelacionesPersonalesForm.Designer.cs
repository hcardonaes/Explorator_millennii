namespace Explorator_millennii
{
    partial class TipoRelacionesPersonalesForm
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
            dgvTiposRelaciones = new DataGridView();
            txtNombre = new TextBox();
            txtReciproca = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTiposRelaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvTiposRelaciones
            // 
            dgvTiposRelaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposRelaciones.Location = new Point(12, 12);
            dgvTiposRelaciones.Name = "dgvTiposRelaciones";
            dgvTiposRelaciones.Size = new Size(352, 150);
            dgvTiposRelaciones.TabIndex = 0;
            dgvTiposRelaciones.SelectionChanged += dgvTiposRelaciones_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(264, 170);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtReciproca
            // 
            txtReciproca.Location = new Point(158, 170);
            txtReciproca.Name = "txtReciproca";
            txtReciproca.Size = new Size(100, 23);
            txtReciproca.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(138, 199);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(264, 199);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // TipoRelacionesPersonalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 247);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtReciproca);
            Controls.Add(txtNombre);
            Controls.Add(dgvTiposRelaciones);
            Name = "TipoRelacionesPersonalesForm";
            Text = "Tipos de Relaciones Personales";
            Load += TipoRelacionesPersonalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTiposRelaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvTiposRelaciones;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtReciproca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
