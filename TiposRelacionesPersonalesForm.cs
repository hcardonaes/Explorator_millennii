using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class TipoRelacionesPersonalesForm : Form
    {
        private readonly MillenniumContext _context;

        public TipoRelacionesPersonalesForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void TipoRelacionesPersonalesForm_Load(object sender, EventArgs e)
        {
            LoadTiposRelacionesPersonales();
        }

        private void LoadTiposRelacionesPersonales()
        {
            var tipos = _context.TiposRelacionesPersonales
                .Select(t => new
                {
                    t.Id,
                    t.Nombre,
                    Reciproca = t.Reciproca ?? "(No especificada)"
                })
                .ToList();

            dgvTiposRelaciones.DataSource = tipos;
        }

        private void dgvTiposRelaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTiposRelaciones.CurrentRow == null) return;

            var tipoId = (int)dgvTiposRelaciones.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TiposRelacionesPersonales.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                txtNombre.Text = tipo.Nombre;
                txtReciproca.Text = tipo.Reciproca;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoTipo = new TiposRelacionesPersonale
            {
                Nombre = txtNombre.Text,
                Reciproca = txtReciproca.Text
            };
            var tipoReciproco = new TiposRelacionesPersonale
            {
                Nombre = txtReciproca.Text,
                Reciproca = txtNombre.Text
            };

            _context.TiposRelacionesPersonales.Add(nuevoTipo);
            _context.SaveChanges();
            _context.TiposRelacionesPersonales.Add(tipoReciproco);
            _context.SaveChanges();
            LoadTiposRelacionesPersonales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTiposRelaciones.CurrentRow == null) return;

            var tipoId = (int)dgvTiposRelaciones.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TiposRelacionesPersonales.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                tipo.Nombre = txtNombre.Text;
                tipo.Reciproca = txtReciproca.Text;

                _context.SaveChanges();
                LoadTiposRelacionesPersonales();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiposRelaciones.CurrentRow == null) return;

            var tipoId = (int)dgvTiposRelaciones.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TiposRelacionesPersonales.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                _context.TiposRelacionesPersonales.Remove(tipo);
                _context.SaveChanges();
                LoadTiposRelacionesPersonales();
            }
        }
    }
}

