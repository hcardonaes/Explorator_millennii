namespace Explorator_millennii
{
    partial class LazosFamiliaresForm
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
            dgvLazosFamiliares = new DataGridView();
            cbPersonaje1 = new ComboBox();
            cbPersonaje2 = new ComboBox();
            cbTipoRelacion = new ComboBox();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLazosFamiliares).BeginInit();
            SuspendLayout();
            // 
            // dgvLazosFamiliares
            // 
            dgvLazosFamiliares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLazosFamiliares.Location = new Point(12, 12);
            dgvLazosFamiliares.Name = "dgvLazosFamiliares";
            dgvLazosFamiliares.Size = new Size(620, 150);
            dgvLazosFamiliares.TabIndex = 0;
            dgvLazosFamiliares.SelectionChanged += dgvLazosFamiliares_SelectionChanged;
            // 
            // cbPersonaje1
            // 
            cbPersonaje1.FormattingEnabled = true;
            cbPersonaje1.Location = new Point(97, 168);
            cbPersonaje1.Name = "cbPersonaje1";
            cbPersonaje1.Size = new Size(94, 23);
            cbPersonaje1.TabIndex = 1;
            // 
            // cbPersonaje2
            // 
            cbPersonaje2.FormattingEnabled = true;
            cbPersonaje2.Location = new Point(206, 168);
            cbPersonaje2.Name = "cbPersonaje2";
            cbPersonaje2.Size = new Size(94, 23);
            cbPersonaje2.TabIndex = 2;
            // 
            // cbTipoRelacion
            // 
            cbTipoRelacion.FormattingEnabled = true;
            cbTipoRelacion.Location = new Point(315, 168);
            cbTipoRelacion.Name = "cbTipoRelacion";
            cbTipoRelacion.Size = new Size(94, 23);
            cbTipoRelacion.TabIndex = 3;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(424, 168);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.PlaceholderText = "YYYY-MM-DD";
            txtFechaInicio.Size = new Size(94, 23);
            txtFechaInicio.TabIndex = 4;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(533, 168);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.PlaceholderText = "YYYY-MM-DD";
            txtFechaFin.Size = new Size(94, 23);
            txtFechaFin.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(638, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(638, 65);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(638, 121);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // LazosFamiliaresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 208);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(cbTipoRelacion);
            Controls.Add(cbPersonaje2);
            Controls.Add(cbPersonaje1);
            Controls.Add(dgvLazosFamiliares);
            Name = "LazosFamiliaresForm";
            Text = "Lazos Familiares";
            Load += LazosFamiliaresForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLazosFamiliares).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvLazosFamiliares;
        private System.Windows.Forms.ComboBox cbPersonaje1;
        private System.Windows.Forms.ComboBox cbPersonaje2;
        private System.Windows.Forms.ComboBox cbTipoRelacion;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
