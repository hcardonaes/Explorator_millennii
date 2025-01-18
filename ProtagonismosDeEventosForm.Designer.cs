namespace Explorator_millennii
{
    partial class ProtagonismosDeEventosForm
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
            dgvProtagonismosDeEventos = new DataGridView();
            cbPersonajes = new ComboBox();
            cbEventos = new ComboBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProtagonismosDeEventos).BeginInit();
            SuspendLayout();
            // 
            // dgvProtagonismosDeEventos
            // 
            dgvProtagonismosDeEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProtagonismosDeEventos.Location = new Point(12, 12);
            dgvProtagonismosDeEventos.Name = "dgvProtagonismosDeEventos";
            dgvProtagonismosDeEventos.Size = new Size(418, 150);
            dgvProtagonismosDeEventos.TabIndex = 0;
            dgvProtagonismosDeEventos.SelectionChanged += dgvProtagonismosDeEventos_SelectionChanged;
            // 
            // cbPersonajes
            // 
            cbPersonajes.FormattingEnabled = true;
            cbPersonajes.Location = new Point(129, 168);
            cbPersonajes.Name = "cbPersonajes";
            cbPersonajes.Size = new Size(127, 23);
            cbPersonajes.TabIndex = 1;
            // 
            // cbEventos
            // 
            cbEventos.FormattingEnabled = true;
            cbEventos.Location = new Point(262, 168);
            cbEventos.Name = "cbEventos";
            cbEventos.Size = new Size(140, 23);
            cbEventos.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 197);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(418, 43);
            txtDescripcion.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 246);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(156, 246);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(269, 246);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // ProtagonismosDeEventosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 306);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(cbEventos);
            Controls.Add(cbPersonajes);
            Controls.Add(dgvProtagonismosDeEventos);
            Name = "ProtagonismosDeEventosForm";
            Text = "Protagonistas  de Eventos";
            Load += ProtagonismosDeEventosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProtagonismosDeEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvProtagonismosDeEventos;
        private System.Windows.Forms.ComboBox cbPersonajes;
        private System.Windows.Forms.ComboBox cbEventos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
