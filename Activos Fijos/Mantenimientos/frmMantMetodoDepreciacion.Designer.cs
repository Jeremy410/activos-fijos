namespace Activos_Fijos
{
    partial class frmMantMetodoDepreciacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantMetodoDepreciacion));
            this.activosFijosDataSet = new Activos_Fijos.ActivosFijosDataSet();
            this.metodoDepreciacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoDepreciacionTableAdapter = new Activos_Fijos.ActivosFijosDataSetTableAdapters.MetodoDepreciacionTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.metodoDepreciacionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.metodoDepreciacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.metodoDepreciacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoDepreciacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoDepreciacionBindingNavigator)).BeginInit();
            this.metodoDepreciacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metodoDepreciacionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activosFijosDataSet
            // 
            this.activosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.activosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoDepreciacionBindingSource
            // 
            this.metodoDepreciacionBindingSource.DataMember = "MetodoDepreciacion";
            this.metodoDepreciacionBindingSource.DataSource = this.activosFijosDataSet;
            // 
            // metodoDepreciacionTableAdapter
            // 
            this.metodoDepreciacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivosFijosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalculoDepreciacionTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.MetodoDepreciacionTableAdapter = this.metodoDepreciacionTableAdapter;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descripción";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 375;
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
            // metodoDepreciacionBindingNavigatorSaveItem
            // 
            this.metodoDepreciacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.metodoDepreciacionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("metodoDepreciacionBindingNavigatorSaveItem.Image")));
            this.metodoDepreciacionBindingNavigatorSaveItem.Name = "metodoDepreciacionBindingNavigatorSaveItem";
            this.metodoDepreciacionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.metodoDepreciacionBindingNavigatorSaveItem.Text = "Save Data";
            this.metodoDepreciacionBindingNavigatorSaveItem.Click += new System.EventHandler(this.metodoDepreciacionBindingNavigatorSaveItem_Click);
            // 
            // metodoDepreciacionBindingNavigator
            // 
            this.metodoDepreciacionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.metodoDepreciacionBindingNavigator.BindingSource = this.metodoDepreciacionBindingSource;
            this.metodoDepreciacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.metodoDepreciacionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.metodoDepreciacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.metodoDepreciacionBindingNavigatorSaveItem});
            this.metodoDepreciacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.metodoDepreciacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.metodoDepreciacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.metodoDepreciacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.metodoDepreciacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.metodoDepreciacionBindingNavigator.Name = "metodoDepreciacionBindingNavigator";
            this.metodoDepreciacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.metodoDepreciacionBindingNavigator.Size = new System.Drawing.Size(793, 25);
            this.metodoDepreciacionBindingNavigator.TabIndex = 0;
            this.metodoDepreciacionBindingNavigator.Text = "bindingNavigator1";
            // 
            // metodoDepreciacionDataGridView
            // 
            this.metodoDepreciacionDataGridView.AutoGenerateColumns = false;
            this.metodoDepreciacionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metodoDepreciacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metodoDepreciacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.metodoDepreciacionDataGridView.DataSource = this.metodoDepreciacionBindingSource;
            this.metodoDepreciacionDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metodoDepreciacionDataGridView.Location = new System.Drawing.Point(0, 25);
            this.metodoDepreciacionDataGridView.Name = "metodoDepreciacionDataGridView";
            this.metodoDepreciacionDataGridView.Size = new System.Drawing.Size(793, 381);
            this.metodoDepreciacionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmMantMetodoDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 406);
            this.Controls.Add(this.metodoDepreciacionDataGridView);
            this.Controls.Add(this.metodoDepreciacionBindingNavigator);
            this.Name = "frmMantMetodoDepreciacion";
            this.Text = "Mantenimiento de Método de Depreciación";
            this.Load += new System.EventHandler(this.frmMantMetodoDepreciacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoDepreciacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoDepreciacionBindingNavigator)).EndInit();
            this.metodoDepreciacionBindingNavigator.ResumeLayout(false);
            this.metodoDepreciacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metodoDepreciacionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ActivosFijosDataSet activosFijosDataSet;
        private System.Windows.Forms.BindingSource metodoDepreciacionBindingSource;
        private ActivosFijosDataSetTableAdapters.MetodoDepreciacionTableAdapter metodoDepreciacionTableAdapter;
        private ActivosFijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.ToolStripButton metodoDepreciacionBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator metodoDepreciacionBindingNavigator;
        private System.Windows.Forms.DataGridView metodoDepreciacionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}