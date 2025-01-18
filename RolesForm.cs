using System;
using System.Linq;
using System.Windows.Forms;
using Explorator_millennii.Models;

namespace Explorator_millennii
{
    public partial class RolesForm : Form
    {
        private readonly MillenniumContext _context;

        public RolesForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            var roles = _context.Roles
                .Select(r => new
                {
                    r.Id,
                    r.Nombre,
                    Descripcion = r.Descripcion ?? "(Sin descripción)"
                })
                .ToList();

            dgvRoles.DataSource = roles;
        }

        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null) return;

            var roleId = (int)dgvRoles.CurrentRow.Cells["Id"].Value;
            var role = _context.Roles.FirstOrDefault(r => r.Id == roleId);

            if (role != null)
            {
                txtNombre.Text = role.Nombre;
                txtDescripcion.Text = role.Descripcion;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var nuevoRole = new Role
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };

            _context.Roles.Add(nuevoRole);
            _context.SaveChanges();
            LoadRoles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null) return;

            var roleId = (int)dgvRoles.CurrentRow.Cells["Id"].Value;
            var role = _context.Roles.FirstOrDefault(r => r.Id == roleId);

            if (role != null)
            {
                role.Nombre = txtNombre.Text;
                role.Descripcion = txtDescripcion.Text;

                _context.SaveChanges();
                LoadRoles();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow == null) return;

            var roleId = (int)dgvRoles.CurrentRow.Cells["Id"].Value;
            var role = _context.Roles.FirstOrDefault(r => r.Id == roleId);

            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
                LoadRoles();
            }
        }
    }
}
