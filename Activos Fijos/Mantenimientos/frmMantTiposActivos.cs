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
    public partial class frmMantTiposActivos : Form
    {
        public frmMantTiposActivos()
        {
            InitializeComponent();
        }

        private void tiposActivosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tiposActivosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantTiposActivos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.TiposActivos' table. You can move, or remove it, as needed.
            this.tiposActivosTableAdapter.Fill(this.activosFijosDataSet.TiposActivos);

        }
    }
}
