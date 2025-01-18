namespace Explorator_millennii
{
    partial class EventosForm
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
            dgvEventos = new DataGridView();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            cbLugar = new ComboBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // dgvEventos
            // 
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(12, 12);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.Size = new Size(651, 150);
            dgvEventos.TabIndex = 0;
            dgvEventos.SelectionChanged += dgvEventos_SelectionChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 181);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 215);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(654, 80);
            txtDescripcion.TabIndex = 2;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(257, 181);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.PlaceholderText = "YYYY-MM-DD";
            txtFechaInicio.Size = new Size(90, 23);
            txtFechaInicio.TabIndex = 3;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(367, 181);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.PlaceholderText = "YYYY-MM-DD";
            txtFechaFin.Size = new Size(93, 23);
            txtFechaFin.TabIndex = 4;
            // 
            // cbLugar
            // 
            cbLugar.FormattingEnabled = true;
            cbLugar.Location = new Point(466, 181);
            cbLugar.Name = "cbLugar";
            cbLugar.Size = new Size(200, 23);
            cbLugar.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(151, 310);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(257, 310);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(367, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // EventosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 370);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(cbLugar);
            Controls.Add(txtFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(dgvEventos);
            Name = "EventosForm";
            Text = "Eventos";
            Load += EventosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.ComboBox cbLugar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
