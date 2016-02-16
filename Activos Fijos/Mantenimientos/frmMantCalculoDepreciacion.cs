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
    public partial class frmMantCalculoDepreciacion : Form
    {
        public frmMantCalculoDepreciacion()
        {
            InitializeComponent();
        }

        private void calculoDepreciacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.calculoDepreciacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantDepreciacionAcumulada_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.ActivosFijos' table. You can move, or remove it, as needed.
            this.activosFijosTableAdapter.Fill(this.activosFijosDataSet.ActivosFijos);
            // TODO: This line of code loads data into the 'activosFijosDataSet.CalculoDepreciacion' table. You can move, or remove it, as needed.
            this.calculoDepreciacionTableAdapter.Fill(this.activosFijosDataSet.CalculoDepreciacion);

        }
    }
}
