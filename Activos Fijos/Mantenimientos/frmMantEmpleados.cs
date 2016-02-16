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
    public partial class frmMantEmpleados : Form
    {
        public frmMantEmpleados()
        {
            InitializeComponent();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.TipoPersonas' table. You can move, or remove it, as needed.
            this.tipoPersonasTableAdapter.Fill(this.activosFijosDataSet.TipoPersonas);
            // TODO: This line of code loads data into the 'activosFijosDataSet.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.activosFijosDataSet.Departamentos);
            // TODO: This line of code loads data into the 'activosFijosDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.activosFijosDataSet.Empleados);

        }
    }
}
