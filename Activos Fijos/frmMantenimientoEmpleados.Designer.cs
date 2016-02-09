namespace Activos_Fijos
{
    partial class frmMantenimientoEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.empleadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.empleadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activos_FijosDataSet = new Activos_Fijos.Activos_FijosDataSet();
            this.empleadosDataGridView = new System.Windows.Forms.DataGridView();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.Activos_FijosDataSetTableAdapters.TableAdapterManager();
            this.departamentosTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.DepartamentosTableAdapter();
            this.tipoPersonasTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.TipoPersonasTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new CalendarColumn();
            this.dgvComboDepartamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvComboTipoPersona = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTxtFechaIngreso = new CalendarColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingNavigator)).BeginInit();
            this.empleadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activos_FijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonasBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // empleadosBindingNavigatorSaveItem
            // 
            this.empleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosBindingNavigatorSaveItem.Image")));
            this.empleadosBindingNavigatorSaveItem.Name = "empleadosBindingNavigatorSaveItem";
            this.empleadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empleadosBindingNavigatorSaveItem.Text = "Save Data";
            this.empleadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.empleadosBindingNavigatorSaveItem_Click);
            // 
            // empleadosBindingNavigator
            // 
            this.empleadosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadosBindingNavigator.BindingSource = this.empleadosBindingSource;
            this.empleadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empleadosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empleadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.empleadosBindingNavigatorSaveItem});
            this.empleadosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empleadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empleadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empleadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empleadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empleadosBindingNavigator.Name = "empleadosBindingNavigator";
            this.empleadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empleadosBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.empleadosBindingNavigator.TabIndex = 0;
            this.empleadosBindingNavigator.Text = "bindingNavigator1";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.activos_FijosDataSet;
            // 
            // activos_FijosDataSet
            // 
            this.activos_FijosDataSet.DataSetName = "Activos_FijosDataSet";
            this.activos_FijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosDataGridView
            // 
            this.empleadosDataGridView.AutoGenerateColumns = false;
            this.empleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvComboDepartamento,
            this.dgvComboTipoPersona,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dgvTxtFechaIngreso,
            this.dataGridViewCheckBoxColumn1});
            this.empleadosDataGridView.DataSource = this.empleadosBindingSource;
            this.empleadosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empleadosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.empleadosDataGridView.Name = "empleadosDataGridView";
            this.empleadosDataGridView.Size = new System.Drawing.Size(644, 326);
            this.empleadosDataGridView.TabIndex = 1;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.activos_FijosDataSet;
            // 
            // tipoPersonasBindingSource
            // 
            this.tipoPersonasBindingSource.DataMember = "TipoPersonas";
            this.tipoPersonasBindingSource.DataSource = this.activos_FijosDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.TipoPersonasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Activos_Fijos.Activos_FijosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // tipoPersonasTableAdapter
            // 
            this.tipoPersonasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "FechaIngreso";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = "No date selected";
            this.calendarColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.calendarColumn1.HeaderText = "FechaIngreso";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvComboDepartamento
            // 
            this.dgvComboDepartamento.DataPropertyName = "IdDepartamento";
            this.dgvComboDepartamento.DataSource = this.departamentosBindingSource;
            this.dgvComboDepartamento.DisplayMember = "Descripcion";
            this.dgvComboDepartamento.HeaderText = "Departamento";
            this.dgvComboDepartamento.Name = "dgvComboDepartamento";
            this.dgvComboDepartamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComboDepartamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvComboDepartamento.ValueMember = "IdDepartamento";
            // 
            // dgvComboTipoPersona
            // 
            this.dgvComboTipoPersona.DataPropertyName = "IdTipoPersona";
            this.dgvComboTipoPersona.DataSource = this.tipoPersonasBindingSource;
            this.dgvComboTipoPersona.DisplayMember = "Descripcion";
            this.dgvComboTipoPersona.HeaderText = "Tipo de Persona";
            this.dgvComboTipoPersona.Name = "dgvComboTipoPersona";
            this.dgvComboTipoPersona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComboTipoPersona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvComboTipoPersona.ValueMember = "IdTipoPersona";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dgvTxtFechaIngreso
            // 
            this.dgvTxtFechaIngreso.DataPropertyName = "FechaIngreso";
            dataGridViewCellStyle1.Format = "D";
            this.dgvTxtFechaIngreso.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTxtFechaIngreso.HeaderText = "FechaIngreso";
            this.dgvTxtFechaIngreso.Name = "dgvTxtFechaIngreso";
            this.dgvTxtFechaIngreso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTxtFechaIngreso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmMantenimientoEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 351);
            this.Controls.Add(this.empleadosDataGridView);
            this.Controls.Add(this.empleadosBindingNavigator);
            this.Name = "frmMantenimientoEmpleados";
            this.Text = "Mantenimiento de Empleados";
            this.Load += new System.EventHandler(this.frmMantenimientoEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingNavigator)).EndInit();
            this.empleadosBindingNavigator.ResumeLayout(false);
            this.empleadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activos_FijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Activos_FijosDataSet activos_FijosDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private Activos_FijosDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private Activos_FijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton empleadosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator empleadosBindingNavigator;
        private System.Windows.Forms.DataGridView empleadosDataGridView;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Activos_FijosDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.BindingSource tipoPersonasBindingSource;
        private Activos_FijosDataSetTableAdapters.TipoPersonasTableAdapter tipoPersonasTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvComboDepartamento;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvComboTipoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private CalendarColumn dgvTxtFechaIngreso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private CalendarColumn calendarColumn1;
    }
}