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

        private void frmActivosFijos_Load(object sender, EventArgs e)
        {
            this.ubicacionesTableAdapter.Fill(this.activos_FijosDataSet.Ubicaciones);
            this.activosFijosTableAdapter.Fill(this.activos_FijosDataSet.ActivosFijos);

        }
        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoDepartamentos frmDepartamentos = new frmMantenimientoDepartamentos();
            frmDepartamentos.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoEmpleados frmEmpleados = new frmMantenimientoEmpleados();
            frmEmpleados.Show();
        }

        private void tiposDeActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoTipoActivos frmTipoActicos = new frmMantenimientoTipoActivos();
            frmTipoActicos.Show();
        }

        private void ubicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoUbicaciones frmUbicaciones = new frmMantenimientoUbicaciones();
            frmUbicaciones.Show();
        }

        private void activosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoActivosFijos frmActivosFijos = new frmMantenimientoActivosFijos();
            frmActivosFijos.Show();
        }

        private void calculosDeDespreciacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoCalculoDepreciaciones frmCalculoDepreciaciones = new frmMantenimientoCalculoDepreciaciones();
            frmCalculoDepreciaciones.Show();
        }
    }
}
