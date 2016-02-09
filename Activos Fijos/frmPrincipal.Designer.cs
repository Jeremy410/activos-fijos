namespace Activos_Fijos
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activosFijosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activos_FijosDataSet = new Activos_Fijos.Activos_FijosDataSet();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.DepartamentosTableAdapter();
            this.tableAdapterManager = new Activos_Fijos.Activos_FijosDataSetTableAdapters.TableAdapterManager();
            this.activosFijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosFijosTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.ActivosFijosTableAdapter();
            this.ubicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ubicacionesTableAdapter = new Activos_Fijos.Activos_FijosDataSetTableAdapters.UbicacionesTableAdapter();
            this.calculosDeDespreciacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activos_FijosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.tiposDeActivosToolStripMenuItem,
            this.ubicacionesToolStripMenuItem,
            this.activosFijosToolStripMenuItem,
            this.calculosDeDespreciacionesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // tiposDeActivosToolStripMenuItem
            // 
            this.tiposDeActivosToolStripMenuItem.Name = "tiposDeActivosToolStripMenuItem";
            this.tiposDeActivosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.tiposDeActivosToolStripMenuItem.Text = "Tipos de Activos";
            this.tiposDeActivosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeActivosToolStripMenuItem_Click);
            // 
            // ubicacionesToolStripMenuItem
            // 
            this.ubicacionesToolStripMenuItem.Name = "ubicacionesToolStripMenuItem";
            this.ubicacionesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ubicacionesToolStripMenuItem.Text = "Ubicaciones";
            this.ubicacionesToolStripMenuItem.Click += new System.EventHandler(this.ubicacionesToolStripMenuItem_Click);
            // 
            // activosFijosToolStripMenuItem
            // 
            this.activosFijosToolStripMenuItem.Name = "activosFijosToolStripMenuItem";
            this.activosFijosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.activosFijosToolStripMenuItem.Text = "Activos Fijos";
            this.activosFijosToolStripMenuItem.Click += new System.EventHandler(this.activosFijosToolStripMenuItem_Click);
            // 
            // activos_FijosDataSet
            // 
            this.activos_FijosDataSet.DataSetName = "Activos_FijosDataSet";
            this.activos_FijosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivosFijosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalculoDepreciacionesTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = this.departamentosTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.TipoActivosTableAdapter = null;
            this.tableAdapterManager.TipoPersonasTableAdapter = null;
            this.tableAdapterManager.UbicacionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Activos_Fijos.Activos_FijosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // ubicacionesBindingSource
            // 
            this.ubicacionesBindingSource.DataMember = "Ubicaciones";
            this.ubicacionesBindingSource.DataSource = this.activos_FijosDataSet;
            // 
            // ubicacionesTableAdapter
            // 
            this.ubicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // calculosDeDespreciacionesToolStripMenuItem
            // 
            this.calculosDeDespreciacionesToolStripMenuItem.Name = "calculosDeDespreciacionesToolStripMenuItem";
            this.calculosDeDespreciacionesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.calculosDeDespreciacionesToolStripMenuItem.Text = "Calculos de Despreciaciones";
            this.calculosDeDespreciacionesToolStripMenuItem.Click += new System.EventHandler(this.calculosDeDespreciacionesToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Activos Fijos";
            this.Load += new System.EventHandler(this.frmActivosFijos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activos_FijosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosFijosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ubicacionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private Activos_FijosDataSet activos_FijosDataSet;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private Activos_FijosDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private Activos_FijosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicacionesToolStripMenuItem;
        private System.Windows.Forms.BindingSource activosFijosBindingSource;
        private Activos_FijosDataSetTableAdapters.ActivosFijosTableAdapter activosFijosTableAdapter;
        private System.Windows.Forms.BindingSource ubicacionesBindingSource;
        private Activos_FijosDataSetTableAdapters.UbicacionesTableAdapter ubicacionesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem activosFijosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculosDeDespreciacionesToolStripMenuItem;
    }
}

