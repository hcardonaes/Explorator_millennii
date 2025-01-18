using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class CargosForm : Form
    {
        private readonly MillenniumContext _context;

        public CargosForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void CargosForm_Load(object sender, EventArgs e)
        {
            LoadCargos();
            LoadInstituciones();
            LoadPersonajes();
            LoadTiposDeCargos();
        }

        private void LoadCargos()
        {
            var cargos = _context.Cargos
                .Select(c => new
                {
                    c.Id,
                    Personaje = $"{c.Personaje.Nombre} {c.Personaje.Apellido}",
                    TipoCargo = c.TipoCargo.Nombre,
                    Institucion = c.Institucion.Nombre,
                    FechaInicio = c.FechaInicio.HasValue ? c.FechaInicio.Value.ToString("yyyy-MM-dd") : "",
                    FechaFin = c.FechaFin.HasValue ? c.FechaFin.Value.ToString("yyyy-MM-dd") : ""
                })
                .ToList();

            dgvCargos.DataSource = cargos;
        }

        private void LoadTiposDeCargos()
        {
            var tiposDeCargos = _context.TiposDeCargos
                .Select(tc => new { tc.Id, tc.Nombre })
                .ToList();

            cbTipoDeCargo.DataSource = tiposDeCargos;
            cbTipoDeCargo.DisplayMember = "Nombre";
            cbTipoDeCargo.ValueMember = "Id";
        }

        private void LoadInstituciones()
        {
            var instituciones = _context.Instituciones
                .Select(i => new { i.Id, i.Nombre })
                .ToList();

            cbInstitucion.DataSource = instituciones;
            cbInstitucion.DisplayMember = "Nombre";
            cbInstitucion.ValueMember = "Id";
        }

        private void LoadPersonajes()
        {
            var personajes = _context.Personajes
                .Select(p => new { p.Id, NombreCompleto = $"{p.Nombre} {p.Apellido}" })
                .ToList();

            cbPersonaje.DataSource = personajes;
            cbPersonaje.DisplayMember = "NombreCompleto";
            cbPersonaje.ValueMember = "Id";
        }

        private void dgvCargos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCargos.CurrentRow == null) return;

            var cargoId = (int)dgvCargos.CurrentRow.Cells["Id"].Value;
            var cargo = _context.Cargos.FirstOrDefault(c => c.Id == cargoId);

            if (cargo != null)
            {
                cbPersonaje.SelectedValue = cargo.PersonajeId;
                cbTipoDeCargo.SelectedValue = cargo.TipoCargoId;
                cbInstitucion.SelectedValue = cargo.InstitucionId;
                txtFechaInicio.Text = cargo.FechaInicio.HasValue ? cargo.FechaInicio.Value.ToString("yyyy-MM-dd") : "";
                txtFechaFin.Text = cargo.FechaFin.HasValue ? cargo.FechaFin.Value.ToString("yyyy-MM-dd") : "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoCargo = new Cargo
            {
                PersonajeId = (int)cbPersonaje.SelectedValue,
                TipoCargoId = (int)cbTipoDeCargo.SelectedValue,
                InstitucionId = (int)cbInstitucion.SelectedValue,
                FechaInicio = string.IsNullOrWhiteSpace(txtFechaInicio.Text) ? null : DateOnly.Parse(txtFechaInicio.Text),
                FechaFin = string.IsNullOrWhiteSpace(txtFechaFin.Text) ? null : DateOnly.Parse(txtFechaFin.Text)
            };

            _context.Cargos.Add(nuevoCargo);
            _context.SaveChanges();
            LoadCargos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.CurrentRow == null) return;

            var cargoId = (int)dgvCargos.CurrentRow.Cells["Id"].Value;
            var cargo = _context.Cargos.FirstOrDefault(c => c.Id == cargoId);

            if (cargo != null)
            {
                cargo.PersonajeId = (int)cbPersonaje.SelectedValue;
                cargo.TipoCargoId = (int)cbTipoDeCargo.SelectedValue;
                cargo.InstitucionId = (int)cbInstitucion.SelectedValue;
                cargo.FechaInicio = string.IsNullOrWhiteSpace(txtFechaInicio.Text) ? null : DateOnly.Parse(txtFechaInicio.Text);
                cargo.FechaFin = string.IsNullOrWhiteSpace(txtFechaFin.Text) ? null : DateOnly.Parse(txtFechaFin.Text);

                _context.SaveChanges();
                LoadCargos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.CurrentRow == null) return;

            var cargoId = (int)dgvCargos.CurrentRow.Cells["Id"].Value;
            var cargo = _context.Cargos.FirstOrDefault(c => c.Id == cargoId);

            if (cargo != null)
            {
                _context.Cargos.Remove(cargo);
                _context.SaveChanges();
                LoadCargos();
            }
        }
    }
}
