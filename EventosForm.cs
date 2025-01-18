using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class EventosForm : Form
    {
        private readonly MillenniumContext _context;

        public EventosForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void EventosForm_Load(object sender, EventArgs e)
        {
            LoadEventos();
            LoadLugares();
        }

        private void LoadEventos()
        {
            var eventos = _context.Eventos
                .Select(e => new
                {
                    e.Id,
                    e.Nombre,
                    e.Descripcion,
                    FechaInicio = e.FechaInicio ?? "(Desconocida)",
                    FechaFin = e.FechaFin ?? "(Desconocida)",
                    Lugar = e.Lugar != null ? e.Lugar.Nombre : "(Sin lugar)"
                })
                .OrderBy(e => e.FechaInicio) // Ordenación por texto que representa fechas
                .ToList();

            dgvEventos.DataSource = eventos;
        }

        private void LoadLugares()
        {
            var lugares = _context.Lugares
                .Select(l => new { l.Id, l.Nombre })
                .ToList();

            cbLugar.DataSource = lugares;
            cbLugar.DisplayMember = "Nombre";
            cbLugar.ValueMember = "Id";
        }

        private void dgvEventos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEventos.CurrentRow == null) return;

            var eventoId = (int)dgvEventos.CurrentRow.Cells["Id"].Value;
            var evento = _context.Eventos.FirstOrDefault(e => e.Id == eventoId);

            if (evento != null)
            {
                txtNombre.Text = evento.Nombre;
                txtDescripcion.Text = evento.Descripcion;
                txtFechaInicio.Text = evento.FechaInicio;
                txtFechaFin.Text = evento.FechaFin;
                cbLugar.SelectedValue = evento.LugarId;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidateDate(txtFechaInicio.Text) || !ValidateDate(txtFechaFin.Text))
            {
                MessageBox.Show("Por favor, introduzca fechas válidas en el formato YYYY-MM-DD.");
                return;
            }

            var nuevoEvento = new Evento
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                FechaInicio = txtFechaInicio.Text,
                FechaFin = txtFechaFin.Text,
                LugarId = (int?)cbLugar.SelectedValue
            };

            _context.Eventos.Add(nuevoEvento);
            _context.SaveChanges();
            LoadEventos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.CurrentRow == null) return;

            var eventoId = (int)dgvEventos.CurrentRow.Cells["Id"].Value;
            var evento = _context.Eventos.FirstOrDefault(e => e.Id == eventoId);

            if (evento != null)
            {
                if (!ValidateDate(txtFechaInicio.Text) || !ValidateDate(txtFechaFin.Text))
                {
                    MessageBox.Show("Por favor, introduzca fechas válidas en el formato YYYY-MM-DD.");
                    return;
                }

                evento.Nombre = txtNombre.Text;
                evento.Descripcion = txtDescripcion.Text;
                evento.FechaInicio = txtFechaInicio.Text;
                evento.FechaFin = txtFechaFin.Text;
                evento.LugarId = (int?)cbLugar.SelectedValue;

                _context.SaveChanges();
                LoadEventos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.CurrentRow == null) return;

            var eventoId = (int)dgvEventos.CurrentRow.Cells["Id"].Value;
            var evento = _context.Eventos.FirstOrDefault(e => e.Id == eventoId);

            if (evento != null)
            {
                _context.Eventos.Remove(evento);
                _context.SaveChanges();
                LoadEventos();
            }
        }

        private bool ValidateDate(string date)
        {
            return Regex.IsMatch(date, "^\\d{4}-\\d{2}-\\d{2}$");
        }
    }
}
