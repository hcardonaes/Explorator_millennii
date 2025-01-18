namespace Explorator_millennii
{
    partial class TipoParentescoForm
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
            dgvTiposParentesco = new DataGridView();
            txtNombre = new TextBox();
            txtReciproca = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTiposParentesco).BeginInit();
            SuspendLayout();
            // 
            // dgvTiposParentesco
            // 
            dgvTiposParentesco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTiposParentesco.Location = new Point(12, 12);
            dgvTiposParentesco.Name = "dgvTiposParentesco";
            dgvTiposParentesco.Size = new Size(371, 150);
            dgvTiposParentesco.TabIndex = 0;
            dgvTiposParentesco.SelectionChanged += dgvTiposParentesco_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 168);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(98, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtReciproca
            // 
            txtReciproca.Location = new Point(272, 168);
            txtReciproca.Name = "txtReciproca";
            txtReciproca.Size = new Size(98, 23);
            txtReciproca.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(34, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(153, 197);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(270, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // TipoParentescoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 236);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtReciproca);
            Controls.Add(txtNombre);
            Controls.Add(dgvTiposParentesco);
            Name = "TipoParentescoForm";
            Text = "Tipos de Parentesco";
            Load += TipoParentescoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTiposParentesco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvTiposParentesco;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtReciproca;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
