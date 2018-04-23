Namespace EmptyWinApp
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.productReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.productReports = New EmptyWinApp.ProductReports()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductSales = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShippedDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.productReportsTableAdapter = New EmptyWinApp.ProductReportsTableAdapters.ProductReportsTableAdapter()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.productReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.productReports, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.pivotGridControl1.DataSource = Me.productReportsBindingSource
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldProductName, Me.fieldProductSales, Me.fieldShippedDate})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 44)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(551, 352)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' productReportsBindingSource
            ' 
            Me.productReportsBindingSource.DataMember = "ProductReports"
            Me.productReportsBindingSource.DataSource = Me.productReports
            ' 
            ' productReports
            ' 
            Me.productReports.DataSetName = "ProductReports"
            Me.productReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            ' 
            ' fieldProductSales
            ' 
            Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductSales.AreaIndex = 0
            Me.fieldProductSales.Caption = "Product Sales"
            Me.fieldProductSales.FieldName = "ProductSales"
            Me.fieldProductSales.Name = "fieldProductSales"
            ' 
            ' fieldShippedDate
            ' 
            Me.fieldShippedDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldShippedDate.AreaIndex = 0
            Me.fieldShippedDate.Caption = "Year"
            Me.fieldShippedDate.FieldName = "ShippedDate"
            Me.fieldShippedDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldShippedDate.Name = "fieldShippedDate"
            Me.fieldShippedDate.UnboundFieldName = "fieldShippedDate"
            ' 
            ' productReportsTableAdapter
            ' 
            Me.productReportsTableAdapter.ClearBeforeFill = True
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.labelControl1.Location = New System.Drawing.Point(12, 12)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(551, 26)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "In this example, the CustomFilterPopupItems event is handled to hide the 'Beverag" & "es' item from the filter dropdown list of the Category field, and add a dummy it" & "em to the list."
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(575, 408)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.productReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.productReports, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private productReports As ProductReports
        Private productReportsBindingSource As System.Windows.Forms.BindingSource
        Private productReportsTableAdapter As EmptyWinApp.ProductReportsTableAdapters.ProductReportsTableAdapter
        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldProductSales As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldShippedDate As DevExpress.XtraPivotGrid.PivotGridField
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace

