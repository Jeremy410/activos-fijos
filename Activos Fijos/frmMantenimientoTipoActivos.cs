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
    public partial class frmMantenimientoTipoActivos : Form
    {
        public frmMantenimientoTipoActivos()
        {
            InitializeComponent();
        }

        private void tipoActivosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoActivosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activos_FijosDataSet);

        }

        private void frmTipoActivos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activos_FijosDataSet.TipoActivos' table. You can move, or remove it, as needed.
            this.tipoActivosTableAdapter.Fill(this.activos_FijosDataSet.TipoActivos);

        }
    }
}
