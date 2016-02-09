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
    public partial class frmMantenimientoCalculoDepreciaciones : Form
    {
        public frmMantenimientoCalculoDepreciaciones()
        {
            InitializeComponent();
        }

        private void calculoDepreciacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.calculoDepreciacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activos_FijosDataSet);

        }

        private void frmMantenimientoCalculoDepreciaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activos_FijosDataSet.ActivosFijos' table. You can move, or remove it, as needed.
            this.activosFijosTableAdapter.Fill(this.activos_FijosDataSet.ActivosFijos);
            // TODO: This line of code loads data into the 'activos_FijosDataSet.CalculoDepreciaciones' table. You can move, or remove it, as needed.
            this.calculoDepreciacionesTableAdapter.Fill(this.activos_FijosDataSet.CalculoDepreciaciones);

        }
    }
}
