
namespace CustomGroupIntervals
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo10 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.excelDataSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(800, 450);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.FileName = "Data\\SalesPerson2.xlsx";
            this.excelDataSource1.Name = "excelDataSource1";
            this.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "CategoryName";
            fieldInfo1.OriginalName = "CategoryName";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "Country";
            fieldInfo2.OriginalName = "Country";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "ProductName";
            fieldInfo3.OriginalName = "ProductName";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "Sales Person";
            fieldInfo4.OriginalName = "Sales Person";
            fieldInfo4.Type = typeof(string);
            fieldInfo5.Name = "OrderDate";
            fieldInfo5.OriginalName = "OrderDate";
            fieldInfo5.Type = typeof(System.DateTime);
            fieldInfo6.Name = "OrderID";
            fieldInfo6.OriginalName = "OrderID";
            fieldInfo6.Type = typeof(double);
            fieldInfo7.Name = "Quantity";
            fieldInfo7.OriginalName = "Quantity";
            fieldInfo7.Type = typeof(double);
            fieldInfo8.Name = "Discount";
            fieldInfo8.OriginalName = "Discount";
            fieldInfo8.Type = typeof(double);
            fieldInfo9.Name = "Extended Price";
            fieldInfo9.OriginalName = "Extended Price";
            fieldInfo9.Type = typeof(double);
            fieldInfo10.Name = "UnitPrice";
            fieldInfo10.OriginalName = "UnitPrice";
            fieldInfo10.Type = typeof(double);
            this.excelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9,
            fieldInfo10});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetIndex = null;
            excelWorksheetSettings1.WorksheetName = "Sheet1";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.excelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
    }
}

