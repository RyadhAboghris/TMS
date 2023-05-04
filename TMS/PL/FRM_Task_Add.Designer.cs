namespace TMS.PL
{
    partial class FRM_Task_Add
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Task_Add));
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.edt_project = new System.Windows.Forms.ComboBox();
            this.edt_user = new System.Windows.Forms.ComboBox();
            this.edt_manger = new System.Windows.Forms.ComboBox();
            this.edt_taskdes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_taskname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbox_done = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edt_duration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edt_enddate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_startdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "10586bad-5574-4f49-9b88-a2b13f2180b3";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("bfd447e2-ed8b-4663-ab05-cb67d842763b", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية الاضافة بنجاح", "تمت عملية الاضافة بنجاح", "تمت عملية الاضافة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b116da34-9386-4ef0-a7b8-24ba094d47b0", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "  private  void AddData()", "تمت عملية التعديل بنجاح", "  private  void AddData()", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.edt_project);
            this.groupBox1.Controls.Add(this.edt_user);
            this.groupBox1.Controls.Add(this.edt_manger);
            this.groupBox1.Controls.Add(this.edt_taskdes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edt_taskname);
            this.groupBox1.Location = new System.Drawing.Point(559, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(448, 573);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "عام";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(25, 313);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 22);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "اضافة";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // edt_project
            // 
            this.edt_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_project.FormattingEnabled = true;
            this.edt_project.Location = new System.Drawing.Point(8, 344);
            this.edt_project.Name = "edt_project";
            this.edt_project.Size = new System.Drawing.Size(434, 34);
            this.edt_project.TabIndex = 14;
            // 
            // edt_user
            // 
            this.edt_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_user.FormattingEnabled = true;
            this.edt_user.Location = new System.Drawing.Point(8, 255);
            this.edt_user.Name = "edt_user";
            this.edt_user.Size = new System.Drawing.Size(434, 34);
            this.edt_user.TabIndex = 14;
            // 
            // edt_manger
            // 
            this.edt_manger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_manger.FormattingEnabled = true;
            this.edt_manger.Location = new System.Drawing.Point(6, 180);
            this.edt_manger.Name = "edt_manger";
            this.edt_manger.Size = new System.Drawing.Size(434, 34);
            this.edt_manger.TabIndex = 14;
            // 
            // edt_taskdes
            // 
            this.edt_taskdes.Location = new System.Drawing.Point(4, 433);
            this.edt_taskdes.Name = "edt_taskdes";
            this.edt_taskdes.Size = new System.Drawing.Size(436, 123);
            this.edt_taskdes.TabIndex = 13;
            this.edt_taskdes.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(304, 402);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(136, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "وصف الفعالية";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(310, 313);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(130, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "اسم المشروع";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(339, 226);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "المستخدم";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(375, 137);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "المدير";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(316, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "اسم الفعالية";
            // 
            // edt_taskname
            // 
            this.edt_taskname.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_taskname.Location = new System.Drawing.Point(4, 86);
            this.edt_taskname.Name = "edt_taskname";
            this.edt_taskname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edt_taskname.Size = new System.Drawing.Size(436, 33);
            this.edt_taskname.TabIndex = 12;
            this.edt_taskname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbox_done);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.edt_duration);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.edt_enddate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.edt_startdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(448, 573);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عام";
            // 
            // chbox_done
            // 
            this.chbox_done.AutoSize = true;
            this.chbox_done.Font = new System.Drawing.Font("LBC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_done.Location = new System.Drawing.Point(69, 288);
            this.chbox_done.Name = "chbox_done";
            this.chbox_done.Size = new System.Drawing.Size(83, 26);
            this.chbox_done.TabIndex = 16;
            this.chbox_done.Text = "مكتمل";
            this.chbox_done.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(73, 334);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(71, 43);
            this.label9.TabIndex = 15;
            this.label9.Text = "يوم";
            // 
            // edt_duration
            // 
            this.edt_duration.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_duration.Location = new System.Drawing.Point(150, 331);
            this.edt_duration.Name = "edt_duration";
            this.edt_duration.ReadOnly = true;
            this.edt_duration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edt_duration.Size = new System.Drawing.Size(230, 50);
            this.edt_duration.TabIndex = 14;
            this.edt_duration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(201, 273);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(99, 43);
            this.label8.TabIndex = 6;
            this.label8.Text = "المدة";
            // 
            // edt_enddate
            // 
            this.edt_enddate.Location = new System.Drawing.Point(6, 172);
            this.edt_enddate.Name = "edt_enddate";
            this.edt_enddate.Size = new System.Drawing.Size(433, 33);
            this.edt_enddate.TabIndex = 5;
            this.edt_enddate.ValueChanged += new System.EventHandler(this.edt_enddate_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(312, 137);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(133, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "نهاية الفعالية";
            // 
            // edt_startdate
            // 
            this.edt_startdate.Location = new System.Drawing.Point(6, 86);
            this.edt_startdate.Name = "edt_startdate";
            this.edt_startdate.Size = new System.Drawing.Size(433, 33);
            this.edt_startdate.TabIndex = 3;
            this.edt_startdate.ValueChanged += new System.EventHandler(this.edt_startdate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(312, 49);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "بداية الفعالية";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_save.ImageOptions.SvgImage")));
            this.btn_save.Location = new System.Drawing.Point(0, 644);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_save.Size = new System.Drawing.Size(1024, 59);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FRM_Task_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 703);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Task_Add";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مستخدم";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FRM_Task_Add_Activated);
            this.Load += new System.EventHandler(this.FRM_Task_Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox edt_taskname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox edt_duration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbox_done;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        public System.Windows.Forms.RichTextBox edt_taskdes;
        public System.Windows.Forms.DateTimePicker edt_enddate;
        public System.Windows.Forms.DateTimePicker edt_startdate;
        public System.Windows.Forms.ComboBox edt_project;
        public System.Windows.Forms.ComboBox edt_user;
        public System.Windows.Forms.ComboBox edt_manger;
    }
}