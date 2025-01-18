using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class LazosFamiliaresForm : Form
    {
        private readonly MillenniumContext _context;

        public LazosFamiliaresForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void LazosFamiliaresForm_Load(object sender, EventArgs e)
        {
            LoadLazosFamiliares();
            LoadPersonajes();
            LoadTiposParentescos();
        }

        private void LoadLazosFamiliares()
        {
            var lazos = _context.LazosFamiliares
                .Select(l => new
                {
                    l.Id,
                    Personaje1 = $"{l.PersonajeId1Navigation.Nombre} {l.PersonajeId1Navigation.Apellido}",
                    Personaje2 = $"{l.PersonajeId2Navigation.Nombre} {l.PersonajeId2Navigation.Apellido}",
                    TipoRelacion = l.TipoRelacion.Nombre,
                    FechaInicio = l.FechaInicio,
                    FechaFin = l.FechaFin
                })
                .ToList();

            dgvLazosFamiliares.DataSource = lazos;
        }

        private void LoadPersonajes()
        {
            var personajes = _context.Personajes
                .Select(p => new { p.Id, NombreCompleto = $"{p.Nombre} {p.Apellido}" })
                .ToList();

            cbPersonaje1.DataSource = personajes;
            cbPersonaje1.DisplayMember = "NombreCompleto";
            cbPersonaje1.ValueMember = "Id";

            cbPersonaje2.DataSource = personajes.ToList();
            cbPersonaje2.DisplayMember = "NombreCompleto";
            cbPersonaje2.ValueMember = "Id";
        }

        private void LoadTiposParentescos()
        {
            var parentescos = _context.TipoParentescos
                .Select(tp => new { tp.Id, tp.Nombre })
                .ToList();

            cbTipoRelacion.DataSource = parentescos;
            cbTipoRelacion.DisplayMember = "Nombre";
            cbTipoRelacion.ValueMember = "Id";
        }

        private void dgvLazosFamiliares_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLazosFamiliares.CurrentRow == null) return;

            var lazoId = (int)dgvLazosFamiliares.CurrentRow.Cells["Id"].Value;
            var lazo = _context.LazosFamiliares.FirstOrDefault(l => l.Id == lazoId);

            if (lazo != null)
            {
                cbPersonaje1.SelectedValue = lazo.PersonajeId1;
                cbPersonaje2.SelectedValue = lazo.PersonajeId2;
                cbTipoRelacion.SelectedValue = lazo.TipoRelacionId;
                txtFechaInicio.Text = lazo.FechaInicio ?? "";
                txtFechaFin.Text = lazo.FechaFin ?? "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoLazo = new LazosFamiliare
            {
                PersonajeId1 = (int)cbPersonaje1.SelectedValue,
                PersonajeId2 = (int)cbPersonaje2.SelectedValue,
                TipoRelacionId = (int)cbTipoRelacion.SelectedValue,
                FechaInicio = txtFechaInicio.Text,
                FechaFin = txtFechaFin.Text
            };

            _context.LazosFamiliares.Add(nuevoLazo);
            _context.SaveChanges();
            LoadLazosFamiliares();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLazosFamiliares.CurrentRow == null) return;

            var lazoId = (int)dgvLazosFamiliares.CurrentRow.Cells["Id"].Value;
            var lazo = _context.LazosFamiliares.FirstOrDefault(l => l.Id == lazoId);

            if (lazo != null)
            {
                lazo.PersonajeId1 = (int)cbPersonaje1.SelectedValue;
                lazo.PersonajeId2 = (int)cbPersonaje2.SelectedValue;
                lazo.TipoRelacionId = (int)cbTipoRelacion.SelectedValue;
                lazo.FechaInicio = txtFechaInicio.Text;
                lazo.FechaFin = txtFechaFin.Text;

                _context.SaveChanges();
                LoadLazosFamiliares();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLazosFamiliares.CurrentRow == null) return;

            var lazoId = (int)dgvLazosFamiliares.CurrentRow.Cells["Id"].Value;
            var lazo = _context.LazosFamiliares.FirstOrDefault(l => l.Id == lazoId);

            if (lazo != null)
            {
                _context.LazosFamiliares.Remove(lazo);
                _context.SaveChanges();
                LoadLazosFamiliares();
            }
        }
    }
}
