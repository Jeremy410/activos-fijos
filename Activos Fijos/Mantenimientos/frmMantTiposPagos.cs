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
    public partial class frmMantTiposPagos : Form
    {
        public frmMantTiposPagos()
        {
            InitializeComponent();
        }

        private void tipoPagosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoPagosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantTiposPagos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.TipoPagos' table. You can move, or remove it, as needed.
            this.tipoPagosTableAdapter.Fill(this.activosFijosDataSet.TipoPagos);

        }
    }
}
