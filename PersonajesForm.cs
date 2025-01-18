using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class PersonajesForm : Form
    {
        private readonly MillenniumContext _context;

        public PersonajesForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void PersonajesForm_Load(object sender, EventArgs e)
        {
            LoadPersonajes();
        }

        private void LoadPersonajes()
        {
            var personajes = _context.Personajes
                .AsEnumerable()
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    Apellido = p.Apellido ?? "(Sin apellido)",
                    p.Mote,
                    FechaNacimiento = p.FechaNacimiento.HasValue ? p.FechaNacimiento.Value.ToString("yyyy-MM-dd") : "(Desconocida)",
                    FechaMuerte = p.FechaMuerte.HasValue ? p.FechaMuerte.Value.ToString("yyyy-MM-dd") : "(Desconocida)",
                    p.Importancia
                })
                .OrderBy(p => p.FechaNacimiento) // Ordenación por texto que representa fechas
                .ToList();

            dgvPersonajes.DataSource = personajes;
        }

        private void dgvPersonajes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPersonajes.CurrentRow == null) return;

            var personajeId = (int)dgvPersonajes.CurrentRow.Cells["Id"].Value;
            var personaje = _context.Personajes.FirstOrDefault(p => p.Id == personajeId);

            if (personaje != null)
            {
                txtNombre.Text = personaje.Nombre;
                txtApellido.Text = personaje.Apellido;
                txtMote.Text = personaje.Mote;
                txtFechaNacimiento.Text = personaje.FechaNacimiento?.ToString("yyyy-MM-dd");
                txtFechaMuerte.Text = personaje.FechaMuerte?.ToString("yyyy-MM-dd");
                nudImportancia.Value = personaje.Importancia ?? 0;
                txtBiografia.Text = personaje.Biografia;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidateDate(txtFechaNacimiento.Text) || !ValidateDate(txtFechaMuerte.Text))
            {
                MessageBox.Show("Por favor, introduzca fechas válidas en el formato YYYY-MM-DD.");
                return;
            }

            var nuevoPersonaje = new Personaje
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Mote = txtMote.Text,
                FechaNacimiento = DateOnly.TryParse(txtFechaNacimiento.Text, out var fechaNacimiento) ? fechaNacimiento : null,
                FechaMuerte = DateOnly.TryParse(txtFechaMuerte.Text, out var fechaMuerte) ? fechaMuerte : null,
                Importancia = (int?)nudImportancia.Value,
                Biografia = txtBiografia.Text
            };

            _context.Personajes.Add(nuevoPersonaje);
            _context.SaveChanges();
            LoadPersonajes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPersonajes.CurrentRow == null) return;

            var personajeId = (int)dgvPersonajes.CurrentRow.Cells["Id"].Value;
            var personaje = _context.Personajes.FirstOrDefault(p => p.Id == personajeId);

            if (personaje != null)
            {
                if (!ValidateDate(txtFechaNacimiento.Text) || !ValidateDate(txtFechaMuerte.Text))
                {
                    MessageBox.Show("Por favor, introduzca fechas válidas en el formato YYYY-MM-DD.");
                    return;
                }

                personaje.Nombre = txtNombre.Text;
                personaje.Apellido = txtApellido.Text;
                personaje.Mote = txtMote.Text;
                personaje.FechaNacimiento = DateOnly.TryParse(txtFechaNacimiento.Text, out var fechaNacimiento) ? fechaNacimiento : null;
                personaje.FechaMuerte = DateOnly.TryParse(txtFechaMuerte.Text, out var fechaMuerte) ? fechaMuerte : null;
                personaje.Importancia = (int?)nudImportancia.Value;
                personaje.Biografia = txtBiografia.Text;

                _context.SaveChanges();
                LoadPersonajes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPersonajes.CurrentRow == null) return;

            var personajeId = (int)dgvPersonajes.CurrentRow.Cells["Id"].Value;
            var personaje = _context.Personajes.FirstOrDefault(p => p.Id == personajeId);

            if (personaje != null)
            {
                _context.Personajes.Remove(personaje);
                _context.SaveChanges();
                LoadPersonajes();
            }
        }

        private bool ValidateDate(string date)
        {
            return Regex.IsMatch(date, "^\\d{4}-\\d{2}-\\d{2}$");
        }
    }
}
