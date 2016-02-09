namespace Activos_Fijos
{
    partial class frmMantenimientoCalculoDepreciaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoCalculoDepreciaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.activos_FijosDataSet = new Activos_Fijos.Activos_FijosDataSet();
            this.calculoDepreciacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculoDepreciacionesTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.CalculoDepreciacionesTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.Activos_FijosDataSetTableAdapters.TableAdapterManager();
            this.calculoDepreciacionesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.calculoDepreciacionesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.calculoDepreciacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.activosFijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosFijosTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.ActivosFijosTableAdapter();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new CalendarColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activos_FijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionesBindingNavigator)).BeginInit();
            this.calculoDepreciacionesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activos_FijosDataSet
            // 
            this.activos_FijosDataSet.DataSetName = "Activos_FijosDataSet";
            this.activos_FijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculoDepreciacionesBindingSource
            // 
            this.calculoDepreciacionesBindingSource.DataMember = "CalculoDepreciaciones";
            this.calculoDepreciacionesBindingSource.DataSource = this.activos_FijosDataSet;
            // 
            // calculoDepreciacionesTableAdapter
            // 
            this.calculoDepreciacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivosFijosTableAdapter = this.activosFijosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalculoDepreciacionesTableAdapter = this.calculoDepreciacionesTableAdapter;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.TipoActivosTableAdapter = null;
            this.tableAdapterManager.TipoPersonasTableAdapter = null;
            this.tableAdapterManager.UbicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Activos_Fijos.Activos_FijosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calculoDepreciacionesBindingNavigator
            // 
            this.calculoDepreciacionesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.calculoDepreciacionesBindingNavigator.BindingSource = this.calculoDepreciacionesBindingSource;
            this.calculoDepreciacionesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.calculoDepreciacionesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.calculoDepreciacionesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.calculoDepreciacionesBindingNavigatorSaveItem});
            this.calculoDepreciacionesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.calculoDepreciacionesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.calculoDepreciacionesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.calculoDepreciacionesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.calculoDepreciacionesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.calculoDepreciacionesBindingNavigator.Name = "calculoDepreciacionesBindingNavigator";
            this.calculoDepreciacionesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.calculoDepreciacionesBindingNavigator.Size = new System.Drawing.Size(963, 25);
            this.calculoDepreciacionesBindingNavigator.TabIndex = 0;
            this.calculoDepreciacionesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // calculoDepreciacionesBindingNavigatorSaveItem
            // 
            this.calculoDepreciacionesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.calculoDepreciacionesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("calculoDepreciacionesBindingNavigatorSaveItem.Image")));
            this.calculoDepreciacionesBindingNavigatorSaveItem.Name = "calculoDepreciacionesBindingNavigatorSaveItem";
            this.calculoDepreciacionesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.calculoDepreciacionesBindingNavigatorSaveItem.Text = "Save Data";
            this.calculoDepreciacionesBindingNavigatorSaveItem.Click += new System.EventHandler(this.calculoDepreciacionesBindingNavigatorSaveItem_Click);
            // 
            // calculoDepreciacionesDataGridView
            // 
            this.calculoDepreciacionesDataGridView.AutoGenerateColumns = false;
            this.calculoDepreciacionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.calculoDepreciacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculoDepreciacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.calculoDepreciacionesDataGridView.DataSource = this.calculoDepreciacionesBindingSource;
            this.calculoDepreciacionesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculoDepreciacionesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.calculoDepreciacionesDataGridView.Name = "calculoDepreciacionesDataGridView";
            this.calculoDepreciacionesDataGridView.Size = new System.Drawing.Size(963, 388);
            this.calculoDepreciacionesDataGridView.TabIndex = 1;
            // 
            // activosFijosBindingSource
            // 
            this.activosFijosBindingSource.DataMember = "ActivosFijos";
            this.activosFijosBindingSource.DataSource = this.activos_FijosDataSet;
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
            this.dataGridViewTextBoxColumn2.ValueMember = "IdActivoFijo";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AnioProceso";
            this.dataGridViewTextBoxColumn3.HeaderText = "AnioProceso";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MesProceso";
            this.dataGridViewTextBoxColumn4.HeaderText = "MesProceso";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaProceso";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaProceso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MontoDespreciado";
            this.dataGridViewTextBoxColumn6.HeaderText = "MontoDespreciado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DespreciacionAcumulada";
            this.dataGridViewTextBoxColumn7.HeaderText = "DespreciacionAcumulada";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CuentaCompra";
            this.dataGridViewTextBoxColumn8.HeaderText = "CuentaCompra";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CuentaDepreciacion";
            this.dataGridViewTextBoxColumn9.HeaderText = "CuentaDepreciacion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // frmMantenimientoCalculoDepreciaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 413);
            this.Controls.Add(this.calculoDepreciacionesDataGridView);
            this.Controls.Add(this.calculoDepreciacionesBindingNavigator);
            this.Name = "frmMantenimientoCalculoDepreciaciones";
            this.Text = "Mantenimiento de Calculos de Deprestaciones";
            this.Load += new System.EventHandler(this.frmMantenimientoCalculoDepreciaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activos_FijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionesBindingNavigator)).EndInit();
            this.calculoDepreciacionesBindingNavigator.ResumeLayout(false);
            this.calculoDepreciacionesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calculoDepreciacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Activos_FijosDataSet activos_FijosDataSet;
        private System.Windows.Forms.BindingSource calculoDepreciacionesBindingSource;
        private Activos_FijosDataSetTableAdapters.CalculoDepreciacionesTableAdapter calculoDepreciacionesTableAdapter;
        private Activos_FijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator calculoDepreciacionesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton calculoDepreciacionesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView calculoDepreciacionesDataGridView;
        private Activos_FijosDataSetTableAdapters.ActivosFijosTableAdapter activosFijosTableAdapter;
        private System.Windows.Forms.BindingSource activosFijosBindingSource;
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