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
    public partial class frmMantTipoPersona : Form
    {
        public frmMantTipoPersona()
        {
            InitializeComponent();
        }

        private void tipoPersonasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoPersonasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantTipoPersona_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.TipoPersonas' table. You can move, or remove it, as needed.
            this.tipoPersonasTableAdapter.Fill(this.activosFijosDataSet.TipoPersonas);

        }
    }
}
