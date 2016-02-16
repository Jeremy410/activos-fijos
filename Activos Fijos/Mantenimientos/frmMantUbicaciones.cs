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
    public partial class frmMantUbicaciones : Form
    {
        public frmMantUbicaciones()
        {
            InitializeComponent();
        }

        private void ubicacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ubicacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmUbicaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.Ubicaciones' table. You can move, or remove it, as needed.
            this.ubicacionesTableAdapter.Fill(this.activosFijosDataSet.Ubicaciones);

        }
    }
}
