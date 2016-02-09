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
    public partial class frmMantenimientoEmpleados : Form
    {
        public frmMantenimientoEmpleados()
        {
            InitializeComponent();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activos_FijosDataSet);

        }

        private void frmMantenimientoEmpleados_Load(object sender, EventArgs e)
        {
            this.tipoPersonasTableAdapter.Fill(this.activos_FijosDataSet.TipoPersonas);
            this.departamentosTableAdapter.Fill(this.activos_FijosDataSet.Departamentos);
            this.empleadosTableAdapter.Fill(this.activos_FijosDataSet.Empleados);
        }
    }
}
