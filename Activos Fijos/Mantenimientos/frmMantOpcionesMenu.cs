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
    public partial class frmMantOpcionesMenu : Form
    {
        public frmMantOpcionesMenu()
        {
            InitializeComponent();
        }

        private void opcionesXRolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.opcionesXRolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantOpcionesPorMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.Modulos' table. You can move, or remove it, as needed.
            this.modulosTableAdapter.Fill(this.activosFijosDataSet.Modulos);
            // TODO: This line of code loads data into the 'activosFijosDataSet.OpcionesMenu' table. You can move, or remove it, as needed.
            this.opcionesMenuTableAdapter.Fill(this.activosFijosDataSet.OpcionesMenu);
            // TODO: This line of code loads data into the 'activosFijosDataSet.OpcionesXRoles' table. You can move, or remove it, as needed.
            this.opcionesXRolesTableAdapter.Fill(this.activosFijosDataSet.OpcionesXRoles);

        }
    }
}
