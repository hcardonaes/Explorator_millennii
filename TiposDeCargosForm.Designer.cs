namespace Explorator_millennii
{
    partial class TiposDeCargosForm
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
            dgvTiposDeCargos = new DataGridView();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTiposDeCargos).BeginInit();
            SuspendLayout();
            // 
            // dgvTiposDeCargos
            // 
            dgvTiposDeCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposDeCargos.Location = new Point(12, 12);
            dgvTiposDeCargos.Name = "dgvTiposDeCargos";
            dgvTiposDeCargos.Size = new Size(240, 150);
            dgvTiposDeCargos.TabIndex = 0;
            dgvTiposDeCargos.SelectionChanged += dgvTiposDeCargos_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(124, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(15, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(59, 30);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(104, 197);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(59, 30);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(193, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(59, 30);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // TiposDeCargosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 238);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(dgvTiposDeCargos);
            Name = "TiposDeCargosForm";
            Text = "Tipos de Cargos";
            Load += TiposDeCargosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTiposDeCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvTiposDeCargos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
