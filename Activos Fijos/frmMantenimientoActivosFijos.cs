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
    public partial class frmMantenimientoActivosFijos : Form
    {
        public frmMantenimientoActivosFijos()
        {
            InitializeComponent();
        }

        private void activosFijosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activosFijosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activos_FijosDataSet);

        }

        private void frmMantenimientoActivosFijos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activos_FijosDataSet.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.activos_FijosDataSet.Departamentos);
            // TODO: This line of code loads data into the 'activos_FijosDataSet.TipoActivos' table. You can move, or remove it, as needed.
            this.tipoActivosTableAdapter.Fill(this.activos_FijosDataSet.TipoActivos);
            // TODO: This line of code loads data into the 'activos_FijosDataSet.Ubicaciones' table. You can move, or remove it, as needed.
            this.ubicacionesTableAdapter.Fill(this.activos_FijosDataSet.Ubicaciones);
            // TODO: This line of code loads data into the 'activos_FijosDataSet.ActivosFijos' table. You can move, or remove it, as needed.
            this.activosFijosTableAdapter.Fill(this.activos_FijosDataSet.ActivosFijos);

        }
    }
}
