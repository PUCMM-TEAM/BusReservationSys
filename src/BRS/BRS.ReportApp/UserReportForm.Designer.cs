namespace BRS.ReportApp {
  partial class UserReportForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
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
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this._aspnet_BRS_WebUI_20151116060626DataSet = new BRS.ReportApp._aspnet_BRS_WebUI_20151116060626DataSet();
      this.AspNetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.AspNetUsersTableAdapter = new BRS.ReportApp._aspnet_BRS_WebUI_20151116060626DataSetTableAdapters.AspNetUsersTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this._aspnet_BRS_WebUI_20151116060626DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.AspNetUsersBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      reportDataSource1.Name = "UserDataSet";
      reportDataSource1.Value = this.AspNetUsersBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "BRS.ReportApp.Report2.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(-3, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.Size = new System.Drawing.Size(624, 432);
      this.reportViewer1.TabIndex = 0;
      // 
      // _aspnet_BRS_WebUI_20151116060626DataSet
      // 
      this._aspnet_BRS_WebUI_20151116060626DataSet.DataSetName = "_aspnet_BRS_WebUI_20151116060626DataSet";
      this._aspnet_BRS_WebUI_20151116060626DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // AspNetUsersBindingSource
      // 
      this.AspNetUsersBindingSource.DataMember = "AspNetUsers";
      this.AspNetUsersBindingSource.DataSource = this._aspnet_BRS_WebUI_20151116060626DataSet;
      // 
      // AspNetUsersTableAdapter
      // 
      this.AspNetUsersTableAdapter.ClearBeforeFill = true;
      // 
      // UserReportForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(622, 433);
      this.Controls.Add(this.reportViewer1);
      this.Name = "UserReportForm";
      this.Text = "UserReportForm";
      this.Load += new System.EventHandler(this.UserReportForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this._aspnet_BRS_WebUI_20151116060626DataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.AspNetUsersBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.BindingSource AspNetUsersBindingSource;
    private _aspnet_BRS_WebUI_20151116060626DataSet _aspnet_BRS_WebUI_20151116060626DataSet;
    private _aspnet_BRS_WebUI_20151116060626DataSetTableAdapters.AspNetUsersTableAdapter AspNetUsersTableAdapter;
  }
}