using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activos_Fijos.Mantenimientos
{
    public partial class frmMantOpcionesPorRoles : Form
    {
        public frmMantOpcionesPorRoles()
        {
            InitializeComponent();
        }

        private void opcionesXRolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.opcionesXRolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantOpcionesPorRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.OpcionesMenu' table. You can move, or remove it, as needed.
            this.opcionesMenuTableAdapter.Fill(this.activosFijosDataSet.OpcionesMenu);
            // TODO: This line of code loads data into the 'activosFijosDataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.activosFijosDataSet.Roles);
            // TODO: This line of code loads data into the 'activosFijosDataSet.OpcionesXRoles' table. You can move, or remove it, as needed.
            this.opcionesXRolesTableAdapter.Fill(this.activosFijosDataSet.OpcionesXRoles);

        }
    }
}
