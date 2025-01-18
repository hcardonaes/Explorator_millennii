namespace Explorator_millennii
{
    partial class LugaresForm
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
            dgvLugares = new DataGridView();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            txtLatitud = new TextBox();
            txtLongitud = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLugares).BeginInit();
            SuspendLayout();
            // 
            // dgvLugares
            // 
            dgvLugares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLugares.Location = new Point(12, 12);
            dgvLugares.Name = "dgvLugares";
            dgvLugares.Size = new Size(566, 150);
            dgvLugares.TabIndex = 0;
            dgvLugares.SelectionChanged += dgvLugares_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 197);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(658, 64);
            txtDescripcion.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(584, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(584, 75);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(584, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtLatitud
            // 
            txtLatitud.Location = new Point(318, 168);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(100, 23);
            txtLatitud.TabIndex = 6;
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(424, 168);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(100, 23);
            txtLongitud.TabIndex = 7;
            // 
            // LugaresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 284);
            Controls.Add(txtLongitud);
            Controls.Add(txtLatitud);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(dgvLugares);
            Name = "LugaresForm";
            Text = "Lugares";
            Load += LugaresForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLugares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvLugares;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private TextBox txtLatitud;
        private TextBox txtLongitud;
    }
}
