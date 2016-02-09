namespace Activos_Fijos
{
    partial class frmMantenimientoActivosFijos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoActivosFijos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.activos_FijosDataSet = new Activos_Fijos.Activos_FijosDataSet();
            this.activosFijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosFijosTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.ActivosFijosTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.Activos_FijosDataSetTableAdapters.TableAdapterManager();
            this.activosFijosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.activosFijosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activosFijosDataGridView = new System.Windows.Forms.DataGridView();
            this.ubicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.UbicacionesTableAdapter();
            this.activosFijosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoActivosTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.TipoActivosTableAdapter();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.DepartamentosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new CalendarColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activos_FijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingNavigator)).BeginInit();
            this.activosFijosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activos_FijosDataSet
            // 
            this.activos_FijosDataSet.DataSetName = "Activos_FijosDataSet";
            this.activos_FijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivosFijosTableAdapter = this.activosFijosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartamentosTableAdapter = this.departamentosTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.TipoActivosTableAdapter = this.tipoActivosTableAdapter;
            this.tableAdapterManager.TipoPersonasTableAdapter = null;
            this.tableAdapterManager.UbicacionesTableAdapter = this.ubicacionesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Activos_Fijos.Activos_FijosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // activosFijosBindingNavigator
            // 
            this.activosFijosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activosFijosBindingNavigator.BindingSource = this.activosFijosBindingSource;
            this.activosFijosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activosFijosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activosFijosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.activosFijosBindingNavigatorSaveItem});
            this.activosFijosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activosFijosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activosFijosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activosFijosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activosFijosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activosFijosBindingNavigator.Name = "activosFijosBindingNavigator";
            this.activosFijosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activosFijosBindingNavigator.Size = new System.Drawing.Size(908, 25);
            this.activosFijosBindingNavigator.TabIndex = 0;
            this.activosFijosBindingNavigator.Text = "bindingNavigator1";
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
            // activosFijosBindingNavigatorSaveItem
            // 
            this.activosFijosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.activosFijosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("activosFijosBindingNavigatorSaveItem.Image")));
            this.activosFijosBindingNavigatorSaveItem.Name = "activosFijosBindingNavigatorSaveItem";
            this.activosFijosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.activosFijosBindingNavigatorSaveItem.Text = "Save Data";
            this.activosFijosBindingNavigatorSaveItem.Click += new System.EventHandler(this.activosFijosBindingNavigatorSaveItem_Click);
            // 
            // activosFijosDataGridView
            // 
            this.activosFijosDataGridView.AutoGenerateColumns = false;
            this.activosFijosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activosFijosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activosFijosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.activosFijosDataGridView.DataSource = this.activosFijosBindingSource;
            this.activosFijosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activosFijosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.activosFijosDataGridView.Name = "activosFijosDataGridView";
            this.activosFijosDataGridView.Size = new System.Drawing.Size(908, 340);
            this.activosFijosDataGridView.TabIndex = 1;
            // 
            // ubicacionesBindingSource
            // 
            this.ubicacionesBindingSource.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource.DataSource = this.activos_FijosDataSet;
            // 
            // ubicacionesTableAdapter
            // 
            this.ubicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // activosFijosDataSetBindingSource
            // 
            this.activosFijosDataSetBindingSource.DataSource = this.activos_FijosDataSet;
            this.activosFijosDataSetBindingSource.Position = 0;
            // 
            // tipoActivosBindingSource
            // 
            this.tipoActivosBindingSource.DataMember = "TipoActivos";
            this.tipoActivosBindingSource.DataSource = this.activos_FijosDataSet;
            // 
            // tipoActivosTableAdapter
            // 
            this.tipoActivosTableAdapter.ClearBeforeFill = true;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.activos_FijosDataSet;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDepartamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDepartamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 123;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdUbicacion";
            this.dataGridViewTextBoxColumn2.DataSource = this.ubicacionesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdUbicacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdUbicacion";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdTipoActivo";
            this.dataGridViewTextBoxColumn3.DataSource = this.tipoActivosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdTipoActivo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdTipoActivo";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdDepartamento";
            this.dataGridViewTextBoxColumn4.DataSource = this.departamentosBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdDepartamento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdDepartamento";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaRegistro";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaRegistro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ValorCompra";
            this.dataGridViewTextBoxColumn7.HeaderText = "ValorCompra";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DepreciacionAcumulada";
            this.dataGridViewTextBoxColumn8.HeaderText = "DepreciacionAcumulada";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmMantenimientoActivosFijos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 365);
            this.Controls.Add(this.activosFijosDataGridView);
            this.Controls.Add(this.activosFijosBindingNavigator);
            this.Name = "frmMantenimientoActivosFijos";
            this.Text = "frmMantenimientoActivosFijos";
            this.Load += new System.EventHandler(this.frmMantenimientoActivosFijos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activos_FijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingNavigator)).EndInit();
            this.activosFijosBindingNavigator.ResumeLayout(false);
            this.activosFijosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Activos_FijosDataSet activos_FijosDataSet;
        private System.Windows.Forms.BindingSource activosFijosBindingSource;
        private Activos_FijosDataSetTableAdapters.ActivosFijosTableAdapter activosFijosTableAdapter;
        private Activos_FijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator activosFijosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton activosFijosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView activosFijosDataGridView;
        private Activos_FijosDataSetTableAdapters.UbicacionesTableAdapter ubicacionesTableAdapter;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource;
        private Activos_FijosDataSetTableAdapters.TipoActivosTableAdapter tipoActivosTableAdapter;
        private System.Windows.Forms.BindingSource activosFijosDataSetBindingSource;
        private System.Windows.Forms.BindingSource tipoActivosBindingSource;
        private Activos_FijosDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private CalendarColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}