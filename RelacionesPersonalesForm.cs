using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class RelacionesPersonalesForm : Form
    {
        private readonly MillenniumContext _context;

        public RelacionesPersonalesForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void RelacionesPersonalesForm_Load(object sender, EventArgs e)
        {
            LoadRelacionesPersonales();
            LoadPersonajes();
            LoadTiposRelaciones();
        }

        private void LoadRelacionesPersonales()
        {
            var relaciones = _context.RelacionesPersonales
                .Select(r => new
                {
                    r.Id,
                    Personaje1 = $"{r.PersonajeId1Navigation.Nombre} {r.PersonajeId1Navigation.Apellido}",
                    Personaje2 = $"{r.PersonajeId2Navigation.Nombre} {r.PersonajeId2Navigation.Apellido}",
                    TipoRelacion = r.TipoRelacion.Nombre,
                    FechaInicio = r.FechaInicio,
                    FechaFin = r.FechaFin
                })
                .ToList();

            dgvRelacionesPersonales.DataSource = relaciones;
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

        private void LoadTiposRelaciones()
        {
            var tiposRelaciones = _context.TiposRelacionesPersonales
                .Select(tr => new { tr.Id, tr.Nombre })
                .ToList();

            cbTipoRelacion.DataSource = tiposRelaciones;
            cbTipoRelacion.DisplayMember = "Nombre";
            cbTipoRelacion.ValueMember = "Id";
        }

        private void dgvRelacionesPersonales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRelacionesPersonales.CurrentRow == null) return;

            var relacionId = (int)dgvRelacionesPersonales.CurrentRow.Cells["Id"].Value;
            var relacion = _context.RelacionesPersonales.FirstOrDefault(r => r.Id == relacionId);

            if (relacion != null)
            {
                cbPersonaje1.SelectedValue = relacion.PersonajeId1;
                cbPersonaje2.SelectedValue = relacion.PersonajeId2;
                cbTipoRelacion.SelectedValue = relacion.TipoRelacionId;
                txtFechaInicio.Text = relacion.FechaInicio ?? "";
                txtFechaFin.Text = relacion.FechaFin ?? "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevaRelacion = new RelacionesPersonale
            {
                PersonajeId1 = (int)cbPersonaje1.SelectedValue,
                PersonajeId2 = (int)cbPersonaje2.SelectedValue,
                TipoRelacionId = (int)cbTipoRelacion.SelectedValue,
                FechaInicio = txtFechaInicio.Text,
                FechaFin = txtFechaFin.Text
            };

            _context.RelacionesPersonales.Add(nuevaRelacion);
            _context.SaveChanges();
            LoadRelacionesPersonales();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRelacionesPersonales.CurrentRow == null) return;

            var relacionId = (int)dgvRelacionesPersonales.CurrentRow.Cells["Id"].Value;
            var relacion = _context.RelacionesPersonales.FirstOrDefault(r => r.Id == relacionId);

            if (relacion != null)
            {
                relacion.PersonajeId1 = (int)cbPersonaje1.SelectedValue;
                relacion.PersonajeId2 = (int)cbPersonaje2.SelectedValue;
                relacion.TipoRelacionId = (int)cbTipoRelacion.SelectedValue;
                relacion.FechaInicio = txtFechaInicio.Text;
                relacion.FechaFin = txtFechaFin.Text;

                _context.SaveChanges();
                LoadRelacionesPersonales();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRelacionesPersonales.CurrentRow == null) return;

            var relacionId = (int)dgvRelacionesPersonales.CurrentRow.Cells["Id"].Value;
            var relacion = _context.RelacionesPersonales.FirstOrDefault(r => r.Id == relacionId);

            if (relacion != null)
            {
                _context.RelacionesPersonales.Remove(relacion);
                _context.SaveChanges();
                LoadRelacionesPersonales();
            }
        }
    }
}
