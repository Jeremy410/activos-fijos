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
    public partial class frmMantProveedores : Form
    {
        public frmMantProveedores()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.TipoPersonas' table. You can move, or remove it, as needed.
            this.tipoPersonasTableAdapter.Fill(this.activosFijosDataSet.TipoPersonas);
            // TODO: This line of code loads data into the 'activosFijosDataSet.TipoPersonas' table. You can move, or remove it, as needed.
            this.tipoPersonasTableAdapter.Fill(this.activosFijosDataSet.TipoPersonas);
            // TODO: This line of code loads data into the 'activosFijosDataSet.Proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.activosFijosDataSet.Proveedores);

        }
    }
}
