using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class InstitucionesForm : Form
    {
        private readonly MillenniumContext _context;

        public InstitucionesForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void InstitucionesForm_Load(object sender, EventArgs e)
        {
            LoadInstituciones();
        }

        private void LoadInstituciones()
        {
            var instituciones = _context.Instituciones
                .Select(i => new
                {
                    i.Id,
                    i.Nombre,
                    Descripcion = i.Descripcion ?? "(Sin descripción)"
                })
                .ToList();

            dgvInstituciones.DataSource = instituciones;
        }

        private void dgvInstituciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInstituciones.CurrentRow == null) return;

            var institucionId = (int)dgvInstituciones.CurrentRow.Cells["Id"].Value;
            var institucion = _context.Instituciones.FirstOrDefault(i => i.Id == institucionId);

            if (institucion != null)
            {
                txtNombre.Text = institucion.Nombre;
                txtDescripcion.Text = institucion.Descripcion ?? "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevaInstitucion = new Institucione
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };

            _context.Instituciones.Add(nuevaInstitucion);
            _context.SaveChanges();
            LoadInstituciones();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInstituciones.CurrentRow == null) return;

            var institucionId = (int)dgvInstituciones.CurrentRow.Cells["Id"].Value;
            var institucion = _context.Instituciones.FirstOrDefault(i => i.Id == institucionId);

            if (institucion != null)
            {
                institucion.Nombre = txtNombre.Text;
                institucion.Descripcion = txtDescripcion.Text;

                _context.SaveChanges();
                LoadInstituciones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInstituciones.CurrentRow == null) return;

            var institucionId = (int)dgvInstituciones.CurrentRow.Cells["Id"].Value;
            var institucion = _context.Instituciones.FirstOrDefault(i => i.Id == institucionId);

            if (institucion != null)
            {
                _context.Instituciones.Remove(institucion);
                _context.SaveChanges();
                LoadInstituciones();
            }
        }
    }
}
