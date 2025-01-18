namespace Explorator_millennii
{
    partial class CargosForm
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
            dgvCargos = new DataGridView();
            cbTipoDeCargo = new ComboBox();
            cbInstitucion = new ComboBox();
            cbPersonaje = new ComboBox();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCargos).BeginInit();
            SuspendLayout();
            // 
            // dgvCargos
            // 
            dgvCargos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargos.Location = new Point(12, 12);
            dgvCargos.Name = "dgvCargos";
            dgvCargos.Size = new Size(650, 150);
            dgvCargos.TabIndex = 0;
            dgvCargos.SelectionChanged += dgvCargos_SelectionChanged;
            // 
            // cbTipoDeCargo
            // 
            cbTipoDeCargo.FormattingEnabled = true;
            cbTipoDeCargo.Location = new Point(233, 168);
            cbTipoDeCargo.Name = "cbTipoDeCargo";
            cbTipoDeCargo.Size = new Size(127, 23);
            cbTipoDeCargo.TabIndex = 3;
            cbTipoDeCargo.Text = "Tipo cargo";
            // 
            // cbInstitucion
            // 
            cbInstitucion.FormattingEnabled = true;
            cbInstitucion.Location = new Point(360, 168);
            cbInstitucion.Name = "cbInstitucion";
            cbInstitucion.Size = new Size(127, 23);
            cbInstitucion.TabIndex = 4;
            cbInstitucion.Text = "Institucion";
            // 
            // cbPersonaje
            // 
            cbPersonaje.FormattingEnabled = true;
            cbPersonaje.Location = new Point(106, 168);
            cbPersonaje.Name = "cbPersonaje";
            cbPersonaje.Size = new Size(127, 23);
            cbPersonaje.TabIndex = 5;
            cbPersonaje.Text = "Personaje";
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(487, 169);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.PlaceholderText = "YYYY-MM-DD";
            txtFechaInicio.Size = new Size(86, 23);
            txtFechaInicio.TabIndex = 6;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(573, 169);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.PlaceholderText = "YYYY-MM-DD";
            txtFechaFin.Size = new Size(86, 23);
            txtFechaFin.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(70, 198);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(280, 198);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 30);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(474, 198);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // CargosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 242);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(cbPersonaje);
            Controls.Add(cbInstitucion);
            Controls.Add(cbTipoDeCargo);
            Controls.Add(dgvCargos);
            Name = "CargosForm";
            Text = "Cargo de personajes";
            Load += CargosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCargos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvCargos;
       // private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbTipoDeCargo;
        private System.Windows.Forms.ComboBox cbInstitucion;
        private System.Windows.Forms.ComboBox cbPersonaje;
        private System.Windows.Forms.TextBox txtFechaInicio;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        //private Label label2;
        //private Label label3;
        //private Label label4;
        //private Label label5;
        //private Label label6;
    }
}
