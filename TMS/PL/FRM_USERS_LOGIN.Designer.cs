namespace TMS.PL
{
    partial class FRM_USERS_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_USERS_LOGIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_userName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_password = new System.Windows.Forms.TextBox();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 200);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_userName
            // 
            this.lb_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("LBC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.ForeColor = System.Drawing.Color.Gray;
            this.lb_userName.Location = new System.Drawing.Point(220, 152);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(222, 43);
            this.lb_userName.TabIndex = 1;
            this.lb_userName.Text = "تسجيل الدخول";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(338, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المستخدم";
            // 
            // edt_username
            // 
            this.edt_username.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_username.Location = new System.Drawing.Point(115, 418);
            this.edt_username.Name = "edt_username";
            this.edt_username.Size = new System.Drawing.Size(392, 37);
            this.edt_username.TabIndex = 2;
            this.edt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(393, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "كلمة السر";
            // 
            // edt_password
            // 
            this.edt_password.Font = new System.Drawing.Font("LBC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_password.Location = new System.Drawing.Point(115, 514);
            this.edt_password.Name = "edt_password";
            this.edt_password.Size = new System.Drawing.Size(392, 37);
            this.edt_password.TabIndex = 2;
            this.edt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_save.ImageOptions.SvgImage")));
            this.btn_save.Location = new System.Drawing.Point(0, 629);
            this.btn_save.Margin = new System.Windows.Forms.Padding(6);
            this.btn_save.Name = "btn_save";
            this.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_save.Size = new System.Drawing.Size(622, 74);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "تسجيل الدخول";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "10586bad-5574-4f49-9b88-a2b13f2180b3";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("bfd447e2-ed8b-4663-ab05-cb67d842763b", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية الاضافة بنجاح", "تمت عملية الاضافة بنجاح", "تمت عملية الاضافة بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b116da34-9386-4ef0-a7b8-24ba094d47b0", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "  private  void AddData()", "تمت عملية التعديل بنجاح", "  private  void AddData()", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // FRM_USERS_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 703);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.edt_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_userName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_USERS_LOGIN";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_USERS_LOGIN_FormClosing);
            this.Leave += new System.EventHandler(this.FRM_USERS_LOGIN_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        public System.Windows.Forms.TextBox edt_username;
        public System.Windows.Forms.TextBox edt_password;
    }
}