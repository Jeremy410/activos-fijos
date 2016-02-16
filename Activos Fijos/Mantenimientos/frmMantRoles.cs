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
    public partial class frmMantRoles : Form
    {
        public frmMantRoles()
        {
            InitializeComponent();
        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.activosFijosDataSet);

        }

        private void frmMantRoles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activosFijosDataSet.Roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.activosFijosDataSet.Roles);

        }
    }
}
