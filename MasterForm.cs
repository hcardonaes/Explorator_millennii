using System;
using System.Drawing;
using System.Windows.Forms;
using Explorator_millennii.Models;
using Microsoft.EntityFrameworkCore;

namespace Explorator_millennii
{
    public partial class MasterForm : Form
    {
        private readonly MillenniumContext _context;
        private Panel graphPanel;

        public MasterForm()
        {
            InitializeComponent();
            _context = new MillenniumContext();
            InitializeGraphPanel();
        }

        private void InitializeGraphPanel()
        {
            graphPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            graphPanel.Paint += GraphPanel_Paint;
            Controls.Add(graphPanel);

            // Posicionar los botones en el panel según MasterForm.Designer.cs
            btnCargos.Location = new Point(83, 10);
            btnEventos.Location = new Point(229, 143);
            btnInstituciones.Location = new Point(85, 142);
            btnLazosFamiliares.Location = new Point(454, 77);
            btnLugares.Location = new Point(373, 143);
            btnPersonajes.Location = new Point(162, 77);
            btnProtagonismos_de_eventos.Location = new Point(229, 213);
            btnRelacionesPersonales.Location = new Point(229, 10);
            btnRolPersonajes.Location = new Point(85, 213);
            btnRoles.Location = new Point(375, 213);
            btnTipoParentesco.Location = new Point(308, 77);
            btnTipos_de_cargos.Location = new Point(16, 74);
            btnTipos_relaciones_personales.Location = new Point(375, 10);

            // Cambiar el color de fondo de los botones
            btnCargos.BackColor = Color.Yellow;
            btnEventos.BackColor = Color.Chartreuse;
            btnInstituciones.BackColor = Color.Yellow;
            btnLazosFamiliares.BackColor = Color.LightGreen;
            btnLugares.BackColor = Color.Yellow;
            btnPersonajes.BackColor = Color.Chartreuse;
            btnProtagonismos_de_eventos.BackColor = Color.LightGreen;
            btnRelacionesPersonales.BackColor = Color.LightGreen;
            btnRolPersonajes.BackColor = Color.LightGreen;
            btnRoles.BackColor = Color.LightYellow;
            btnTipoParentesco.BackColor = Color.LightYellow;
            btnTipos_de_cargos.BackColor = Color.LightYellow;
            btnTipos_relaciones_personales.BackColor = Color.LightYellow;

            // Añadir los botones al panel
            graphPanel.Controls.Add(btnCargos);
            graphPanel.Controls.Add(btnEventos);
            graphPanel.Controls.Add(btnInstituciones);
            graphPanel.Controls.Add(btnLazosFamiliares);
            graphPanel.Controls.Add(btnLugares);
            graphPanel.Controls.Add(btnPersonajes);
            graphPanel.Controls.Add(btnProtagonismos_de_eventos);
            graphPanel.Controls.Add(btnRelacionesPersonales);
            graphPanel.Controls.Add(btnRolPersonajes);
            graphPanel.Controls.Add(btnRoles);
            graphPanel.Controls.Add(btnTipoParentesco);
            graphPanel.Controls.Add(btnTipos_de_cargos);
            graphPanel.Controls.Add(btnTipos_relaciones_personales);
        }

        private void GraphPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Font font = new Font("Arial", 8);
            Brush brush = new SolidBrush(Color.Black);

            // Dibujar las relaciones entre los botones
            DrawRelation(g, pen, font, brush, btnCargos, btnPersonajes, "PersonajeId");
            DrawRelation(g, pen, font, brush, btnCargos, btnTipos_de_cargos, "TipoCargoId");
            DrawRelation(g, pen, font, brush, btnCargos, btnInstituciones, "InstitucionId");
            DrawRelation(g, pen, font, brush, btnEventos, btnLugares, "LugarId");
            DrawRelation(g, pen, font, brush, btnEventos, btnProtagonismos_de_eventos, "Protagonismos");
            DrawRelation(g, pen, font, brush, btnEventos, btnRolPersonajes, "RolPersonajes");
            DrawRelation(g, pen, font, brush, btnLazosFamiliares, btnPersonajes, "PersonajeId1/2");
            DrawRelation(g, pen, font, brush, btnLazosFamiliares, btnTipoParentesco, "TipoRelacionId");
            DrawRelation(g, pen, font, brush, btnRelacionesPersonales, btnPersonajes, "PersonajeId1/2");
            DrawRelation(g, pen, font, brush, btnRelacionesPersonales, btnTipos_relaciones_personales, "TipoRelacionId");
            DrawRelation(g, pen, font, brush, btnProtagonismos_de_eventos, btnPersonajes, "PersonajeId");
            DrawRelation(g, pen, font, brush, btnProtagonismos_de_eventos, btnRoles, "RolId");
        }

