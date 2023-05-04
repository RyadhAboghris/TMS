namespace TMS.PL
{
    partial class FRM_USER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_USER));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRole = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tBUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTMSDataSet = new TMS.DBTMSDataSet();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.toastNotificationsManager2 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.tB_UsersTableAdapter = new TMS.DBTMSDataSetTableAdapters.TB_UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTMSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(TMS.TB_Users);
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
            this.colID,
            this.colFullName,
            this.colUserName,
            this.colPassword,
            this.colRole,
            this.colState});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.MinWidth = 25;
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 94;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.MinWidth = 25;
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 2;
            this.colUserName.Width = 94;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 25;
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 3;
            this.colPassword.Width = 94;
            // 
            // colRole
            // 
            this.colRole.FieldName = "Role";
            this.colRole.MinWidth = 25;
            this.colRole.Name = "colRole";
            this.colRole.Visible = true;
            this.colRole.VisibleIndex = 4;
            this.colRole.Width = 94;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.MinWidth = 25;
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 5;
            this.colState.Width = 94;
            // 
            // tBUsersBindingSource
            // 
            this.tBUsersBindingSource.DataMember = "TB_Users";
            this.tBUsersBindingSource.DataSource = this.dBTMSDataSetBindingSource;
            // 
            // dBTMSDataSetBindingSource
            // 
            this.dBTMSDataSetBindingSource.DataSource = this.dBTMSDataSet;
            this.dBTMSDataSetBindingSource.Position = 0;
            // 
            // dBTMSDataSet
            // 
            this.dBTMSDataSet.DataSetName = "DBTMSDataSet";
            this.dBTMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(754, 11);
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
            this.panel1.Location = new System.Drawing.Point(0, 638);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 82);
            this.panel1.TabIndex = 2;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(127, 13);
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
            this.simpleButton3.Location = new System.Drawing.Point(336, 13);
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
            this.simpleButton2.Location = new System.Drawing.Point(545, 13);
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
            // tB_UsersTableAdapter
            // 
            this.tB_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRM_USER";
            this.Size = new System.Drawing.Size(1080, 720);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTMSDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource tBUsersBindingSource;
        private System.Windows.Forms.BindingSource dBTMSDataSetBindingSource;
        private DBTMSDataSet dBTMSDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colRole;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DBTMSDataSetTableAdapters.TB_UsersTableAdapter tB_UsersTableAdapter;
    }
}
