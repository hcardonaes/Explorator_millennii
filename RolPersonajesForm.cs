using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class RolPersonajesForm : Form
    {
        private readonly MillenniumContext _context;

        public RolPersonajesForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void RolPersonajesForm_Load(object sender, EventArgs e)
        {
            LoadRolPersonajes();
            LoadPersonajes();
            LoadRoles();
        }

        private void LoadRolPersonajes()
        {
            var rolPersonajes = _context.RolPersonajes
                .Select(rp => new
                {
                    rp.Id,
                    Personaje = rp.Personaje != null ? $"{rp.Personaje.Nombre} {rp.Personaje.Apellido}" : "(Sin personaje)",
                    Rol = rp.Rol != null ? rp.Rol.Nombre : "(Sin rol)"
                })
                .ToList();

            dgvRolPersonajes.DataSource = rolPersonajes;
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

        private void LoadRoles()
        {
            var roles = _context.Roles
                .Select(r => new { r.Id, r.Nombre })
                .ToList();

            cbRoles.DataSource = roles;
            cbRoles.DisplayMember = "Nombre";
            cbRoles.ValueMember = "Id";
        }

        private void dgvRolPersonajes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRolPersonajes.CurrentRow == null) return;

            var rolPersonajeId = (int)dgvRolPersonajes.CurrentRow.Cells["Id"].Value;
            var rolPersonaje = _context.RolPersonajes.FirstOrDefault(rp => rp.Id == rolPersonajeId);

            if (rolPersonaje != null)
            {
                cbPersonajes.SelectedValue = rolPersonaje.PersonajeId;
                cbRoles.SelectedValue = rolPersonaje.RolId;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoRolPersonaje = new RolPersonaje
            {
                PersonajeId = (int)cbPersonajes.SelectedValue,
                RolId = (int)cbRoles.SelectedValue
            };

            _context.RolPersonajes.Add(nuevoRolPersonaje);
            _context.SaveChanges();
            LoadRolPersonajes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRolPersonajes.CurrentRow == null) return;

            var rolPersonajeId = (int)dgvRolPersonajes.CurrentRow.Cells["Id"].Value;
            var rolPersonaje = _context.RolPersonajes.FirstOrDefault(rp => rp.Id == rolPersonajeId);

            if (rolPersonaje != null)
            {
                rolPersonaje.PersonajeId = (int)cbPersonajes.SelectedValue;
                rolPersonaje.RolId = (int)cbRoles.SelectedValue;

                _context.SaveChanges();
                LoadRolPersonajes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRolPersonajes.CurrentRow == null) return;

            var rolPersonajeId = (int)dgvRolPersonajes.CurrentRow.Cells["Id"].Value;
            var rolPersonaje = _context.RolPersonajes.FirstOrDefault(rp => rp.Id == rolPersonajeId);

            if (rolPersonaje != null)
            {
                _context.RolPersonajes.Remove(rolPersonaje);
                _context.SaveChanges();
                LoadRolPersonajes();
            }
        }
    }
}
