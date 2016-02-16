namespace Activos_Fijos
{
    partial class frmMantCalculoDepreciacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantCalculoDepreciacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.activosFijosDataSet = new Activos_Fijos.ActivosFijosDataSet();
            this.calculoDepreciacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculoDepreciacionTableAdapter = new Activos_Fijos.ActivosFijosDataSetTableAdapters.CalculoDepreciacionTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager();
            this.calculoDepreciacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.calculoDepreciacionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.calculoDepreciacionDataGridView = new System.Windows.Forms.DataGridView();
            this.activosFijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosFijosTableAdapter = new Activos_Fijos.ActivosFijosDataSetTableAdapters.ActivosFijosTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new CalendarColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionBindingNavigator)).BeginInit();
            this.calculoDepreciacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activosFijosDataSet
            // 
            this.activosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.activosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculoDepreciacionBindingSource
            // 
            this.calculoDepreciacionBindingSource.DataMember = "CalculoDepreciacion";
            this.calculoDepreciacionBindingSource.DataSource = this.activosFijosDataSet;
            // 
            // calculoDepreciacionTableAdapter
            // 
            this.calculoDepreciacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivosFijosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalculoDepreciacionTableAdapter = this.calculoDepreciacionTableAdapter;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.MetodoDepreciacionTableAdapter = null;
            this.tableAdapterManager.ModulosTableAdapter = null;
            this.tableAdapterManager.OpcionesMenuTableAdapter = null;
            this.tableAdapterManager.OpcionesXRolesTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.TipoPagosTableAdapter = null;
            this.tableAdapterManager.TipoPersonasTableAdapter = null;
            this.tableAdapterManager.TiposActivosTableAdapter = null;
            this.tableAdapterManager.UbicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // calculoDepreciacionBindingNavigator
            // 
            this.calculoDepreciacionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.calculoDepreciacionBindingNavigator.BindingSource = this.calculoDepreciacionBindingSource;
            this.calculoDepreciacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.calculoDepreciacionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.calculoDepreciacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.calculoDepreciacionBindingNavigatorSaveItem});
            this.calculoDepreciacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.calculoDepreciacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.calculoDepreciacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.calculoDepreciacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.calculoDepreciacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.calculoDepreciacionBindingNavigator.Name = "calculoDepreciacionBindingNavigator";
            this.calculoDepreciacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.calculoDepreciacionBindingNavigator.Size = new System.Drawing.Size(1092, 25);
            this.calculoDepreciacionBindingNavigator.TabIndex = 0;
            this.calculoDepreciacionBindingNavigator.Text = "bindingNavigator1";
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
            // calculoDepreciacionBindingNavigatorSaveItem
            // 
            this.calculoDepreciacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.calculoDepreciacionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("calculoDepreciacionBindingNavigatorSaveItem.Image")));
            this.calculoDepreciacionBindingNavigatorSaveItem.Name = "calculoDepreciacionBindingNavigatorSaveItem";
            this.calculoDepreciacionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.calculoDepreciacionBindingNavigatorSaveItem.Text = "Save Data";
            this.calculoDepreciacionBindingNavigatorSaveItem.Click += new System.EventHandler(this.calculoDepreciacionBindingNavigatorSaveItem_Click);
            // 
            // calculoDepreciacionDataGridView
            // 
            this.calculoDepreciacionDataGridView.AutoGenerateColumns = false;
            this.calculoDepreciacionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calculoDepreciacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculoDepreciacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.calculoDepreciacionDataGridView.DataSource = this.calculoDepreciacionBindingSource;
            this.calculoDepreciacionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculoDepreciacionDataGridView.Location = new System.Drawing.Point(0, 25);
            this.calculoDepreciacionDataGridView.Name = "calculoDepreciacionDataGridView";
            this.calculoDepreciacionDataGridView.Size = new System.Drawing.Size(1092, 446);
            this.calculoDepreciacionDataGridView.TabIndex = 1;
            // 
            // activosFijosBindingSource
            // 
            this.activosFijosBindingSource.DataMember = "ActivosFijos";
            this.activosFijosBindingSource.DataSource = this.activosFijosDataSet;
            // 
            // activosFijosTableAdapter
            // 
            this.activosFijosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdActivoFijo";
            this.dataGridViewTextBoxColumn2.DataSource = this.activosFijosBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdActivoFijo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AñoProceso";
            this.dataGridViewTextBoxColumn3.HeaderText = "Año Proceso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MesProceso";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mes Proceso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaProceso";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Fecha Proceso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MontoDepreciado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Monto Depreciado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DepreciacionAcumulada";
            this.dataGridViewTextBoxColumn7.HeaderText = "Depreciación Acumulada";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CuentaCompra";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cuenta Compra";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CuentaDepreciacion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cuenta Depreciación";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // frmMantCalculoDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 471);
            this.Controls.Add(this.calculoDepreciacionDataGridView);
            this.Controls.Add(this.calculoDepreciacionBindingNavigator);
            this.Name = "frmMantCalculoDepreciacion";
            this.Text = "Mantenimiento de Cálculo de Depreciación";
            this.Load += new System.EventHandler(this.frmMantDepreciacionAcumulada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionBindingNavigator)).EndInit();
            this.calculoDepreciacionBindingNavigator.ResumeLayout(false);
            this.calculoDepreciacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ActivosFijosDataSet activosFijosDataSet;
        private System.Windows.Forms.BindingSource calculoDepreciacionBindingSource;
        private ActivosFijosDataSetTableAdapters.CalculoDepreciacionTableAdapter calculoDepreciacionTableAdapter;
        private ActivosFijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator calculoDepreciacionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton calculoDepreciacionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView calculoDepreciacionDataGridView;
        private System.Windows.Forms.BindingSource activosFijosBindingSource;
        private ActivosFijosDataSetTableAdapters.ActivosFijosTableAdapter activosFijosTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private CalendarColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}