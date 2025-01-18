using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class TipoParentescoForm : Form
    {
        private readonly MillenniumContext _context;

        public TipoParentescoForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void TipoParentescoForm_Load(object sender, EventArgs e)
        {
            LoadTiposParentesco();
        }

        private void LoadTiposParentesco()
        {
            var tipos = _context.TipoParentescos
                .Select(t => new
                {
                    t.Id,
                    t.Nombre,
                    Reciproca = t.Reciproca ?? "(No especificada)"
                })
                .ToList();

            dgvTiposParentesco.DataSource = tipos;
        }

        private void dgvTiposParentesco_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTiposParentesco.CurrentRow == null) return;

            var tipoId = (int)dgvTiposParentesco.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TipoParentescos.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                txtNombre.Text = tipo.Nombre;
                txtReciproca.Text = tipo.Reciproca;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoTipo = new TipoParentesco
            {
                Nombre = txtNombre.Text,
                Reciproca = txtReciproca.Text
            };

            var tipoReciproco = new TipoParentesco
            {
                Nombre = txtReciproca.Text,
                Reciproca = txtNombre.Text
            };

            _context.TipoParentescos.Add(nuevoTipo);
            _context.SaveChanges();
            _context.TipoParentescos.Add(tipoReciproco);
            _context.SaveChanges();
            LoadTiposParentesco();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTiposParentesco.CurrentRow == null) return;

            var tipoId = (int)dgvTiposParentesco.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TipoParentescos.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                tipo.Nombre = txtNombre.Text;
                tipo.Reciproca = txtReciproca.Text;

                _context.SaveChanges();
                LoadTiposParentesco();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiposParentesco.CurrentRow == null) return;

            var tipoId = (int)dgvTiposParentesco.CurrentRow.Cells["Id"].Value;
            var tipo = _context.TipoParentescos.FirstOrDefault(t => t.Id == tipoId);

            if (tipo != null)
            {
                _context.TipoParentescos.Remove(tipo);
                _context.SaveChanges();
                LoadTiposParentesco();
            }
        }
    }
}
