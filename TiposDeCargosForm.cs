using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class TiposDeCargosForm : Form
    {
        private readonly MillenniumContext _context;

        public TiposDeCargosForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void TiposDeCargosForm_Load(object sender, EventArgs e)
        {
            LoadTiposDeCargos();
        }

        private void LoadTiposDeCargos()
        {
            var tipos = _context.TiposDeCargos
                .Select(t => new
                {
                    t.Id,
                    t.Nombre
                })
                .ToList();

            dgvTiposDeCargos.DataSource = tipos;
        }

        private void dgvTiposDeCargos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTiposDeCargos.CurrentRow == null) return;

            var tipoId = (int)dgvTiposDeCargos.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TiposDeCargos.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                txtNombre.Text = tipo.Nombre;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoTipo = new TiposDeCargo
            {
                Nombre = txtNombre.Text
            };

            _context.TiposDeCargos.Add(nuevoTipo);
            _context.SaveChanges();
            LoadTiposDeCargos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTiposDeCargos.CurrentRow == null) return;

            var tipoId = (int)dgvTiposDeCargos.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TiposDeCargos.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                tipo.Nombre = txtNombre.Text;

                _context.SaveChanges();
                LoadTiposDeCargos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiposDeCargos.CurrentRow == null) return;

            var tipoId = (int)dgvTiposDeCargos.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TiposDeCargos.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                _context.TiposDeCargos.Remove(tipo);
                _context.SaveChanges();
                LoadTiposDeCargos();
            }
        }
    }
}

