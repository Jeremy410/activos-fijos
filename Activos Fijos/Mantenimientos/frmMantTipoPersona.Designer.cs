namespace Activos_Fijos
{
    partial class frmMantTipoPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantTipoPersona));
            this.activosFijosDataSet = new Activos_Fijos.ActivosFijosDataSet();
            this.tipoPersonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPersonasTableAdapter = new Activos_Fijos.ActivosFijosDataSetTableAdapters.TipoPersonasTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager();
            this.tipoPersonasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tipoPersonasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tipoPersonasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonasBindingNavigator)).BeginInit();
            this.tipoPersonasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activosFijosDataSet
            // 
            this.activosFijosDataSet.DataSetName = "ActivosFijosDataSet";
            this.activosFijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoPersonasBindingSource
            // 
            this.tipoPersonasBindingSource.DataMember = "TipoPersonas";
            this.tipoPersonasBindingSource.DataSource = this.activosFijosDataSet;
            // 
            // tipoPersonasTableAdapter
            // 
            this.tipoPersonasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TipoPagosTableAdapter = null;
            this.tableAdapterManager.TipoPersonasTableAdapter = this.tipoPersonasTableAdapter;
            this.tableAdapterManager.TiposActivosTableAdapter = null;
            this.tableAdapterManager.UbicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Activos_Fijos.ActivosFijosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // tipoPersonasBindingNavigator
            // 
            this.tipoPersonasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tipoPersonasBindingNavigator.BindingSource = this.tipoPersonasBindingSource;
            this.tipoPersonasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tipoPersonasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tipoPersonasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tipoPersonasBindingNavigatorSaveItem});
            this.tipoPersonasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tipoPersonasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tipoPersonasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tipoPersonasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tipoPersonasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tipoPersonasBindingNavigator.Name = "tipoPersonasBindingNavigator";
            this.tipoPersonasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tipoPersonasBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.tipoPersonasBindingNavigator.TabIndex = 0;
            this.tipoPersonasBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tipoPersonasBindingNavigatorSaveItem
            // 
            this.tipoPersonasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tipoPersonasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoPersonasBindingNavigatorSaveItem.Image")));
            this.tipoPersonasBindingNavigatorSaveItem.Name = "tipoPersonasBindingNavigatorSaveItem";
            this.tipoPersonasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tipoPersonasBindingNavigatorSaveItem.Text = "Save Data";
            this.tipoPersonasBindingNavigatorSaveItem.Click += new System.EventHandler(this.tipoPersonasBindingNavigatorSaveItem_Click);
            // 
            // tipoPersonasDataGridView
            // 
            this.tipoPersonasDataGridView.AutoGenerateColumns = false;
            this.tipoPersonasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tipoPersonasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoPersonasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.tipoPersonasDataGridView.DataSource = this.tipoPersonasBindingSource;
            this.tipoPersonasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoPersonasDataGridView.Location = new System.Drawing.Point(0, 25);
            this.tipoPersonasDataGridView.Name = "tipoPersonasDataGridView";
            this.tipoPersonasDataGridView.Size = new System.Drawing.Size(794, 385);
            this.tipoPersonasDataGridView.TabIndex = 1;
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
            // frmMantTipoPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 410);
            this.Controls.Add(this.tipoPersonasDataGridView);
            this.Controls.Add(this.tipoPersonasBindingNavigator);
            this.Name = "frmMantTipoPersona";
            this.Text = "Mantenimiento de Tipo de Personas";
            this.Load += new System.EventHandler(this.frmMantTipoPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonasBindingNavigator)).EndInit();
            this.tipoPersonasBindingNavigator.ResumeLayout(false);
            this.tipoPersonasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ActivosFijosDataSet activosFijosDataSet;
        private System.Windows.Forms.BindingSource tipoPersonasBindingSource;
        private ActivosFijosDataSetTableAdapters.TipoPersonasTableAdapter tipoPersonasTableAdapter;
        private ActivosFijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tipoPersonasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tipoPersonasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tipoPersonasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}