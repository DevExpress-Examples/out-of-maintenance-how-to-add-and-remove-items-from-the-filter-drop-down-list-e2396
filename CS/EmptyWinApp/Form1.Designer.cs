namespace EmptyWinApp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.productReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productReports = new EmptyWinApp.ProductReports();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.productReportsTableAdapter = new EmptyWinApp.ProductReportsTableAdapters.ProductReportsTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productReports)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.DataSource = this.productReportsBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldProductSales,
            this.fieldShippedDate});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 44);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(551, 352);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomFilterPopupItems += new DevExpress.XtraPivotGrid.PivotCustomFilterPopupItemsEventHandler(this.pivotGridControl1_CustomFilterPopupItems);
            // 
            // productReportsBindingSource
            // 
            this.productReportsBindingSource.DataMember = "ProductReports";
            this.productReportsBindingSource.DataSource = this.productReports;
            // 
            // productReports
            // 
            this.productReports.DataSetName = "ProductReports";
            this.productReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldProductSales
            // 
            this.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales.AreaIndex = 0;
            this.fieldProductSales.Caption = "Product Sales";
            this.fieldProductSales.FieldName = "ProductSales";
            this.fieldProductSales.Name = "fieldProductSales";
            // 
            // fieldShippedDate
            // 
            this.fieldShippedDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedDate.AreaIndex = 0;
            this.fieldShippedDate.Caption = "Year";
            this.fieldShippedDate.FieldName = "ShippedDate";
            this.fieldShippedDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldShippedDate.Name = "fieldShippedDate";
            this.fieldShippedDate.UnboundFieldName = "fieldShippedDate";
            // 
            // productReportsTableAdapter
            // 
            this.productReportsTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(551, 26);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "In this example, the CustomFilterPopupItems event is handled to hide the \'Beverag" +
                "es\' item from the filter dropdown list of the Category field, and add a dummy it" +
                "em to the list.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 408);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private ProductReports productReports;
        private System.Windows.Forms.BindingSource productReportsBindingSource;
        private EmptyWinApp.ProductReportsTableAdapters.ProductReportsTableAdapter productReportsTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippedDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

