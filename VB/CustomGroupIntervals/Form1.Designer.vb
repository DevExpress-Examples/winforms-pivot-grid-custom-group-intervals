Namespace CustomGroupIntervals

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomGroupIntervals.Form1))
            Dim fieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo10 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim excelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim excelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(800, 450)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' excelDataSource1
            ' 
            Me.excelDataSource1.FileName = "Data\SalesPerson2.xlsx"
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            fieldInfo1.Name = "CategoryName"
            fieldInfo1.OriginalName = "CategoryName"
            fieldInfo1.Type = GetType(String)
            fieldInfo2.Name = "Country"
            fieldInfo2.OriginalName = "Country"
            fieldInfo2.Type = GetType(String)
            fieldInfo3.Name = "ProductName"
            fieldInfo3.OriginalName = "ProductName"
            fieldInfo3.Type = GetType(String)
            fieldInfo4.Name = "Sales Person"
            fieldInfo4.OriginalName = "Sales Person"
            fieldInfo4.Type = GetType(String)
            fieldInfo5.Name = "OrderDate"
            fieldInfo5.OriginalName = "OrderDate"
            fieldInfo5.Type = GetType(System.DateTime)
            fieldInfo6.Name = "OrderID"
            fieldInfo6.OriginalName = "OrderID"
            fieldInfo6.Type = GetType(Double)
            fieldInfo7.Name = "Quantity"
            fieldInfo7.OriginalName = "Quantity"
            fieldInfo7.Type = GetType(Double)
            fieldInfo8.Name = "Discount"
            fieldInfo8.OriginalName = "Discount"
            fieldInfo8.Type = GetType(Double)
            fieldInfo9.Name = "Extended Price"
            fieldInfo9.OriginalName = "Extended Price"
            fieldInfo9.Type = GetType(Double)
            fieldInfo10.Name = "UnitPrice"
            fieldInfo10.OriginalName = "UnitPrice"
            fieldInfo10.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9, fieldInfo10})
            excelWorksheetSettings1.CellRange = Nothing
            excelWorksheetSettings1.WorksheetIndex = Nothing
            excelWorksheetSettings1.WorksheetName = "Sheet1"
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = excelSourceOptions1
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
    End Class
End Namespace
