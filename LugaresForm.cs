using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class LugaresForm : Form
    {
        private readonly MillenniumContext _context;

        public LugaresForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void LugaresForm_Load(object sender, EventArgs e)
        {
            LoadLugares();
        }

        private void LoadLugares()
        {
            var lugares = _context.Lugares
                .Select(l => new
                {
                    l.Id,
                    l.Nombre,
                    l.Latitud,
                    l.Longitud,
                    Descripcion = l.Descripcion ?? "(Sin descripción)"
                })
                .ToList();

            dgvLugares.DataSource = lugares;
        }

        private void dgvLugares_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLugares.CurrentRow == null) return;

            var lugarId = (int)dgvLugares.CurrentRow.Cells["Id"].Value;
            var lugar = _context.Lugares.FirstOrDefault(l => l.Id == lugarId);

            if (lugar != null)
            {
                txtNombre.Text = lugar.Nombre;
                txtLatitud.Text = lugar.Latitud?.ToString() ?? "";
                txtLongitud.Text = lugar.Longitud?.ToString() ?? "";
                txtDescripcion.Text = lugar.Descripcion ?? "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoLugar = new Lugare
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };

            _context.Lugares.Add(nuevoLugar);
            _context.SaveChanges();
            LoadLugares();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLugares.CurrentRow == null) return;

            var lugarId = (int)dgvLugares.CurrentRow.Cells["Id"].Value;
            var lugar = _context.Lugares.FirstOrDefault(l => l.Id == lugarId);

            if (lugar != null)
            {
                lugar.Nombre = txtNombre.Text;
                lugar.Descripcion = txtDescripcion.Text;

                _context.SaveChanges();
                LoadLugares();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLugares.CurrentRow == null) return;

            var lugarId = (int)dgvLugares.CurrentRow.Cells["Id"].Value;
            var lugar = _context.Lugares.FirstOrDefault(l => l.Id == lugarId);

            if (lugar != null)
            {
                _context.Lugares.Remove(lugar);
                _context.SaveChanges();
                LoadLugares();
            }
        }
    }
}
