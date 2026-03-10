namespace CoffeeManagement
{
    partial class CoffeeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeManagementForm));
            this.dgwCoffee = new System.Windows.Forms.DataGridView();
            this.coffeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDBDataSet = new CoffeeManagement.CoffeeDBDataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.picCoffeeImage = new System.Windows.Forms.PictureBox();
            this.coffeeDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeTableAdapter = new CoffeeManagement.CoffeeDBDataSetTableAdapters.CoffeeTableAdapter();
            this.tableAdapterManager = new CoffeeManagement.CoffeeDBDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorCoffee = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.coffeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoffeeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCoffee)).BeginInit();
            this.bindingNavigatorCoffee.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCoffee
            // 
            this.dgwCoffee.AllowUserToAddRows = false;
            this.dgwCoffee.AllowUserToResizeRows = false;
            this.dgwCoffee.AutoGenerateColumns = false;
            this.dgwCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCoffee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coffeeIDDataGridViewTextBoxColumn,
            this.coffeeNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.imageNameDataGridViewTextBoxColumn});
            this.dgwCoffee.DataSource = this.coffeeBindingSource;
            this.dgwCoffee.Location = new System.Drawing.Point(12, 55);
            this.dgwCoffee.MultiSelect = false;
            this.dgwCoffee.Name = "dgwCoffee";
            this.dgwCoffee.RowHeadersVisible = false;
            this.dgwCoffee.RowHeadersWidth = 51;
            this.dgwCoffee.RowTemplate.Height = 24;
            this.dgwCoffee.Size = new System.Drawing.Size(602, 324);
            this.dgwCoffee.TabIndex = 0;
            this.dgwCoffee.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCoffee_CellValueChanged);
            this.dgwCoffee.SelectionChanged += new System.EventHandler(this.dgwCoffee_SelectionChanged);
            // 
            // coffeeBindingSource
            // 
            this.coffeeBindingSource.DataMember = "Coffee";
            this.coffeeBindingSource.DataSource = this.coffeeDBDataSet;
            // 
            // coffeeDBDataSet
            // 
            this.coffeeDBDataSet.DataSetName = "CoffeeDBDataSet";
            this.coffeeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 401);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(187, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.Location = new System.Drawing.Point(424, 401);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(187, 37);
            this.btnCloseApp.TabIndex = 2;
            this.btnCloseApp.Text = "Close";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(215, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picCoffeeImage
            // 
            this.picCoffeeImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("picCoffeeImage.InitialImage")));
            this.picCoffeeImage.Location = new System.Drawing.Point(620, 55);
            this.picCoffeeImage.Name = "picCoffeeImage";
            this.picCoffeeImage.Size = new System.Drawing.Size(218, 239);
            this.picCoffeeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoffeeImage.TabIndex = 6;
            this.picCoffeeImage.TabStop = false;
            // 
            // coffeeDBDataSetBindingSource
            // 
            this.coffeeDBDataSetBindingSource.DataSource = this.coffeeDBDataSet;
            this.coffeeDBDataSetBindingSource.Position = 0;
            // 
            // coffeeTableAdapter
            // 
            this.coffeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoffeeTableAdapter = this.coffeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = CoffeeManagement.CoffeeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorCoffee
            // 
            this.bindingNavigatorCoffee.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorCoffee.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCoffee.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorCoffee.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorCoffee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorCoffee.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorCoffee.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCoffee.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCoffee.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCoffee.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCoffee.Name = "bindingNavigatorCoffee";
            this.bindingNavigatorCoffee.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCoffee.Size = new System.Drawing.Size(850, 31);
            this.bindingNavigatorCoffee.TabIndex = 7;
            this.bindingNavigatorCoffee.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // coffeeIDDataGridViewTextBoxColumn
            // 
            this.coffeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coffeeIDDataGridViewTextBoxColumn.DataPropertyName = "CoffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.HeaderText = "Coffee ID";
            this.coffeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coffeeIDDataGridViewTextBoxColumn.Name = "coffeeIDDataGridViewTextBoxColumn";
            this.coffeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.coffeeIDDataGridViewTextBoxColumn.Width = 91;
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            this.coffeeNameDataGridViewTextBoxColumn.Width = 112;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 67;
            // 
            // imageNameDataGridViewTextBoxColumn
            // 
            this.imageNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.imageNameDataGridViewTextBoxColumn.DataPropertyName = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.HeaderText = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageNameDataGridViewTextBoxColumn.Name = "imageNameDataGridViewTextBoxColumn";
            this.imageNameDataGridViewTextBoxColumn.Width = 111;
            // 
            // CoffeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.bindingNavigatorCoffee);
            this.Controls.Add(this.picCoffeeImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgwCoffee);
            this.Name = "CoffeeManagementForm";
            this.Text = "Coffee Management";
            this.Load += new System.EventHandler(this.CoffeeManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoffeeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCoffee)).EndInit();
            this.bindingNavigatorCoffee.ResumeLayout(false);
            this.bindingNavigatorCoffee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCoffee;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picCoffeeImage;
        private System.Windows.Forms.BindingSource coffeeDBDataSetBindingSource;
        private CoffeeDBDataSet coffeeDBDataSet;
        private System.Windows.Forms.BindingSource coffeeBindingSource;
        private CoffeeDBDataSetTableAdapters.CoffeeTableAdapter coffeeTableAdapter;
        private CoffeeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCoffee;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
    }
}

