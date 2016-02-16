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
    public partial class frmMantMetodoDepreciacion : Form
    {
        public frmMantMetodoDepreciacion()
        {
            InitializeComponent();
        }

        private void metodoDepreciacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.metodoDepreciacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantMetodoDepreciacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.MetodoDepreciacion' table. You can move, or remove it, as needed.
            this.metodoDepreciacionTableAdapter.Fill(this.activosFijosDataSet.MetodoDepreciacion);

        }
    }
}