        private void DrawRelation(Graphics g, Pen pen, Font font, Brush brush, Control btn1, Control btn2, string relation)
        {
            Point p1 = new Point(btn1.Location.X + btn1.Width / 2, btn1.Location.Y + btn1.Height / 2);
            Point p2 = new Point(btn2.Location.X + btn2.Width / 2, btn2.Location.Y + btn2.Height / 2);
            g.DrawLine(pen, p1, p2);

            // Dibujar la etiqueta de la relación
            //Point midPoint = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
            //g.DrawString(relation, font, brush, midPoint);

            // Dibujar la flecha
            DrawArrow(g, pen, p1, p2);
        }

        private void DrawArrow(Graphics g, Pen pen, Point p1, Point p2)
        {
            const int arrowSize = 5;
            double angle = Math.Atan2(p2.Y - p1.Y, p2.X - p1.X);
            Point arrowP1 = new Point((int)(p2.X - arrowSize * Math.Cos(angle - Math.PI / 6)), (int)(p2.Y - arrowSize * Math.Sin(angle - Math.PI / 6)));
            Point arrowP2 = new Point((int)(p2.X - arrowSize * Math.Cos(angle + Math.PI / 6)), (int)(p2.Y - arrowSize * Math.Sin(angle + Math.PI / 6)));
            g.DrawLine(pen, p2, arrowP1);
            g.DrawLine(pen, p2, arrowP2);
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            //VerificarConexion();
        }

        private void VerificarConexion()
        {
            try
            {
                _context.Database.OpenConnection();
                _context.Database.CloseConnection();
                MessageBox.Show("Conexión a la base de datos establecida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Resto del código de los eventos de los botones...

        private void btnCargos_Click(object sender, EventArgs e)
        {
            using (var cargosForm = new CargosForm())
            {
                cargosForm.ShowDialog();
            }
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            using (var eventosForm = new EventosForm())
            {
                eventosForm.ShowDialog();
            }
        }

        private void btnInstituciones_Click(object sender, EventArgs e)
        {
            using (var institucionesForm = new InstitucionesForm())
            {
                institucionesForm.ShowDialog();
            }
        }

        private void btnLazosFamiliares_Click(object sender, EventArgs e)
        {
            using (var lazosFamiliaresForm = new LazosFamiliaresForm())
            {
                lazosFamiliaresForm.ShowDialog();
            }
        }

        private void btnLugares_Click(object sender, EventArgs e)
        {
            using (var lugaresForm = new LugaresForm())
            {
                lugaresForm.ShowDialog();
            }
        }

        private void btnPersonajes_Click(object sender, EventArgs e)
        {
            using (var personajesForm = new PersonajesForm())
            {
                personajesForm.ShowDialog();
            }
        }

        private void btnProtagonismos_de_eventos_Click(object sender, EventArgs e)
        {
            using (var protagonismosDeEventosForm = new ProtagonismosDeEventosForm())
            {
                protagonismosDeEventosForm.ShowDialog();
            }
        }

        private void btnRelacionesPersonales_Click(object sender, EventArgs e)
        {
            using (var relacionesPersonalesForm = new RelacionesPersonalesForm())
            {
                relacionesPersonalesForm.ShowDialog();
            }
        }

        private void btnRolPersonajes_Click(object sender, EventArgs e)
        {
            using (var rolPersonajesForm = new RolPersonajesForm())
            {
                rolPersonajesForm.ShowDialog();
            }
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            using (var rolesForm = new RolesForm())
            {
                rolesForm.ShowDialog();
            }
        }

        private void btnTipoParentesco_Click(object sender, EventArgs e)
        {
            using (var tipoParentescoForm = new TipoParentescoForm())
            {
                tipoParentescoForm.ShowDialog();
            }
        }

        private void btnTipos_de_cargos_Click(object sender, EventArgs e)
        {
            using (var tiposDeCargosForm = new TiposDeCargosForm())
            {
                tiposDeCargosForm.ShowDialog();
            }
        }

        private void btnTipos_relaciones_personales_Click(object sender, EventArgs e)
        {
            using (var tiposRelacionesPersonalesForm = new TipoRelacionesPersonalesForm())
            {
                tiposRelacionesPersonalesForm.ShowDialog();
            }
        }
    }
}

