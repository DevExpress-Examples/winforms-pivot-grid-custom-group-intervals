Namespace CustomGroupIntervals
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim FieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo10 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim ExcelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim ExcelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(ExcelWorksheetSettings1)
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(800, 450)
            Me.pivotGridControl1.TabIndex = 0
            '
            'excelDataSource1
            '
            Me.excelDataSource1.FileName = "\Data\SalesPerson2.xlsx"
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            FieldInfo1.Name = "CategoryName"
            FieldInfo1.OriginalName = "CategoryName"
            FieldInfo1.Type = GetType(String)
            FieldInfo2.Name = "Country"
            FieldInfo2.OriginalName = "Country"
            FieldInfo2.Type = GetType(String)
            FieldInfo3.Name = "ProductName"
            FieldInfo3.OriginalName = "ProductName"
            FieldInfo3.Type = GetType(String)
            FieldInfo4.Name = "Sales Person"
            FieldInfo4.OriginalName = "Sales Person"
            FieldInfo4.Type = GetType(String)
            FieldInfo5.Name = "OrderDate"
            FieldInfo5.OriginalName = "OrderDate"
            FieldInfo5.Type = GetType(Date)
            FieldInfo6.Name = "OrderID"
            FieldInfo6.OriginalName = "OrderID"
            FieldInfo6.Type = GetType(Double)
            FieldInfo7.Name = "Quantity"
            FieldInfo7.OriginalName = "Quantity"
            FieldInfo7.Type = GetType(Double)
            FieldInfo8.Name = "Discount"
            FieldInfo8.OriginalName = "Discount"
            FieldInfo8.Type = GetType(Double)
            FieldInfo9.Name = "Extended Price"
            FieldInfo9.OriginalName = "Extended Price"
            FieldInfo9.Type = GetType(Double)
            FieldInfo10.Name = "UnitPrice"
            FieldInfo10.OriginalName = "UnitPrice"
            FieldInfo10.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {FieldInfo1, FieldInfo2, FieldInfo3, FieldInfo4, FieldInfo5, FieldInfo6, FieldInfo7, FieldInfo8, FieldInfo9, FieldInfo10})
            ExcelWorksheetSettings1.CellRange = Nothing
            ExcelWorksheetSettings1.WorksheetIndex = Nothing
            ExcelWorksheetSettings1.WorksheetName = "Sheet1"
            ExcelSourceOptions1.ImportSettings = ExcelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = ExcelSourceOptions1
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
	End Class
End Namespace

