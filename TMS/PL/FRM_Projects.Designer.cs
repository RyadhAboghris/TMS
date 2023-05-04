namespace TMS.PL
{
    partial class FRM_Projects
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Projects));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprojectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprojectDes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dbtmsDataSet1 = new TMS.DBTMSDataSet();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.toastNotificationsManager2 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.tB_ProjectsTableAdapter1 = new TMS.DBTMSDataSetTableAdapters.TB_ProjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtmsDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(TMS.TB_Projects);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1080, 720);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprojectName,
            this.colprojectDes});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colprojectName
            // 
            this.colprojectName.Caption = "اسم المشروع";
            this.colprojectName.FieldName = "projectName";
            this.colprojectName.MinWidth = 25;
            this.colprojectName.Name = "colprojectName";
            this.colprojectName.Visible = true;
            this.colprojectName.VisibleIndex = 0;
            this.colprojectName.Width = 94;
            // 
            // colprojectDes
            // 
            this.colprojectDes.Caption = "وصف المشروع";
            this.colprojectDes.FieldName = "projectDes";
            this.colprojectDes.MinWidth = 25;
            this.colprojectDes.Name = "colprojectDes";
            this.colprojectDes.OptionsColumn.AllowEdit = false;
            this.colprojectDes.Visible = true;
            this.colprojectDes.VisibleIndex = 1;
            this.colprojectDes.Width = 94;
            // 
            // dbtmsDataSet1
            // 
            this.dbtmsDataSet1.DataSetName = "DBTMSDataSet";
            this.dbtmsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(754, 5);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(199, 59);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "تحديث";
            this.simpleButton1.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 649);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 71);
            this.panel1.TabIndex = 2;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(127, 7);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton4.Size = new System.Drawing.Size(199, 59);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "اضافة";
            this.simpleButton4.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(336, 7);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton3.Size = new System.Drawing.Size(199, 59);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "تعديل";
            this.simpleButton3.Click += new System.EventHandler(this.button1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(545, 7);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton2.Size = new System.Drawing.Size(199, 59);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "حذف";
            this.simpleButton2.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "10586bad-5574-4f49-9b88-a2b13f2180b3";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("638bf85f-6b40-485b-93eb-c022c4c18b3e", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تم الحذف بنجاح", "تم الحذف بنجاح", "تم الحذف بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // toastNotificationsManager2
            // 
            this.toastNotificationsManager2.ApplicationId = "10586bad-5574-4f49-9b88-a2b13f2180b3";
            // 
            // tB_ProjectsTableAdapter1
            // 
            this.tB_ProjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // FRM_Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRM_Projects";
            this.Size = new System.Drawing.Size(1080, 720);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtmsDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager2;
        private DBTMSDataSet dbtmsDataSet1;
        private DBTMSDataSetTableAdapters.TB_ProjectsTableAdapter tB_ProjectsTableAdapter1;
        private DevExpress.XtraGrid.Columns.GridColumn colprojectName;
        private DevExpress.XtraGrid.Columns.GridColumn colprojectDes;
    }
}
