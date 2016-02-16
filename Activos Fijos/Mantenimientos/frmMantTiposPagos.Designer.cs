namespace Activos_Fijos
{
    partial class frmMantTiposPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantTiposPagos));
            this.activosFijosDataSet = new Activos_Fijos.ActivosFijosDataSet();
            this.tipoPagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPagosTableAdapter = new Activos_Fijos.ActivosFijosDataSetTableAdapters.TipoPagosTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager();
            this.tipoPagosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tipoPagosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tipoPagosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagosBindingNavigator)).BeginInit();
            this.tipoPagosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activosFijosDataSet
            // 
            this.activosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.activosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoPagosBindingSource
            // 
            this.tipoPagosBindingSource.DataMember = "TipoPagos";
            this.tipoPagosBindingSource.DataSource = this.activosFijosDataSet;
            // 
            // tipoPagosTableAdapter
            // 
            this.tipoPagosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OpcionesXRolesTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.TipoPagosTableAdapter = this.tipoPagosTableAdapter;
            this.tableAdapterManager.TipoPersonasTableAdapter = null;
            this.tableAdapterManager.TiposActivosTableAdapter = null;
            this.tableAdapterManager.UbicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // tipoPagosBindingNavigator
            // 
            this.tipoPagosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipoPagosBindingNavigator.BindingSource = this.tipoPagosBindingSource;
            this.tipoPagosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipoPagosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tipoPagosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tipoPagosBindingNavigatorSaveItem});
            this.tipoPagosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipoPagosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipoPagosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipoPagosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipoPagosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipoPagosBindingNavigator.Name = "tipoPagosBindingNavigator";
            this.tipoPagosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipoPagosBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.tipoPagosBindingNavigator.TabIndex = 0;
            this.tipoPagosBindingNavigator.Text = "bindingNavigator1";
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
            // tipoPagosBindingNavigatorSaveItem
            // 
            this.tipoPagosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipoPagosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoPagosBindingNavigatorSaveItem.Image")));
            this.tipoPagosBindingNavigatorSaveItem.Name = "tipoPagosBindingNavigatorSaveItem";
            this.tipoPagosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tipoPagosBindingNavigatorSaveItem.Text = "Save Data";
            this.tipoPagosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tipoPagosBindingNavigatorSaveItem_Click);
            // 
            // tipoPagosDataGridView
            // 
            this.tipoPagosDataGridView.AutoGenerateColumns = false;
            this.tipoPagosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tipoPagosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoPagosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.tipoPagosDataGridView.DataSource = this.tipoPagosBindingSource;
            this.tipoPagosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoPagosDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tipoPagosDataGridView.Name = "tipoPagosDataGridView";
            this.tipoPagosDataGridView.Size = new System.Drawing.Size(778, 380);
            this.tipoPagosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // frmMantTiposPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 405);
            this.Controls.Add(this.tipoPagosDataGridView);
            this.Controls.Add(this.tipoPagosBindingNavigator);
            this.Name = "frmMantTiposPagos";
            this.Text = "Mantenimiento de Tipos de Pagos";
            this.Load += new System.EventHandler(this.frmMantTiposPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagosBindingNavigator)).EndInit();
            this.tipoPagosBindingNavigator.ResumeLayout(false);
            this.tipoPagosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ActivosFijosDataSet activosFijosDataSet;
        private System.Windows.Forms.BindingSource tipoPagosBindingSource;
        private ActivosFijosDataSetTableAdapters.TipoPagosTableAdapter tipoPagosTableAdapter;
        private ActivosFijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tipoPagosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tipoPagosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tipoPagosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}