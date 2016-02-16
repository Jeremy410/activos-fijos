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
    public partial class frmMantModulos : Form
    {
        public frmMantModulos()
        {
            InitializeComponent();
        }

        private void modulosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.modulosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantModulos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.Modulos' table. You can move, or remove it, as needed.
            this.modulosTableAdapter.Fill(this.activosFijosDataSet.Modulos);

        }
    }
}
