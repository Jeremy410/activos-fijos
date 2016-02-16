using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activos_Fijos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDepartamentos frmDepartamentos = new frmMantDepartamentos();
            frmDepartamentos.Show();
        }

        private void ubicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantUbicaciones frmUbicaciones = new frmMantUbicaciones();
            frmUbicaciones.Show();
        }

        private void tiposDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantTiposActivos frmMantTiposActivos = new frmMantTiposActivos();
            frmMantTiposActivos.Show();
        }

        private void activosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantActivosFijos frmMantActivosFijos = new frmMantActivosFijos();
            frmMantActivosFijos.Show();
        }

        private void calculoDeDepreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantCalculoDepreciacion frmMantCalculoDepreciacion = new frmMantCalculoDepreciacion();
            frmMantCalculoDepreciacion.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantEmpleados frmMantEmpleados = new frmMantEmpleados();
            frmMantEmpleados.Show();
        }

        private void tipoDePersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantTipoPersona frmMantTipoPersona = new frmMantTipoPersona();
            frmMantTipoPersona.Show();
        }

        private void métodoDeDepreciaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantMetodoDepreciacion frmMantMetodoDepreciacion = new frmMantMetodoDepreciacion();
            frmMantMetodoDepreciacion.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantProveedores frmMantProveedores = new frmMantProveedores();
            frmMantProveedores.Show();
        }

        private void tiposDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantTiposPagos frmMantTiposPagos = new frmMantTiposPagos();
            frmMantTiposPagos.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantRoles frmMantRoles = new frmMantRoles();
            frmMantRoles.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantUsuarios frmMantUsuarios = new frmMantUsuarios();
            frmMantUsuarios.Show();
        }

        private void opcionesPorMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantOpcionesMenu frmMantOpcionesMenu = new frmMantOpcionesMenu();
            frmMantOpcionesMenu.Show();
        }

        private void módulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantModulos frmMantModulos = new frmMantModulos();
            frmMantModulos.Show();
        }

        private void opcionesPorRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantOpcionesMenu frmMantOpcionesMenu = new frmMantOpcionesMenu();
            frmMantOpcionesMenu.Show();
        }
    }
}
