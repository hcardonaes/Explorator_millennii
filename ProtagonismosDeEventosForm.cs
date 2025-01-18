using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class ProtagonismosDeEventosForm : Form
    {
        private readonly MillenniumContext _context;

        public ProtagonismosDeEventosForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void ProtagonismosDeEventosForm_Load(object sender, EventArgs e)
        {
            LoadProtagonismosDeEventos();
            LoadPersonajes();
            LoadEventos();
        }

        private void LoadProtagonismosDeEventos()
        {
            var protagonismos = _context.ProtagonismosDeEventos
                .Select(pe => new
                {
                    pe.Id,
                    Personaje = $"{pe.Personaje.Nombre} {pe.Personaje.Apellido}",
                    Evento = pe.Evento.Nombre,
                    Descripcion = pe.Descripcion ?? "(Sin descripción)"
                })
                .ToList();

            dgvProtagonismosDeEventos.DataSource = protagonismos;
        }

        private void LoadPersonajes()
        {
            var personajes = _context.Personajes
                .Select(p => new { p.Id, NombreCompleto = $"{p.Nombre} {p.Apellido}" })
                .ToList();

            cbPersonajes.DataSource = personajes;
            cbPersonajes.DisplayMember = "NombreCompleto";
            cbPersonajes.ValueMember = "Id";
        }

        private void LoadEventos()
        {
            var eventos = _context.Eventos
                .Select(e => new { e.Id, e.Nombre })
                .ToList();

            cbEventos.DataSource = eventos;
            cbEventos.DisplayMember = "Nombre";
            cbEventos.ValueMember = "Id";
        }

        private void dgvProtagonismosDeEventos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProtagonismosDeEventos.CurrentRow == null) return;

            var protagonismoId = (int)dgvProtagonismosDeEventos.CurrentRow.Cells["Id"].Value;
            var protagonismo = _context.ProtagonismosDeEventos.FirstOrDefault(pe => pe.Id == protagonismoId);

            if (protagonismo != null)
            {
                cbPersonajes.SelectedValue = protagonismo.PersonajeId;
                cbEventos.SelectedValue = protagonismo.EventoId;
                txtDescripcion.Text = protagonismo.Descripcion ?? "";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoProtagonismo = new ProtagonismosDeEvento
            {
                PersonajeId = (int)cbPersonajes.SelectedValue,
                EventoId = (int)cbEventos.SelectedValue,
                Descripcion = txtDescripcion.Text
            };

            _context.ProtagonismosDeEventos.Add(nuevoProtagonismo);
            _context.SaveChanges();
            LoadProtagonismosDeEventos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProtagonismosDeEventos.CurrentRow == null) return;

            var protagonismoId = (int)dgvProtagonismosDeEventos.CurrentRow.Cells["Id"].Value;
            var protagonismo = _context.ProtagonismosDeEventos.FirstOrDefault(pe => pe.Id == protagonismoId);

            if (protagonismo != null)
            {
                protagonismo.PersonajeId = (int)cbPersonajes.SelectedValue;
                protagonismo.EventoId = (int)cbEventos.SelectedValue;
                protagonismo.Descripcion = txtDescripcion.Text;

                _context.SaveChanges();
                LoadProtagonismosDeEventos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProtagonismosDeEventos.CurrentRow == null) return;

            var protagonismoId = (int)dgvProtagonismosDeEventos.CurrentRow.Cells["Id"].Value;
            var protagonismo = _context.ProtagonismosDeEventos.FirstOrDefault(pe => pe.Id == protagonismoId);

            if (protagonismo != null)
            {
                _context.ProtagonismosDeEventos.Remove(protagonismo);
                _context.SaveChanges();
                LoadProtagonismosDeEventos();
            }
        }
    }
}
