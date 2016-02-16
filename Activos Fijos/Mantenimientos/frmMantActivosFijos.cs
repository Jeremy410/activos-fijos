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
    public partial class frmMantActivosFijos : Form
    {
        public frmMantActivosFijos()
        {
            InitializeComponent();
        }

        private void activosFijosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activosFijosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmActivosFijos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.TiposActivos' table. You can move, or remove it, as needed.
            this.tiposActivosTableAdapter.Fill(this.activosFijosDataSet.TiposActivos);
            // TODO: This line of code loads data into the 'activosFijosDataSet.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.activosFijosDataSet.Departamentos);
            // TODO: This line of code loads data into the 'activosFijosDataSet.Ubicaciones' table. You can move, or remove it, as needed.
            this.ubicacionesTableAdapter.Fill(this.activosFijosDataSet.Ubicaciones);
            // TODO: This line of code loads data into the 'activosFijosDataSet.ActivosFijos' table. You can move, or remove it, as needed.
            this.activosFijosTableAdapter.Fill(this.activosFijosDataSet.ActivosFijos);

        }
    }
}
