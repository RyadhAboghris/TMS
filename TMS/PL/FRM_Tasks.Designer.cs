namespace TMS.PL
{
    partial class FRM_Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Tasks));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTask_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Project = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_Duration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dbtmsDataSet1 = new TMS.DBTMSDataSet();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_done = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.toastNotificationsManager2 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.tB_ProjectsTableAdapter1 = new TMS.DBTMSDataSetTableAdapters.TB_ProjectsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
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
            this.gridControl1.DataSource = typeof(TMS.TB_Tasks);
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
            this.colTask_Name,
            this.colTask_Des,
            this.colTask_User,
            this.colTask_Project,
            this.colTask_Start,
            this.colTask_End,
            this.colTask_Duration,
            this.colTask_State});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colTask_Name
            // 
            this.colTask_Name.Caption = "الفاعلية";
            this.colTask_Name.FieldName = "Task_Name";
            this.colTask_Name.MinWidth = 25;
            this.colTask_Name.Name = "colTask_Name";
            this.colTask_Name.OptionsColumn.AllowEdit = false;
            this.colTask_Name.Visible = true;
            this.colTask_Name.VisibleIndex = 0;
            this.colTask_Name.Width = 94;
            // 
            // colTask_Des
            // 
            this.colTask_Des.Caption = "الوصف";
            this.colTask_Des.FieldName = "Task_Des";
            this.colTask_Des.MinWidth = 25;
            this.colTask_Des.Name = "colTask_Des";
            this.colTask_Des.OptionsColumn.AllowEdit = false;
            this.colTask_Des.Visible = true;
            this.colTask_Des.VisibleIndex = 1;
            this.colTask_Des.Width = 94;
            // 
            // colTask_User
            // 
            this.colTask_User.Caption = "المستخدم";
            this.colTask_User.FieldName = "Task_User";
            this.colTask_User.MinWidth = 25;
            this.colTask_User.Name = "colTask_User";
            this.colTask_User.OptionsColumn.AllowEdit = false;
            this.colTask_User.Visible = true;
            this.colTask_User.VisibleIndex = 2;
            this.colTask_User.Width = 94;
            // 
            // colTask_Project
            // 
            this.colTask_Project.Caption = "المشروع";
            this.colTask_Project.FieldName = "Task_Project";
            this.colTask_Project.MinWidth = 25;
            this.colTask_Project.Name = "colTask_Project";
            this.colTask_Project.OptionsColumn.AllowEdit = false;
            this.colTask_Project.Visible = true;
            this.colTask_Project.VisibleIndex = 3;
            this.colTask_Project.Width = 94;
            // 
            // colTask_Start
            // 
            this.colTask_Start.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colTask_Start.AppearanceCell.Options.UseBackColor = true;
            this.colTask_Start.Caption = "بداية";
            this.colTask_Start.FieldName = "Task_Start";
            this.colTask_Start.MinWidth = 25;
            this.colTask_Start.Name = "colTask_Start";
            this.colTask_Start.OptionsColumn.AllowEdit = false;
            this.colTask_Start.Visible = true;
            this.colTask_Start.VisibleIndex = 4;
            this.colTask_Start.Width = 94;
            // 
            // colTask_End
            // 
            this.colTask_End.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colTask_End.AppearanceCell.Options.UseBackColor = true;
            this.colTask_End.Caption = "نهاية";
            this.colTask_End.FieldName = "Task_End";
            this.colTask_End.MinWidth = 25;
            this.colTask_End.Name = "colTask_End";
            this.colTask_End.OptionsColumn.AllowEdit = false;
            this.colTask_End.Visible = true;
            this.colTask_End.VisibleIndex = 5;
            this.colTask_End.Width = 94;
            // 
            // colTask_Duration
            // 
            this.colTask_Duration.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.colTask_Duration.AppearanceCell.Options.UseBackColor = true;
            this.colTask_Duration.Caption = "الفترة اليوم";
            this.colTask_Duration.FieldName = "Task_Duration";
            this.colTask_Duration.MinWidth = 25;
            this.colTask_Duration.Name = "colTask_Duration";
            this.colTask_Duration.OptionsColumn.AllowEdit = false;
            this.colTask_Duration.Visible = true;
            this.colTask_Duration.VisibleIndex = 6;
            this.colTask_Duration.Width = 94;
            // 
            // colTask_State
            // 
            this.colTask_State.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colTask_State.AppearanceCell.Options.UseBackColor = true;
            this.colTask_State.Caption = "الحالة";
            this.colTask_State.FieldName = "Task_State";
            this.colTask_State.MinWidth = 25;
            this.colTask_State.Name = "colTask_State";
            this.colTask_State.OptionsColumn.AllowEdit = false;
            this.colTask_State.Visible = true;
            this.colTask_State.VisibleIndex = 7;
            this.colTask_State.Width = 94;
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
            this.simpleButton1.Location = new System.Drawing.Point(649, 6);
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
            this.panel1.Controls.Add(this.btn_done);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 646);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 74);
            this.panel1.TabIndex = 2;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(22, 8);
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
            this.simpleButton3.Location = new System.Drawing.Point(231, 8);
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
            this.simpleButton2.Location = new System.Drawing.Point(440, 8);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton2.Size = new System.Drawing.Size(199, 59);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "حذف";
            this.simpleButton2.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_done
            // 
            this.btn_done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_done.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Appearance.Options.UseFont = true;
            this.btn_done.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_done.ImageOptions.SvgImage")));
            this.btn_done.Location = new System.Drawing.Point(858, 6);
            this.btn_done.Margin = new System.Windows.Forms.Padding(5);
            this.btn_done.Name = "btn_done";
            this.btn_done.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_done.Size = new System.Drawing.Size(199, 59);
            this.btn_done.TabIndex = 1;
            this.btn_done.Text = "تم";
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "10586bad-5574-4f49-9b88-a2b13f2180b3";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("638bf85f-6b40-485b-93eb-c022c4c18b3e", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تم الحذف بنجاح", "تم الحذف بنجاح", "تم الحذف بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("a65863c1-c1a0-4a6f-bc12-1a698dd52071", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "تم اكتمال المهمة", "تم اكتمال المهمة", "تم اكتمال المهمة", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // toastNotificationsManager2
            // 
            this.toastNotificationsManager2.ApplicationId = "10586bad-5574-4f49-9b88-a2b13f2180b3";
            // 
            // tB_ProjectsTableAdapter1
            // 
            this.tB_ProjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = global::TMS.Properties.Settings.Default.StateTime;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = Properties.Settings.Default.UpdateData;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FRM_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRM_Tasks";
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
        private DevExpress.XtraEditors.SimpleButton btn_done;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Des;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_User;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Project;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Start;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_End;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_Duration;
        private DevExpress.XtraGrid.Columns.GridColumn colTask_State;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
