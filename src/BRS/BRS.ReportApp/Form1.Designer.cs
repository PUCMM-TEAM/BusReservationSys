namespace BRS.ReportApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.BRSDBDataSet = new BRS.ReportApp.BRSDBDataSet();
      this.DestinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.DestinationTableAdapter = new BRS.ReportApp.BRSDBDataSetTableAdapters.DestinationTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.BRSDBDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DestinationBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource1.Name = "DbSetRoute";
      reportDataSource1.Value = this.DestinationBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "BRS.ReportApp.Report1.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.Size = new System.Drawing.Size(909, 475);
      this.reportViewer1.TabIndex = 0;
      // 
      // BRSDBDataSet
      // 
      this.BRSDBDataSet.DataSetName = "BRSDBDataSet";
      this.BRSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // DestinationBindingSource
      // 
      this.DestinationBindingSource.DataMember = "Destination";
      this.DestinationBindingSource.DataSource = this.BRSDBDataSet;
      // 
      // DestinationTableAdapter
      // 
      this.DestinationTableAdapter.ClearBeforeFill = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(909, 475);
      this.Controls.Add(this.reportViewer1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.BRSDBDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DestinationBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DestinationBindingSource;
        private BRSDBDataSet BRSDBDataSet;
        private BRSDBDataSetTableAdapters.DestinationTableAdapter DestinationTableAdapter;
    }
}

