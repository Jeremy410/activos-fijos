namespace Activos_Fijos
{
    partial class frmMantOpcionesMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantOpcionesMenu));
            this.activosFijosDataSet = new Activos_Fijos.ActivosFijosDataSet();
            this.opcionesXRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opcionesXRolesTableAdapter = new Activos_Fijos.ActivosFijosDataSetTableAdapters.OpcionesXRolesTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager();
            this.opcionesXRolesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionesXRolesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.opcionesMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opcionesMenuTableAdapter = new Activos_Fijos.ActivosFijosDataSetTableAdapters.OpcionesMenuTableAdapter();
            this.opcionesMenuDataGridView = new System.Windows.Forms.DataGridView();
            this.modulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulosTableAdapter = new Activos_Fijos.ActivosFijosDataSetTableAdapters.ModulosTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesXRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesXRolesBindingNavigator)).BeginInit();
            this.opcionesXRolesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesMenuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activosFijosDataSet
            // 
            this.activosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.activosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // opcionesXRolesBindingSource
            // 
            this.opcionesXRolesBindingSource.DataMember = "OpcionesXRoles";
            this.opcionesXRolesBindingSource.DataSource = this.activosFijosDataSet;
            // 
            // opcionesXRolesTableAdapter
            // 
            this.opcionesXRolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivosFijosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalculoDepreciacionTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.MetodoDepreciacionTableAdapter = null;
            this.tableAdapterManager.ModulosTableAdapter = null;
            this.tableAdapterManager.OpcionesMenuTableAdapter = null;
            this.tableAdapterManager.OpcionesXRolesTableAdapter = this.opcionesXRolesTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.TipoPagosTableAdapter = null;
            this.tableAdapterManager.TipoPersonasTableAdapter = null;
            this.tableAdapterManager.TiposActivosTableAdapter = null;
            this.tableAdapterManager.UbicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // opcionesXRolesBindingNavigator
            // 
            this.opcionesXRolesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.opcionesXRolesBindingNavigator.BindingSource = this.opcionesXRolesBindingSource;
            this.opcionesXRolesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.opcionesXRolesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.opcionesXRolesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.opcionesXRolesBindingNavigatorSaveItem});
            this.opcionesXRolesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.opcionesXRolesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.opcionesXRolesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.opcionesXRolesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.opcionesXRolesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.opcionesXRolesBindingNavigator.Name = "opcionesXRolesBindingNavigator";
            this.opcionesXRolesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.opcionesXRolesBindingNavigator.Size = new System.Drawing.Size(768, 25);
            this.opcionesXRolesBindingNavigator.TabIndex = 0;
            this.opcionesXRolesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // opcionesXRolesBindingNavigatorSaveItem
            // 
            this.opcionesXRolesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.opcionesXRolesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesXRolesBindingNavigatorSaveItem.Image")));
            this.opcionesXRolesBindingNavigatorSaveItem.Name = "opcionesXRolesBindingNavigatorSaveItem";
            this.opcionesXRolesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.opcionesXRolesBindingNavigatorSaveItem.Text = "Save Data";
            this.opcionesXRolesBindingNavigatorSaveItem.Click += new System.EventHandler(this.opcionesXRolesBindingNavigatorSaveItem_Click);
            // 
            // opcionesMenuBindingSource
            // 
            this.opcionesMenuBindingSource.DataMember = "OpcionesMenu";
            this.opcionesMenuBindingSource.DataSource = this.activosFijosDataSet;
            // 
            // opcionesMenuTableAdapter
            // 
            this.opcionesMenuTableAdapter.ClearBeforeFill = true;
            // 
            // opcionesMenuDataGridView
            // 
            this.opcionesMenuDataGridView.AutoGenerateColumns = false;
            this.opcionesMenuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.opcionesMenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opcionesMenuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.opcionesMenuDataGridView.DataSource = this.opcionesMenuBindingSource;
            this.opcionesMenuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opcionesMenuDataGridView.Location = new System.Drawing.Point(0, 25);
            this.opcionesMenuDataGridView.Name = "opcionesMenuDataGridView";
            this.opcionesMenuDataGridView.Size = new System.Drawing.Size(768, 398);
            this.opcionesMenuDataGridView.TabIndex = 1;
            // 
            // modulosBindingSource
            // 
            this.modulosBindingSource.DataMember = "Modulos";
            this.modulosBindingSource.DataSource = this.activosFijosDataSet;
            // 
            // modulosTableAdapter
            // 
            this.modulosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdModulo";
            this.dataGridViewTextBoxColumn2.DataSource = this.modulosBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Módulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Formulario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Formulario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmMantOpcionesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 423);
            this.Controls.Add(this.opcionesMenuDataGridView);
            this.Controls.Add(this.opcionesXRolesBindingNavigator);
            this.Name = "frmMantOpcionesMenu";
            this.Text = "Mantenimiento de Opciones de Menu";
            this.Load += new System.EventHandler(this.frmMantOpcionesPorMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesXRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesXRolesBindingNavigator)).EndInit();
            this.opcionesXRolesBindingNavigator.ResumeLayout(false);
            this.opcionesXRolesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opcionesMenuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ActivosFijosDataSet activosFijosDataSet;
        private System.Windows.Forms.BindingSource opcionesXRolesBindingSource;
        private ActivosFijosDataSetTableAdapters.OpcionesXRolesTableAdapter opcionesXRolesTableAdapter;
        private ActivosFijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator opcionesXRolesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton opcionesXRolesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource opcionesMenuBindingSource;
        private ActivosFijosDataSetTableAdapters.OpcionesMenuTableAdapter opcionesMenuTableAdapter;
        private System.Windows.Forms.DataGridView opcionesMenuDataGridView;
        private System.Windows.Forms.BindingSource modulosBindingSource;
        private ActivosFijosDataSetTableAdapters.ModulosTableAdapter modulosTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}