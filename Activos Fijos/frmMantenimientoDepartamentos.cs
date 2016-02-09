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
    public partial class frmMantenimientoDepartamentos : Form
    {
        public frmMantenimientoDepartamentos()
        {
            InitializeComponent();
        }

        private void departamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activos_FijosDataSet);

        }

        private void frmMantenimientoDepartamentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activos_FijosDataSet.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.activos_FijosDataSet.Departamentos);

        }
    }
}
